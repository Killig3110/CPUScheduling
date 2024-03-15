using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FCFS.frm_FCFS;

namespace FCFS
{
    public partial class frm_FCFS : Form
    {
        public bool check = false;
        public frm_FCFS()
        {
            InitializeComponent();
            frm_FCFS_Load(this, null);
        }

        public class Process
        {
            public string Name { get; set; }
            public int ArrivalTime { get; set; }
            public int BurstTime { get; set; }
            public int Priority { get; set; }

            public Process(string name, int arrivalTime, int burstTime, int priority)
            {
                Name = name;
                ArrivalTime = arrivalTime;
                BurstTime = burstTime;
                Priority = priority;
            }
        }

        public class GanttBar
        {
            public string ProcessName { get; set; }
            public int StartTime { get; set; }
            public int ArrivalTime { get; set; }
            public int BurstTime { get; set; }
            public int EndTime { get; set; }
            public GanttBar(string processName, int startTime, int arrivalTime,int burstTime ,int endTime)
            {
                ProcessName = processName;
                StartTime = startTime;
                ArrivalTime = arrivalTime;
                BurstTime = burstTime;
                EndTime = endTime;
            }
        }
        private void frm_FCFS_Load(object sender, EventArgs e)
        {
            check = false;
            lb_Algorithms.Text = "Algorithms";
            data.Rows.Clear();
            data.Refresh();
            ganttChartPanel.Refresh();
            tbx_Result.Clear();
            tbx_quantum.Clear();
            tbx_quantum.Visible = false;
            rbtn_NonPreemptive.Checked = false;
            rbtn_Preemptive.Checked = false;
            data.Columns["processPriority"].Visible = false;
            data.Columns["processName"].Width = 50;
            data.Columns["processArrivalTime"].Width = 110;
            data.Columns["processBurstTime"].Width = 110;
            data.Columns["processName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data.Columns["processPriority"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data.Columns["processArrivalTime"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data.Columns["processBurstTime"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            panel2.Visible = false;
            lb_TmeTotal.Text = "Total Time: ";
        }

        private void fCFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_FCFS_Load(sender, e);
            lb_Algorithms.Text = "FCFS";
            check = true;
            lb_Quantum.Visible = false;
            tbx_quantum.Visible = false;
            panel2.Visible = false;
        }

        private void sJFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_FCFS_Load(sender, e);
            lb_Algorithms.Text = "SJF";
            check = true;
            lb_Quantum.Visible = false;
            panel2.Visible = true;
            rbtn_Preemptive.Visible = true;
            rbtn_NonPreemptive.Visible = true;
            tbx_quantum.Visible = false;

        }

        private void rBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_FCFS_Load(sender, e);
            lb_Algorithms.Text = "Round Robin";
            check = true;
            panel2.Visible = false;
            lb_Quantum.Visible = true;
            tbx_quantum.Visible = true;

        }

        private void priorityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_FCFS_Load(sender, e);
            lb_Algorithms.Text = "Priority";
            check = true;
            lb_Quantum.Visible = false;
            tbx_quantum.Visible = false;
            panel2.Visible = true;
            data.Columns["processPriority"].Visible = true;
            data.Columns["processArrivalTime"].Width = 75;
            data.Columns["processBurstTime"].Width = 75;
            data.Columns["processPriority"].Width = 75;
        }

        private void priorityWithRBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_FCFS_Load(sender, e);
            lb_Algorithms.Text = "Priority with RB";
            check = true;
            lb_Quantum.Visible = true;
            tbx_quantum.Visible = true;
            data.Columns["processPriority"].Visible = true;
            data.Columns["processArrivalTime"].Width = 75;
            data.Columns["processBurstTime"].Width = 75;
            data.Columns["processPriority"].Width = 75;
        }

        private int processCount = 0; // Biến đếm số tiến trình đã được thêm, bắt đầu từ 1


        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                string name = "P" + processCount;
                data.Enabled = true;
                //random arrival time từ 0 đến 10
                Random random = new Random();
                int arrivalTime = random.Next(0, 10);
                //random burst time từ 2 đến 10
                int burstTime = random.Next(2, 10);
                //random priority từ 1 đến 10
                int priority = random.Next(1, 10);
                Process newProcess = new Process(name, arrivalTime, burstTime, priority);
                AddProcessToDataGridView(newProcess);
                SortDataGridViewByName();
                processCount = data.Rows.Count;
            }
            else
            {
                MessageBox.Show("Please choose the algorithms", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProcessToDataGridView(Process process)
        {
            // Thêm dòng mới vào DataGridView với thông tin của tiến trình vừa tạo
            data.Rows.Add(process.Name, process.ArrivalTime, process.BurstTime, process.Priority);
        }

        private void SortDataGridViewByName()
        {
            // Sắp xếp lại các dòng trong DataGridView theo tên của các tiến trình
            data.Sort(data.Columns[0], ListSortDirection.Ascending);
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (data.SelectedRows.Count > 0)
            {
                int selectedIndex = data.SelectedRows[0].Index;
                RemoveProcessFromDataGridView(selectedIndex);
                processCount = selectedIndex; // Cập nhật lại biến đếm số tiến trình
            }
        }

        private void RemoveProcessFromDataGridView(int rowIndex)
        {
            data.Rows.RemoveAt(rowIndex);
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            List<GanttBar> ganttBars = new List<GanttBar>();
            List<Process> processes = ExtractProcessesFromDataGridView();
            if (check == true)
            {
                
                if (processes != null)
                {
                    
                    if (lb_Algorithms.Text == "FCFS")
                    {
                        ganttBars = FCFS(processes);
                    }
                    else if (lb_Algorithms.Text == "SJF")
                    {
                        if (rbtn_NonPreemptive.Checked)
                        {
                            ganttBars = SJF_non_preemptive(processes);
                        }
                        else if (rbtn_Preemptive.Checked)
                        {
                            ganttBars = SJF_preemptive(processes);
                        }
                        else
                        {
                               MessageBox.Show("Please choose the algorithms", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }    
                    }
                    else if (lb_Algorithms.Text == "Round Robin")
                    {
                        int timeQuantum;
                        if (int.TryParse(tbx_quantum.Text, out timeQuantum))
                        {
                            ganttBars = RoundRobin(processes, timeQuantum);
                        }
                        else
                        {
                            MessageBox.Show("Please enter the correct time quantum", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else if (lb_Algorithms.Text == "Priority")
                    {
                        if (rbtn_NonPreemptive.Checked)
                        {
                            ganttBars = priority_non_preemptive(processes);
                        }
                        else if (rbtn_Preemptive.Checked)
                        {
                            ganttBars = priority_preemptive(processes);
                        }
                    }
                    else if (lb_Algorithms.Text == "Priority with RB")
                    {
                        int timeQuantum;
                        if (int.TryParse(tbx_quantum.Text, out timeQuantum))
                        {
                            ganttBars = priority_withRB(processes, timeQuantum);
                        }
                        else
                        {
                            MessageBox.Show("Please enter the correct time quantum", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    DrawGanttChart(ganttBars);
                    DrawTimeChart(ganttBars);
                    DisplayProcessTable(ganttBars);
                }
            }
            else
            {
                MessageBox.Show("Please choose the algorithms", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Process> ExtractProcessesFromDataGridView()
        {
            List<Process> processes = new List<Process>();

            foreach (DataGridViewRow row in data.Rows)
            {
                if (row.IsNewRow) continue;

                //kiểm tra xem các giá trị có null không
                if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null)
                {
                    MessageBox.Show("Please enter the correct data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    string name = row.Cells["processName"].Value.ToString();
                    int startTime = int.Parse(row.Cells["processArrivalTime"].Value.ToString());
                    int burstTime = int.Parse(row.Cells["processBurstTime"].Value.ToString());
                    int priority = int.Parse(row.Cells["processPriority"].Value.ToString());

                    if (startTime < 0 || burstTime < 0 || priority < 0)
                    {
                        MessageBox.Show("Please enter the correct data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }

                    processes.Add(new Process(name, startTime, burstTime, priority));

                }
            }

            return processes;
        }

        private List<GanttBar> FCFS(List<Process> processes)
        {
            List<GanttBar> ganttBars = new List<GanttBar>();

            //sắp xếp lại các process theo thời gian đến
            processes.Sort((a, b) => a.ArrivalTime.CompareTo(b.ArrivalTime));
            int currentTime = processes[0].ArrivalTime;

            foreach (Process process in processes)
            {
                // Tạo GanttBar cho tiến trình hiện tại
                GanttBar ganntBar = new GanttBar(process.Name, currentTime, process.ArrivalTime,process.BurstTime, currentTime + process.BurstTime);

                // Thêm GanttBar vào danh sách
                ganttBars.Add(ganntBar);

                // Cập nhật thời gian hiện tại
                currentTime = ganntBar.EndTime;
            }

            return ganttBars;
        }

        private List<GanttBar> SJF_non_preemptive(List<Process> processes)
        {
            List<GanttBar> ganttBars = new List<GanttBar>();

            //tìm thời gian đến nhỏ nhất
            int currentTime = processes.Min(p => p.ArrivalTime);

            int totalProcesses = processes.Count;

            while (ganttBars.Count < totalProcesses)
            {
                // Lọc ra các tiến trình đã đến và chưa hoàn thành
                var arrivedProcesses = processes.Where(p => p.ArrivalTime <= currentTime && !ganttBars.Any(g => g.ProcessName == p.Name)).ToList();

                if (arrivedProcesses.Count > 0)
                {
                    // Sắp xếp các tiến trình theo burst time tăng dần, nếu có burst time bằng nhau thì ưu tiên tiến trình đến sớm hơn
                    arrivedProcesses.Sort((a, b) =>
                    {
                        int result = a.BurstTime.CompareTo(b.BurstTime);
                        if (result == 0)
                            result = a.ArrivalTime.CompareTo(b.ArrivalTime);
                        return result;
                    });

                    Process shortestJob = arrivedProcesses.First();
                    int burstTime = shortestJob.BurstTime;

                    // Tạo GanttBar cho tiến trình có thời gian burst ngắn nhất
                    GanttBar ganntBar = new GanttBar(shortestJob.Name, currentTime, shortestJob.ArrivalTime, burstTime, currentTime + burstTime);

                    // Thêm GanttBar vào danh sách
                    ganttBars.Add(ganntBar);

                    // Cập nhật thời gian hiện tại
                    currentTime = ganntBar.EndTime;
                }
                else
                {
                    int nextArrivalTime = int.MaxValue; // Khởi tạo nextArrivalTime là giá trị lớn nhất của kiểu int

                    // Kiểm tra xem có tiến trình nào đến sau currentTime không
                    foreach (Process process in processes)
                    {
                        if (process.ArrivalTime > currentTime && process.ArrivalTime < nextArrivalTime)
                        {
                            nextArrivalTime = process.ArrivalTime;
                        }
                    }

                    // Kiểm tra nếu nextArrivalTime vẫn giữ giá trị ban đầu, tức là không có tiến trình nào đến sau currentTime
                    if (nextArrivalTime == int.MaxValue)
                    {
                        // Thực hiện xử lý khi không có tiến trình nào đến sau currentTime
                        break;
                    }

                }
            }

            return ganttBars;
        }

        private List<GanttBar> SJF_preemptive(List<Process> processes)
        {
            List<GanttBar> ganttBars = new List<GanttBar>();
            List<Process> readyQueue = new List<Process>();
            //tìm thời gian đến nhỏ nhất
            int currentTime = processes.Min(p => p.ArrivalTime);

            while (true)
            {
                // Lấy các tiến trình đã đến và chưa hoàn thành
                var arrivedProcesses = processes.Where(p => p.ArrivalTime <= currentTime && p.BurstTime > 0 && !readyQueue.Contains(p)).ToList();

                // Thêm các tiến trình đã đến vào hàng đợi sẵn sàng
                readyQueue.AddRange(arrivedProcesses);

                // Kiểm tra xem hàng đợi sẵn sàng có trống không
                if (readyQueue.Count == 0)
                {
                    // Nếu hàng đợi sẵn sàng trống và không còn tiến trình nào đến, thoát khỏi vòng lặp
                    if (arrivedProcesses.Count == 0)
                        break;
                    // Nếu hàng đợi sẵn sàng trống nhưng còn tiến trình đến, tăng thời gian lên cho đến khi có tiến trình đến
                    else
                        currentTime++;
                }
                else
                {
                    // Sắp xếp hàng đợi sẵn sàng theo thời gian còn lại ngắn nhất
                    readyQueue.Sort((a, b) => a.BurstTime.CompareTo(b.BurstTime));

                    // Lấy tiến trình có thời gian thực hiện ngắn nhất từ hàng đợi sẵn sàng
                    Process shortestJob = readyQueue.First();

                    // Tạo GanttBar cho tiến trình được chọn
                    GanttBar ganntBar = new GanttBar(shortestJob.Name, currentTime, shortestJob.ArrivalTime, shortestJob.BurstTime, currentTime + 1);

                    // Thêm GanttBar vào danh sách
                    ganttBars.Add(ganntBar);

                    // Giảm thời gian thực hiện của tiến trình được chọn
                    shortestJob.BurstTime--;

                    // Kiểm tra xem tiến trình đã hoàn thành chưa
                    if (shortestJob.BurstTime == 0)
                    {
                        // Nếu tiến trình đã hoàn thành, cập nhật thời gian kết thúc của GanttBar
                        ganntBar.EndTime = currentTime + 1;
                        // Loại bỏ tiến trình đã hoàn thành khỏi hàng đợi sẵn sàng
                        readyQueue.Remove(shortestJob);
                    }

                    // Cập nhật thời gian hiện tại
                    currentTime++;
                }
            }
            ganttBars = MergeSimilarGanttBars(ganttBars);
            return ganttBars;
        }

        private List<GanttBar> RoundRobin(List<Process> processes, int timeQuantum)
        {
            List<GanttBar> ganttBars = new List<GanttBar>();
            List<Process> readyQueue = new List<Process>();
            
            //tìm thời gian đến nhỏ nhất
            int currentTime = processes.Min(p => p.ArrivalTime);

            while (true)
            {
                // Lấy các tiến trình đã đến và chưa hoàn thành
                var arrivedProcesses = processes.Where(p => p.ArrivalTime <= currentTime && p.BurstTime > 0).ToList();

                // Thêm các tiến trình đã đến vào hàng đợi sẵn sàng
                foreach (var process in arrivedProcesses)
                {
                    if (!readyQueue.Any(p => p.Name == process.Name))
                    {
                        readyQueue.Add(process);
                    }
                }

                // Kiểm tra xem hàng đợi sẵn sàng có trống không
                if (readyQueue.Count == 0)
                {
                    // Nếu hàng đợi sẵn sàng trống và không còn tiến trình nào đến, thoát khỏi vòng lặp
                    if (arrivedProcesses.Count == 0)
                        break;
                    // Nếu hàng đợi sẵn sàng trống nhưng còn tiến trình đến, tăng thời gian lên cho đến khi có tiến trình đến
                    else
                        currentTime++;
                }
                else
                {
                    // Lấy tiến trình ở đầu hàng đợi sẵn sàng để thực thi
                    Process currentProcess = readyQueue.First();

                    // Kiểm tra xem tiến trình còn thời gian thực hiện không
                    if (currentProcess.BurstTime > 0)
                    {
                        // Tạo GanttBar cho tiến trình được chọn
                        int executionTime = Math.Min(timeQuantum, currentProcess.BurstTime); // Thời gian thực thi là thời gian quantum hoặc thời gian còn lại của tiến trình nếu nhỏ hơn
                        GanttBar ganttBar = new GanttBar(currentProcess.Name, currentTime, currentProcess.ArrivalTime, executionTime, currentTime + executionTime);

                        // Thêm GanttBar vào danh sách
                        ganttBars.Add(ganttBar);

                        // Giảm thời gian thực hiện của tiến trình
                        currentProcess.BurstTime -= executionTime;

                        // Kiểm tra xem tiến trình đã hoàn thành chưa
                        if (currentProcess.BurstTime == 0)
                        {
                            // Nếu tiến trình đã hoàn thành, cập nhật thời gian kết thúc của GanttBar
                            ganttBar.EndTime = currentTime + executionTime;
                            // Loại bỏ tiến trình đã hoàn thành khỏi hàng đợi sẵn sàng
                            readyQueue.Remove(currentProcess);
                        }
                        else
                        {
                            // Di chuyển tiến trình tới cuối hàng đợi chỉ khi nó còn thời gian thực hiện
                            readyQueue.RemoveAt(0);
                            readyQueue.Add(currentProcess);
                        }

                        // Cập nhật thời gian hiện tại
                        currentTime += executionTime;
                    }
                    else
                    {
                        // Nếu tiến trình không còn thời gian thực hiện, loại bỏ nó khỏi hàng đợi
                        readyQueue.RemoveAt(0);
                    }
                }
            }
            return ganttBars;
        }

        private List<GanttBar> priority_non_preemptive(List<Process> processes)
        {
            List<GanttBar> ganttBars = new List<GanttBar>();

            //tìm thời gian đến nhỏ nhất
            int currentTime = processes.Min(p => p.ArrivalTime);

            int totalProcesses = processes.Count;

            while (ganttBars.Count < totalProcesses)
            {
                // Lọc ra các tiến trình đã đến và chưa hoàn thành
                var arrivedProcesses = processes.Where(p => p.ArrivalTime <= currentTime && !ganttBars.Any(g => g.ProcessName == p.Name)).ToList();

                if (arrivedProcesses.Count > 0)
                {
                    // Sắp xếp các tiến trình theo độ ưu tiên tăng dần, nếu có độ ưu tiên bằng nhau thì ưu tiên tiến trình đến sớm hơn
                    arrivedProcesses.Sort((a, b) =>
                    {
                        int result = a.Priority.CompareTo(b.Priority);
                        if (result == 0)
                            result = a.ArrivalTime.CompareTo(b.ArrivalTime);
                        return result;
                    });

                    Process highestPriorityProcess = arrivedProcesses.First();
                    int burstTime = highestPriorityProcess.BurstTime;

                    // Tạo GanttBar cho tiến trình có độ ưu tiên cao nhất
                    GanttBar ganntBar = new GanttBar(highestPriorityProcess.Name, currentTime, highestPriorityProcess.ArrivalTime, burstTime, currentTime + burstTime);

                    // Thêm GanttBar vào danh sách
                    ganttBars.Add(ganntBar);

                    // Cập nhật thời gian hiện tại
                    currentTime = ganntBar.EndTime;
                }
                else
                {
                    int nextArrivalTime = int.MaxValue; // Khởi tạo nextArrivalTime là giá trị lớn nhất của kiểu int

                    // Kiểm tra xem có tiến trình nào đến sau currentTime không
                    foreach (Process process in processes)
                    {
                        if (process.ArrivalTime > currentTime && process.ArrivalTime < nextArrivalTime)
                        {
                            nextArrivalTime = process.ArrivalTime;
                        }
                    }

                    // Kiểm tra nếu nextArrivalTime vẫn giữ giá trị ban đầu, tức là không có tiến trình nào đến sau currentTime
                    if (nextArrivalTime == int.MaxValue)
                    {
                        // Thực hiện xử lý khi không có tiến trình nào đến sau currentTime
                        break;
                    }
                }
            }

            return ganttBars;
        }

        private List<GanttBar> priority_preemptive(List<Process> processes)
        {
            List<GanttBar> ganttBars = new List<GanttBar>();
            List<Process> readyQueue = new List<Process>();

            //tìm thời gian đến nhỏ nhất
            int currentTime = processes.Min(p => p.ArrivalTime);

            while (true)
            {
                // Lấy các tiến trình đã đến và chưa hoàn thành
                var arrivedProcesses = processes.Where(p => p.ArrivalTime <= currentTime && p.BurstTime > 0 && !readyQueue.Contains(p)).ToList();

                // Thêm các tiến trình đã đến vào hàng đợi sẵn sàng
                readyQueue.AddRange(arrivedProcesses);

                // Kiểm tra xem hàng đợi sẵn sàng có trống không
                if (readyQueue.Count == 0)
                {
                    // Nếu hàng đợi sẵn sàng trống và không còn tiến trình nào đến, thoát khỏi vòng lặp
                    if (arrivedProcesses.Count == 0)
                        break;
                    // Nếu hàng đợi sẵn sàng trống nhưng còn tiến trình đến, tăng thời gian lên cho đến khi có tiến trình đến
                    else
                        currentTime++;
                }
                else
                {
                    // Sắp xếp hàng đợi sẵn sàng theo độ ưu tiên tăng dần
                    readyQueue.Sort((a, b) => a.Priority.CompareTo(b.Priority));

                    // Lấy tiến trình có độ ưu tiên thấp nhất từ hàng đợi sẵn sàng
                    Process lowestPriorityProcess = readyQueue.First();

                    // Tạo GanttBar cho tiến trình được chọn
                    GanttBar ganntBar = new GanttBar(lowestPriorityProcess.Name, currentTime, lowestPriorityProcess.ArrivalTime, 1, currentTime + 1);

                    // Thêm GanttBar vào danh sách
                    ganttBars.Add(ganntBar);

                    // Giảm thời gian thực hiện của tiến trình được chọn
                    lowestPriorityProcess.BurstTime--;

                    // Kiểm tra xem tiến trình đã hoàn thành chưa
                    if (lowestPriorityProcess.BurstTime == 0)
                    {
                        // Nếu tiến trình đã hoàn thành, cập nhật thời gian kết thúc của GanttBar
                        ganntBar.EndTime = currentTime + 1;
                        // Loại bỏ tiến trình đã hoàn thành khỏi hàng đợi sẵn sàng
                        readyQueue.Remove(lowestPriorityProcess);
                    }

                    // Cập nhật thời gian hiện tại
                    currentTime++;
                }
            }
            ganttBars = MergeSimilarGanttBars(ganttBars);
            return ganttBars;
        }

        private List<GanttBar> priority_withRB(List<Process> processes, int timeQuantum)
        {
            List<GanttBar> ganttBars = new List<GanttBar>();
            List<Process> readyQueue = new List<Process>();

            //tìm thời gian đến nhỏ nhất
            int currentTime = processes.Min(p => p.ArrivalTime);

            while (true)
            {
                // Lấy các tiến trình đã đến và chưa hoàn thành
                var arrivedProcesses = processes.Where(p => p.ArrivalTime <= currentTime && p.BurstTime > 0).ToList();

                // Thêm các tiến trình đã đến vào hàng đợi sẵn sàng
                foreach (var process in arrivedProcesses)
                {
                    if (!readyQueue.Any(p => p.Name == process.Name))
                    {
                        readyQueue.Add(process);
                    }
                }

                // Kiểm tra xem hàng đợi sẵn sàng có trống không
                if (readyQueue.Count == 0)
                {
                    // Nếu hàng đợi sẵn sàng trống và không còn tiến trình nào đến, thoát khỏi vòng lặp
                    if (arrivedProcesses.Count == 0)
                        break;
                    // Nếu hàng đợi sẵn sàng trống nhưng còn tiến trình đến, tăng thời gian lên cho đến khi có tiến trình đến
                    else
                        currentTime++;
                }
                else
                {
                    // Sắp xếp hàng đợi sẵn sàng theo ưu tiên
                    readyQueue = readyQueue.OrderBy(p => p.Priority).ThenBy(p => p.ArrivalTime).ToList();


                    // Lấy tiến trình ở đầu hàng đợi sẵn sàng để thực thi
                    Process currentProcess = readyQueue.First();

                    // Kiểm tra xem tiến trình còn thời gian thực hiện không
                    if (currentProcess.BurstTime > 0)
                    {
                        // Tạo GanttBar cho tiến trình được chọn
                        int executionTime = Math.Min(timeQuantum, currentProcess.BurstTime); // Thời gian thực thi là thời gian quantum hoặc thời gian còn lại của tiến trình nếu nhỏ hơn
                        GanttBar ganttBar = new GanttBar(currentProcess.Name, currentTime, currentProcess.ArrivalTime, executionTime, currentTime + executionTime);

                        // Thêm GanttBar vào danh sách
                        ganttBars.Add(ganttBar);

                        // Giảm thời gian thực hiện của tiến trình
                        currentProcess.BurstTime -= executionTime;

                        // Kiểm tra xem tiến trình đã hoàn thành chưa
                        if (currentProcess.BurstTime == 0)
                        {
                            // Nếu tiến trình đã hoàn thành, cập nhật thời gian kết thúc của GanttBar
                            ganttBar.EndTime = currentTime + executionTime;
                            // Loại bỏ tiến trình đã hoàn thành khỏi hàng đợi sẵn sàng
                            readyQueue.Remove(currentProcess);
                        }
                        else
                        {
                            // Di chuyển tiến trình tới cuối hàng đợi chỉ khi nó còn thời gian thực hiện
                            readyQueue.RemoveAt(0);
                            readyQueue.Add(currentProcess);
                        }

                        // Cập nhật thời gian hiện tại
                        currentTime += executionTime;
                    }
                    else
                    {
                        // Nếu tiến trình không còn thời gian thực hiện, loại bỏ nó khỏi hàng đợi
                        readyQueue.RemoveAt(0);
                    }
                }
            }
            return ganttBars;
        }


        private List<GanttBar> MergeSimilarGanttBars(List<GanttBar> ganttBars)
        {
            List<GanttBar> mergedGanttBars = new List<GanttBar>();

            // Duyệt qua danh sách các GanttBar
            for (int i = 0; i < ganttBars.Count; i++)
            {
                GanttBar currentBar = ganttBars[i];

                // Kiểm tra xem GanttBar hiện tại có giống với GanttBar tiếp theo không
                if (i < ganttBars.Count - 1 && currentBar.ProcessName == ganttBars[i + 1].ProcessName)
                {
                    int startIndex = i;
                    int endIndex = i;

                    // Tìm chỉ số cuối cùng của loạt GanttBar giống nhau
                    while (endIndex < ganttBars.Count - 1 && ganttBars[endIndex].ProcessName == ganttBars[endIndex + 1].ProcessName)
                    {
                        endIndex++;
                    }

                    // Tính toán thời gian bắt đầu và thời gian kết thúc mới cho GanttBar gộp
                    int newStartTime = ganttBars[startIndex].StartTime;
                    int newEndTime = ganttBars[endIndex].EndTime;

                    // Tạo GanttBar mới với thời gian bắt đầu và kết thúc được tính toán
                    GanttBar mergedBar = new GanttBar(currentBar.ProcessName, newStartTime, currentBar.ArrivalTime, currentBar.BurstTime, newEndTime);

                    // Thêm GanttBar mới vào danh sách GanttBar gộp
                    mergedGanttBars.Add(mergedBar);

                    // Bỏ qua các GanttBar đã được gộp
                    i = endIndex;
                }
                else
                {
                    // Nếu không có GanttBar tiếp theo hoặc GanttBar tiếp theo không giống, thêm GanttBar hiện tại vào danh sách GanttBar gộp
                    mergedGanttBars.Add(currentBar);
                }
            }

            return mergedGanttBars;
        }

        private void DrawGanttChart(List<GanttBar> ganttBars)
        {
            // Xóa bất kỳ vẽ nào trước đó trên Panel
            ganttChartPanel.Refresh();

            // Tính tổng thời gian của toàn bộ chương trình
            int totalTime = 1;
            foreach(GanttBar ganttBar in ganttBars)
            {
                if (ganttBar.EndTime > totalTime)
                {
                    totalTime = ganttBar.EndTime;
                }
            }

            lb_TmeTotal.Text = "Completed Time: " + totalTime.ToString();

            // Tính tỷ lệ giữa tổng thời gian và 750 pixel
            float scaleFactor = 600 / totalTime;

            // Tạo đối tượng Graphics từ Panel
            Graphics g = ganttChartPanel.CreateGraphics();

            // Thiết lập màu và kích thước của các thanh GanttBar
            Brush barBrush = Brushes.LightBlue;
            Pen barPen = Pens.Black;
            int barHeight = 30; // Chiều cao của thanh GanttBar

            // Vẽ các thanh GanttBar
            foreach (GanttBar ganttBar in ganttBars)
            {
                // Tính toán tỷ lệ thời gian và kích thước của thanh GanttBar
                int startX = (int)(ganttBar.StartTime * scaleFactor);
                int width = (int)((ganttBar.EndTime - ganttBar.StartTime) * scaleFactor);

                int y = 10; // Vị trí dọc của thanh GanttBar

                // Vẽ thanh GanttBar
                Rectangle rect = new Rectangle(startX, y, width, barHeight);
                g.FillRectangle(barBrush, rect);
                g.DrawRectangle(barPen, rect);
                // Hiển thị tên tiến trình
                Font font = new Font("Arial", 10, FontStyle.Regular);
                string text = ganttBar.ProcessName;
                g.DrawString(text, font, Brushes.Black, startX + width / 2 - 15, y + 8);
            }

        }
        
        private void DrawTimeChart(List<GanttBar> ganttBars)
        {
            // Tính tổng thời gian của toàn bộ chương trình
            int totalTime = 1;
            foreach (GanttBar ganttBar in ganttBars)
            {
                if (ganttBar.EndTime > totalTime)
                {
                    totalTime = ganttBar.EndTime;
                }
            }

            // Tính tỷ lệ giữa tổng thời gian và 750 pixel
            float scaleFactor = 600 / totalTime;

            // Tạo đối tượng Graphics từ Panel
            Graphics g = ganttChartPanel.CreateGraphics();

            // Thiết lập màu và kích thước của các thanh GanttBar
            Brush barBrush = Brushes.LightGray;
            Pen barPen = Pens.Black;
            int barHeight = 30; // Chiều cao của thanh GanttBar

            // Vẽ các thanh GanttBar
            foreach (GanttBar ganttBar in ganttBars)
            {
                // Tính toán tỷ lệ thời gian và kích thước của thanh GanttBar
                int startX = (int)(ganttBar.StartTime * scaleFactor);
                int width = (int)((ganttBar.EndTime - ganttBar.StartTime) * scaleFactor);


                int y = 50; // Vị trí dọc của thanh GanttBar

                // Vẽ thanh GanttBar
                Rectangle rect = new Rectangle(startX, y, width, barHeight);
                g.FillRectangle(barBrush, rect);
                g.DrawRectangle(barPen, rect);

                // Hiển thị tên tiến trình
                string textStart = ganttBar.StartTime.ToString();
                string textEnd = ganttBar.EndTime.ToString();

                // Tính toán vị trí bắt đầu của văn bản để căn lề trái
                //float textY = startX + 5;
                Font font = new Font("Arial", 8, FontStyle.Regular);
                // Vẽ văn bản với căn lề trái
                //g.DrawString(textStart, font, Brushes.Black, textY, y + 8);

                // Tính toán vị trí bắt đầu của văn bản để căn lề phải
                float textWidth = g.MeasureString(textEnd, Font).Width;
                float textX = startX + width - textWidth - 5;
                // Vẽ văn bản với căn lề phải
                g.DrawString(textEnd, font, Brushes.Black, textX, y + 8);

            }

        }

        private void DisplayProcessTable(List<GanttBar> ganttBars)
        {
            // Xóa nội dung cũ trong TextBox
            tbx_Result.Clear();
            List<GanttBar> endGanttBars = new List<GanttBar>();

            // Thêm tiêu đề cho bảng
            tbx_Result.AppendText("Process Table\n");
            tbx_Result.AppendText(Environment.NewLine);
            tbx_Result.AppendText("Process Name\tWaiting Time\n");
            int totalWaitingTime = 0;

            // Tính toán thông tin và hiển thị từng tiến trình
            foreach (GanttBar ganttBar in ganttBars)
            {
                bool found = false;

                // Duyệt qua từng GanttBar trong danh sách endGanttBars
                foreach (GanttBar endGanttBar in endGanttBars)
                {
                    // Nếu tên tiến trình đã tồn tại trong danh sách
                    if (endGanttBar.ProcessName == ganttBar.ProcessName)
                    {
                        // Cộng dồn Burst và cập nhật thông tin
                        endGanttBar.BurstTime += ganttBar.BurstTime;
                        endGanttBar.EndTime = ganttBar.EndTime;
                        found = true;
                        break;
                    }
                }

                // Nếu không tìm thấy tiến trình trong danh sách, thêm mới
                if (!found)
                {
                    endGanttBars.Add(new GanttBar(ganttBar.ProcessName, ganttBar.StartTime, ganttBar.ArrivalTime, ganttBar.BurstTime, ganttBar.EndTime));
                }
            }

            // Tính tổng thời gian chờ và hiển thị thông tin từng tiến trình
            foreach (GanttBar endGanttBar in endGanttBars)
            {
                int waitingTime = endGanttBar.EndTime - endGanttBar.ArrivalTime - endGanttBar.BurstTime;
                totalWaitingTime += waitingTime;
                tbx_Result.AppendText(Environment.NewLine);
                tbx_Result.AppendText(endGanttBar.ProcessName + "\t\t" + waitingTime);

            }
            // Hiển thị tổng thời gian chờ trung bình
            tbx_Result.AppendText(Environment.NewLine);
            tbx_Result.AppendText("Average Waiting Time: " + (float)totalWaitingTime/endGanttBars.Count);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            frm_FCFS_Load(sender, e);
        }
    }
}
