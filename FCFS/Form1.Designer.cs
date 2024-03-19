namespace FCFS
{
    partial class frm_FCFS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuAlgorithms = new System.Windows.Forms.MenuStrip();
            this.cPUSchedulingAlgorithmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fCFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sJFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priorityWithRBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiveFeadbackQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Run = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtn_Preemptive = new System.Windows.Forms.RadioButton();
            this.rbtn_NonPreemptive = new System.Windows.Forms.RadioButton();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.ganttChartPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_TmeTotal = new System.Windows.Forms.Label();
            this.tbx_Result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lb_Algorithms = new System.Windows.Forms.Label();
            this.lb_Quantum = new System.Windows.Forms.Label();
            this.tbx_quantum = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.processName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processBurstTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_AverageWaitingTime = new System.Windows.Forms.Label();
            this.lb_Multi = new System.Windows.Forms.Label();
            this.lb_Num = new System.Windows.Forms.Label();
            this.cbx_Number = new System.Windows.Forms.ComboBox();
            this.lb_Queue1 = new System.Windows.Forms.Label();
            this.lb_Queue2 = new System.Windows.Forms.Label();
            this.lb_Queue3 = new System.Windows.Forms.Label();
            this.txt_Quantum1 = new System.Windows.Forms.TextBox();
            this.txt_Quantum2 = new System.Windows.Forms.TextBox();
            this.lb_RB1 = new System.Windows.Forms.Label();
            this.lb_RB2 = new System.Windows.Forms.Label();
            this.lb_FCFS = new System.Windows.Forms.Label();
            this.menuAlgorithms.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // menuAlgorithms
            // 
            this.menuAlgorithms.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuAlgorithms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuAlgorithms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cPUSchedulingAlgorithmsToolStripMenuItem,
            this.chooToolStripMenuItem});
            this.menuAlgorithms.Location = new System.Drawing.Point(0, 0);
            this.menuAlgorithms.Name = "menuAlgorithms";
            this.menuAlgorithms.Size = new System.Drawing.Size(1182, 28);
            this.menuAlgorithms.TabIndex = 0;
            this.menuAlgorithms.Text = "menuStrip";
            // 
            // cPUSchedulingAlgorithmsToolStripMenuItem
            // 
            this.cPUSchedulingAlgorithmsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fCFSToolStripMenuItem,
            this.sJFToolStripMenuItem,
            this.rBToolStripMenuItem,
            this.priorityToolStripMenuItem,
            this.priorityWithRBToolStripMenuItem,
            this.multiveFeadbackQueueToolStripMenuItem});
            this.cPUSchedulingAlgorithmsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cPUSchedulingAlgorithmsToolStripMenuItem.Name = "cPUSchedulingAlgorithmsToolStripMenuItem";
            this.cPUSchedulingAlgorithmsToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.cPUSchedulingAlgorithmsToolStripMenuItem.Text = "CPU Scheduling Algorithms";
            // 
            // fCFSToolStripMenuItem
            // 
            this.fCFSToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.fCFSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.fCFSToolStripMenuItem.Name = "fCFSToolStripMenuItem";
            this.fCFSToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.fCFSToolStripMenuItem.Text = "FCFS";
            this.fCFSToolStripMenuItem.Click += new System.EventHandler(this.fCFSToolStripMenuItem_Click);
            // 
            // sJFToolStripMenuItem
            // 
            this.sJFToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.sJFToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.sJFToolStripMenuItem.Name = "sJFToolStripMenuItem";
            this.sJFToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.sJFToolStripMenuItem.Text = "SJF";
            this.sJFToolStripMenuItem.Click += new System.EventHandler(this.sJFToolStripMenuItem_Click);
            // 
            // rBToolStripMenuItem
            // 
            this.rBToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.rBToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rBToolStripMenuItem.Name = "rBToolStripMenuItem";
            this.rBToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.rBToolStripMenuItem.Text = "RB";
            this.rBToolStripMenuItem.Click += new System.EventHandler(this.rBToolStripMenuItem_Click);
            // 
            // priorityToolStripMenuItem
            // 
            this.priorityToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.priorityToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.priorityToolStripMenuItem.Name = "priorityToolStripMenuItem";
            this.priorityToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.priorityToolStripMenuItem.Text = "Priority";
            this.priorityToolStripMenuItem.Click += new System.EventHandler(this.priorityToolStripMenuItem_Click);
            // 
            // priorityWithRBToolStripMenuItem
            // 
            this.priorityWithRBToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.priorityWithRBToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.priorityWithRBToolStripMenuItem.Name = "priorityWithRBToolStripMenuItem";
            this.priorityWithRBToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.priorityWithRBToolStripMenuItem.Text = "Priority With RB";
            this.priorityWithRBToolStripMenuItem.Click += new System.EventHandler(this.priorityWithRBToolStripMenuItem_Click);
            // 
            // multiveFeadbackQueueToolStripMenuItem
            // 
            this.multiveFeadbackQueueToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.multiveFeadbackQueueToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.multiveFeadbackQueueToolStripMenuItem.Name = "multiveFeadbackQueueToolStripMenuItem";
            this.multiveFeadbackQueueToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.multiveFeadbackQueueToolStripMenuItem.Text = "Multive Feadback Queue";
            this.multiveFeadbackQueueToolStripMenuItem.Click += new System.EventHandler(this.multiveFeadbackQueueToolStripMenuItem_Click);
            // 
            // chooToolStripMenuItem
            // 
            this.chooToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.chooToolStripMenuItem.Name = "chooToolStripMenuItem";
            this.chooToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.chooToolStripMenuItem.Text = "<------ Choose an algorithms to run ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPU SCHEDULING ALGORITHMS";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(844, 100);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 50);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(844, 167);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 50);
            this.btn_Remove.TabIndex = 4;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(844, 280);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(75, 50);
            this.btn_Run.TabIndex = 5;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtn_Preemptive);
            this.panel2.Controls.Add(this.rbtn_NonPreemptive);
            this.panel2.Location = new System.Drawing.Point(91, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 65);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // rbtn_Preemptive
            // 
            this.rbtn_Preemptive.AutoSize = true;
            this.rbtn_Preemptive.Location = new System.Drawing.Point(17, 38);
            this.rbtn_Preemptive.Name = "rbtn_Preemptive";
            this.rbtn_Preemptive.Size = new System.Drawing.Size(97, 20);
            this.rbtn_Preemptive.TabIndex = 1;
            this.rbtn_Preemptive.TabStop = true;
            this.rbtn_Preemptive.Text = "Preemptive";
            this.rbtn_Preemptive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_Preemptive.UseVisualStyleBackColor = true;
            // 
            // rbtn_NonPreemptive
            // 
            this.rbtn_NonPreemptive.AutoSize = true;
            this.rbtn_NonPreemptive.Location = new System.Drawing.Point(17, 9);
            this.rbtn_NonPreemptive.Name = "rbtn_NonPreemptive";
            this.rbtn_NonPreemptive.Size = new System.Drawing.Size(125, 20);
            this.rbtn_NonPreemptive.TabIndex = 0;
            this.rbtn_NonPreemptive.TabStop = true;
            this.rbtn_NonPreemptive.Text = "Non Preemptive";
            this.rbtn_NonPreemptive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_NonPreemptive.UseVisualStyleBackColor = true;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Red;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Reset.Location = new System.Drawing.Point(943, 280);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(100, 50);
            this.btn_Reset.TabIndex = 9;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // ganttChartPanel
            // 
            this.ganttChartPanel.BackColor = System.Drawing.Color.White;
            this.ganttChartPanel.Location = new System.Drawing.Point(91, 369);
            this.ganttChartPanel.Name = "ganttChartPanel";
            this.ganttChartPanel.Size = new System.Drawing.Size(1000, 100);
            this.ganttChartPanel.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Gantt Chart";
            // 
            // lb_TmeTotal
            // 
            this.lb_TmeTotal.AutoSize = true;
            this.lb_TmeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TmeTotal.Location = new System.Drawing.Point(88, 472);
            this.lb_TmeTotal.Name = "lb_TmeTotal";
            this.lb_TmeTotal.Size = new System.Drawing.Size(98, 18);
            this.lb_TmeTotal.TabIndex = 12;
            this.lb_TmeTotal.Text = "Total Time: ";
            // 
            // tbx_Result
            // 
            this.tbx_Result.BackColor = System.Drawing.Color.White;
            this.tbx_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Result.Location = new System.Drawing.Point(91, 525);
            this.tbx_Result.Multiline = true;
            this.tbx_Result.Name = "tbx_Result";
            this.tbx_Result.ReadOnly = true;
            this.tbx_Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_Result.Size = new System.Drawing.Size(440, 175);
            this.tbx_Result.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Result";
            // 
            // lb_Algorithms
            // 
            this.lb_Algorithms.AutoSize = true;
            this.lb_Algorithms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Algorithms.Location = new System.Drawing.Point(86, 100);
            this.lb_Algorithms.Name = "lb_Algorithms";
            this.lb_Algorithms.Size = new System.Drawing.Size(114, 25);
            this.lb_Algorithms.TabIndex = 0;
            this.lb_Algorithms.Text = "Algorithms";
            this.lb_Algorithms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Quantum
            // 
            this.lb_Quantum.AutoSize = true;
            this.lb_Quantum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Quantum.Location = new System.Drawing.Point(93, 238);
            this.lb_Quantum.Name = "lb_Quantum";
            this.lb_Quantum.Size = new System.Drawing.Size(84, 20);
            this.lb_Quantum.TabIndex = 15;
            this.lb_Quantum.Text = "Quantum";
            this.lb_Quantum.Visible = false;
            // 
            // tbx_quantum
            // 
            this.tbx_quantum.Location = new System.Drawing.Point(230, 238);
            this.tbx_quantum.Name = "tbx_quantum";
            this.tbx_quantum.Size = new System.Drawing.Size(66, 22);
            this.tbx_quantum.TabIndex = 16;
            this.tbx_quantum.Visible = false;
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToOrderColumns = true;
            this.data.AllowUserToResizeColumns = false;
            this.data.AllowUserToResizeRows = false;
            this.data.BackgroundColor = System.Drawing.Color.White;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.processName,
            this.processArrivalTime,
            this.processBurstTime,
            this.processPriority});
            this.data.Location = new System.Drawing.Point(418, 100);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 51;
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(420, 230);
            this.data.TabIndex = 17;
            // 
            // processName
            // 
            this.processName.Frozen = true;
            this.processName.HeaderText = "Name";
            this.processName.MinimumWidth = 6;
            this.processName.Name = "processName";
            this.processName.Width = 125;
            // 
            // processArrivalTime
            // 
            this.processArrivalTime.HeaderText = "Arrival Time";
            this.processArrivalTime.MinimumWidth = 6;
            this.processArrivalTime.Name = "processArrivalTime";
            this.processArrivalTime.Width = 125;
            // 
            // processBurstTime
            // 
            this.processBurstTime.HeaderText = "Burst Time";
            this.processBurstTime.MinimumWidth = 6;
            this.processBurstTime.Name = "processBurstTime";
            this.processBurstTime.Width = 125;
            // 
            // processPriority
            // 
            this.processPriority.HeaderText = "Priority";
            this.processPriority.MinimumWidth = 6;
            this.processPriority.Name = "processPriority";
            this.processPriority.Width = 125;
            // 
            // lb_AverageWaitingTime
            // 
            this.lb_AverageWaitingTime.AutoSize = true;
            this.lb_AverageWaitingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AverageWaitingTime.Location = new System.Drawing.Point(87, 716);
            this.lb_AverageWaitingTime.Name = "lb_AverageWaitingTime";
            this.lb_AverageWaitingTime.Size = new System.Drawing.Size(199, 20);
            this.lb_AverageWaitingTime.TabIndex = 22;
            this.lb_AverageWaitingTime.Text = "Average Waiting Time:";
            // 
            // lb_Multi
            // 
            this.lb_Multi.AutoSize = true;
            this.lb_Multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Multi.Location = new System.Drawing.Point(572, 502);
            this.lb_Multi.Name = "lb_Multi";
            this.lb_Multi.Size = new System.Drawing.Size(211, 20);
            this.lb_Multi.TabIndex = 23;
            this.lb_Multi.Text = "Multive Feadbacl Queue";
            this.lb_Multi.Visible = false;
            // 
            // lb_Num
            // 
            this.lb_Num.AutoSize = true;
            this.lb_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Num.Location = new System.Drawing.Point(572, 528);
            this.lb_Num.Name = "lb_Num";
            this.lb_Num.Size = new System.Drawing.Size(162, 20);
            this.lb_Num.TabIndex = 24;
            this.lb_Num.Text = "Number of Queue:";
            this.lb_Num.Visible = false;
            // 
            // cbx_Number
            // 
            this.cbx_Number.ForeColor = System.Drawing.Color.DarkGray;
            this.cbx_Number.FormattingEnabled = true;
            this.cbx_Number.Location = new System.Drawing.Point(781, 528);
            this.cbx_Number.Name = "cbx_Number";
            this.cbx_Number.Size = new System.Drawing.Size(103, 24);
            this.cbx_Number.TabIndex = 25;
            this.cbx_Number.Text = "to 1 from 3";
            this.cbx_Number.Visible = false;
            // 
            // lb_Queue1
            // 
            this.lb_Queue1.AutoSize = true;
            this.lb_Queue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Queue1.Location = new System.Drawing.Point(572, 575);
            this.lb_Queue1.Name = "lb_Queue1";
            this.lb_Queue1.Size = new System.Drawing.Size(85, 20);
            this.lb_Queue1.TabIndex = 26;
            this.lb_Queue1.Text = "Queue 1:";
            this.lb_Queue1.Visible = false;
            // 
            // lb_Queue2
            // 
            this.lb_Queue2.AutoSize = true;
            this.lb_Queue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Queue2.Location = new System.Drawing.Point(572, 614);
            this.lb_Queue2.Name = "lb_Queue2";
            this.lb_Queue2.Size = new System.Drawing.Size(85, 20);
            this.lb_Queue2.TabIndex = 27;
            this.lb_Queue2.Text = "Queue 2:";
            this.lb_Queue2.Visible = false;
            // 
            // lb_Queue3
            // 
            this.lb_Queue3.AutoSize = true;
            this.lb_Queue3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Queue3.Location = new System.Drawing.Point(572, 653);
            this.lb_Queue3.Name = "lb_Queue3";
            this.lb_Queue3.Size = new System.Drawing.Size(85, 20);
            this.lb_Queue3.TabIndex = 28;
            this.lb_Queue3.Text = "Queue 3:";
            this.lb_Queue3.Visible = false;
            // 
            // txt_Quantum1
            // 
            this.txt_Quantum1.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_Quantum1.Location = new System.Drawing.Point(1001, 575);
            this.txt_Quantum1.Name = "txt_Quantum1";
            this.txt_Quantum1.Size = new System.Drawing.Size(79, 22);
            this.txt_Quantum1.TabIndex = 36;
            this.txt_Quantum1.Text = "Quantum";
            this.txt_Quantum1.Visible = false;
            // 
            // txt_Quantum2
            // 
            this.txt_Quantum2.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_Quantum2.Location = new System.Drawing.Point(1001, 614);
            this.txt_Quantum2.Name = "txt_Quantum2";
            this.txt_Quantum2.Size = new System.Drawing.Size(79, 22);
            this.txt_Quantum2.TabIndex = 37;
            this.txt_Quantum2.Text = "Quantum";
            this.txt_Quantum2.Visible = false;
            // 
            // lb_RB1
            // 
            this.lb_RB1.AutoSize = true;
            this.lb_RB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RB1.Location = new System.Drawing.Point(707, 575);
            this.lb_RB1.Name = "lb_RB1";
            this.lb_RB1.Size = new System.Drawing.Size(235, 20);
            this.lb_RB1.TabIndex = 39;
            this.lb_RB1.Text = "Round Robin với quantum: ";
            this.lb_RB1.Visible = false;
            // 
            // lb_RB2
            // 
            this.lb_RB2.AutoSize = true;
            this.lb_RB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RB2.Location = new System.Drawing.Point(707, 614);
            this.lb_RB2.Name = "lb_RB2";
            this.lb_RB2.Size = new System.Drawing.Size(235, 20);
            this.lb_RB2.TabIndex = 40;
            this.lb_RB2.Text = "Round Robin với quantum: ";
            this.lb_RB2.Visible = false;
            // 
            // lb_FCFS
            // 
            this.lb_FCFS.AutoSize = true;
            this.lb_FCFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FCFS.Location = new System.Drawing.Point(707, 653);
            this.lb_FCFS.Name = "lb_FCFS";
            this.lb_FCFS.Size = new System.Drawing.Size(56, 20);
            this.lb_FCFS.TabIndex = 41;
            this.lb_FCFS.Text = "FCFS";
            this.lb_FCFS.Visible = false;
            // 
            // frm_FCFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1182, 803);
            this.Controls.Add(this.lb_FCFS);
            this.Controls.Add(this.lb_RB2);
            this.Controls.Add(this.lb_RB1);
            this.Controls.Add(this.txt_Quantum2);
            this.Controls.Add(this.txt_Quantum1);
            this.Controls.Add(this.lb_Queue3);
            this.Controls.Add(this.lb_Queue2);
            this.Controls.Add(this.lb_Queue1);
            this.Controls.Add(this.cbx_Number);
            this.Controls.Add(this.lb_Num);
            this.Controls.Add(this.lb_Multi);
            this.Controls.Add(this.lb_AverageWaitingTime);
            this.Controls.Add(this.data);
            this.Controls.Add(this.tbx_quantum);
            this.Controls.Add(this.lb_Quantum);
            this.Controls.Add(this.lb_Algorithms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_Result);
            this.Controls.Add(this.lb_TmeTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ganttChartPanel);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuAlgorithms);
            this.MainMenuStrip = this.menuAlgorithms;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 1000);
            this.MinimizeBox = false;
            this.Name = "frm_FCFS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU Scheduling Altgorthms";
            this.Load += new System.EventHandler(this.frm_FCFS_Load);
            this.menuAlgorithms.ResumeLayout(false);
            this.menuAlgorithms.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAlgorithms;
        private System.Windows.Forms.ToolStripMenuItem cPUSchedulingAlgorithmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fCFSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sJFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtn_Preemptive;
        private System.Windows.Forms.RadioButton rbtn_NonPreemptive;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Panel ganttChartPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_TmeTotal;
        private System.Windows.Forms.TextBox tbx_Result;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lb_Algorithms;
        private System.Windows.Forms.ToolStripMenuItem rBToolStripMenuItem;
        private System.Windows.Forms.Label lb_Quantum;
        private System.Windows.Forms.TextBox tbx_quantum;
        private System.Windows.Forms.ToolStripMenuItem priorityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priorityWithRBToolStripMenuItem;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.DataGridViewTextBoxColumn processName;
        private System.Windows.Forms.DataGridViewTextBoxColumn processArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn processBurstTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn processPriority;
        private System.Windows.Forms.Label lb_AverageWaitingTime;
        private System.Windows.Forms.Label lb_Multi;
        private System.Windows.Forms.Label lb_Num;
        private System.Windows.Forms.ComboBox cbx_Number;
        private System.Windows.Forms.Label lb_Queue1;
        private System.Windows.Forms.Label lb_Queue2;
        private System.Windows.Forms.Label lb_Queue3;
        private System.Windows.Forms.TextBox txt_Quantum1;
        private System.Windows.Forms.TextBox txt_Quantum2;
        private System.Windows.Forms.ToolStripMenuItem multiveFeadbackQueueToolStripMenuItem;
        private System.Windows.Forms.Label lb_RB1;
        private System.Windows.Forms.Label lb_RB2;
        private System.Windows.Forms.Label lb_FCFS;
    }
}

