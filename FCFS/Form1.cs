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
        }

        public class Process
        {
            public string Name { get; set; }
            public int ArrivalTime { get; set; }
            public int BurstTime { get; set; }

            public Process(string name, int arrivalTime, int burstTime)
            {
                Name = name;
                ArrivalTime = arrivalTime;
                BurstTime = burstTime;
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
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            ganttChartPanel.Refresh();
            tbx_Result.Clear();
            lb_TmeTotal.Text = "Completed Time: ";
        }

        private void fCFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_Algorithms.Text = "FCFS";
            check = true;
            cbx_quantum.Visible = false;
            panel2.Visible = false;
            frm_FCFS_Load(sender, e);
        }

        private void sJFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_Algorithms.Text = "SJF";
            check = true;
            cbx_quantum.Visible = true;
            panel2.Visible = true;
            frm_FCFS_Load(sender, e);

        }

        private int processCount = 0; // Biến đếm số tiến trình đã được thêm, bắt đầu từ 1


        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                string name = "P" + processCount;
                Process newProcess = new Process(name, 0, 0);
                AddProcessToDataGridView(newProcess);
                SortDataGridViewByName();
                processCount = dataGridView.Rows.Count - 1;
            }
            else
            {
                MessageBox.Show("Please choose the algorithms", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProcessToDataGridView(Process process)
        {
            // Thêm dòng mới vào DataGridView với thông tin của tiến trình vừa tạo
            dataGridView.Rows.Add(process.Name, process.ArrivalTime, process.BurstTime);
        }

        private void SortDataGridViewByName()
        {
            // Sắp xếp lại các dòng trong DataGridView theo tên của các tiến trình
            dataGridView.Sort(dataGridView.Columns[0], ListSortDirection.Ascending);
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView.SelectedRows[0].Index;
                RemoveProcessFromDataGridView(selectedIndex);
                processCount = selectedIndex; // Cập nhật lại biến đếm số tiến trình
            }
        }

        private void RemoveProcessFromDataGridView(int rowIndex)
        {
            dataGridView.Rows.RemoveAt(rowIndex);
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                List<Process> processes = ExtractProcessesFromDataGridView();
                List<GanttBar> ganttBars = new List<GanttBar>();

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
                }
                DrawGanttChart(ganttBars);
                DrawTimeChart(ganttBars);
                DisplayProcessTable(ganttBars);
            }
            else
            {
                MessageBox.Show("Please choose the algorithms", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Process> ExtractProcessesFromDataGridView()
        {
            List<Process> processes = new List<Process>();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                string name = row.Cells["process"].Value.ToString();
                int startTime = int.Parse(row.Cells["arrivalTime"].Value.ToString());
                int burstTime = int.Parse(row.Cells["burstTime"].Value.ToString());

                processes.Add(new Process(name, startTime, burstTime));
            }

            return processes;
        }

        private List<GanttBar> FCFS(List<Process> processes)
        {
            List<GanttBar> ganttBars = new List<GanttBar>();

            int currentTime = 0;

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

            int currentTime = 0;
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
                    // Nếu không có tiến trình nào sẵn sàng thì tăng thời gian lên đến khi có tiến trình mới đến
                    int nextArrivalTime = processes.Where(p => p.ArrivalTime > currentTime).Min(p => p.ArrivalTime);
                    currentTime = nextArrivalTime;
                }
            }

            return ganttBars;
        }

        private List<GanttBar> SJF_preemptive(List<Process> processes)
        {
            List<GanttBar> ganttBars = new List<GanttBar>();
            List<Process> readyQueue = new List<Process>();
            int currentTime = 0;

            while (true)
            {
                // Lấy các tiến trình đã đến và chưa hoàn thành
                var arrivedProcesses = processes.Where(p => p.ArrivalTime <= currentTime && !readyQueue.Contains(p)).ToList();

                // Thêm các tiến trình đã đến vào hàng đợi sẵn sàng
                readyQueue.AddRange(arrivedProcesses);

                // Kiểm tra xem hàng đợi sẵn sàng có trống không
                if (readyQueue.Count == 0)
                {
                    // Nếu hàng đợi sẵn sàng trống và không còn tiến trình nào đến, thoát khỏi vòng lặp
                    if (arrivedProcesses.Count == 0 && ganttBars.Count == processes.Count)
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

            return ganttBars;
        }



        private void DrawGanttChart(List<GanttBar> ganttBars)
        {
            // Xóa bất kỳ vẽ nào trước đó trên Panel
            ganttChartPanel.Refresh();

            // Tính tổng thời gian của toàn bộ chương trình
            int totalTime = ganttBars.Max(item => item.EndTime);
            lb_TmeTotal.Text = "Completed Time: " + totalTime.ToString();

            // Tính tỷ lệ giữa tổng thời gian và 750 pixel
            float scaleFactor = 450 / totalTime;

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
                string text = ganttBar.ProcessName;
                g.DrawString(text, Font, Brushes.Black, startX + width / 2 - 15, y + 8);
            }

        }
        
        private void DrawTimeChart(List<GanttBar> ganttBars)
        {
            // Tính tổng thời gian của toàn bộ chương trình
            int totalTime = ganttBars.Max(item => item.EndTime);

            // Tính tỷ lệ giữa tổng thời gian và 750 pixel
            float scaleFactor = 450 / totalTime;

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
                string text = ganttBar.EndTime.ToString();
                g.DrawString(text, Font, Brushes.Black, startX + width / 2 - 15, y + 8);
            }

        }

        private void DisplayProcessTable(List<GanttBar> ganttBars)
        {
            // Xóa nội dung cũ trong TextBox
            tbx_Result.Clear();

            // Thêm tiêu đề cho bảng
            tbx_Result.AppendText("Process Table\n");
            tbx_Result.AppendText(Environment.NewLine);
            tbx_Result.AppendText("Process Name\tWaiting Time\tTurnaround Time\n");
            int totalWaitingTime = 0;
            // Tính toán thông tin và hiển thị từng tiến trình
            foreach (GanttBar ganttBar in ganttBars)
            {
                int turnaroundTime = ganttBar.EndTime - ganttBar.ArrivalTime;
                int waitingTime = ganttBar.StartTime - ganttBar.ArrivalTime;
                totalWaitingTime += waitingTime;
                tbx_Result.AppendText(Environment.NewLine);
                // Thêm thông tin của tiến trình vào TextBox với các cột được căn lề
                tbx_Result.AppendText($"{ganttBar.ProcessName}\t\t{waitingTime}\t\t{turnaroundTime}\n");
            }
            tbx_Result.AppendText(Environment.NewLine);
            tbx_Result.AppendText("Average Waiting Time: " + (float)totalWaitingTime/ganttBars.Count);
        }   

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            frm_FCFS_Load(sender, e);
        }
    }
}
