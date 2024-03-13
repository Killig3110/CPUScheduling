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
            this.chooToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
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
            this.process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.burstTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlgorithms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAlgorithms
            // 
            this.menuAlgorithms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuAlgorithms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cPUSchedulingAlgorithmsToolStripMenuItem,
            this.chooToolStripMenuItem});
            this.menuAlgorithms.Location = new System.Drawing.Point(0, 0);
            this.menuAlgorithms.Name = "menuAlgorithms";
            this.menuAlgorithms.Size = new System.Drawing.Size(899, 28);
            this.menuAlgorithms.TabIndex = 0;
            this.menuAlgorithms.Text = "menuStrip";
            // 
            // cPUSchedulingAlgorithmsToolStripMenuItem
            // 
            this.cPUSchedulingAlgorithmsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fCFSToolStripMenuItem,
            this.sJFToolStripMenuItem,
            this.rBToolStripMenuItem,
            this.priorityToolStripMenuItem});
            this.cPUSchedulingAlgorithmsToolStripMenuItem.Name = "cPUSchedulingAlgorithmsToolStripMenuItem";
            this.cPUSchedulingAlgorithmsToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.cPUSchedulingAlgorithmsToolStripMenuItem.Text = "CPU Scheduling Algorithms";
            // 
            // fCFSToolStripMenuItem
            // 
            this.fCFSToolStripMenuItem.Name = "fCFSToolStripMenuItem";
            this.fCFSToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.fCFSToolStripMenuItem.Text = "FCFS";
            this.fCFSToolStripMenuItem.Click += new System.EventHandler(this.fCFSToolStripMenuItem_Click);
            // 
            // sJFToolStripMenuItem
            // 
            this.sJFToolStripMenuItem.Name = "sJFToolStripMenuItem";
            this.sJFToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.sJFToolStripMenuItem.Text = "SJF";
            this.sJFToolStripMenuItem.Click += new System.EventHandler(this.sJFToolStripMenuItem_Click);
            // 
            // rBToolStripMenuItem
            // 
            this.rBToolStripMenuItem.Name = "rBToolStripMenuItem";
            this.rBToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.rBToolStripMenuItem.Text = "RB";
            this.rBToolStripMenuItem.Click += new System.EventHandler(this.rBToolStripMenuItem_Click);
            // 
            // chooToolStripMenuItem
            // 
            this.chooToolStripMenuItem.Name = "chooToolStripMenuItem";
            this.chooToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.chooToolStripMenuItem.Text = "<------ Choose an algorithms to run ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPU SCHEDULING ALGORITHMS";
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.process,
            this.arrivalTime,
            this.burstTime,
            this.priority});
            this.dataGridView.Enabled = false;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView.Location = new System.Drawing.Point(276, 100);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(420, 230);
            this.dataGridView.TabIndex = 2;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(705, 100);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 50);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(705, 167);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 50);
            this.btn_Remove.TabIndex = 4;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(705, 280);
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
            this.panel2.Location = new System.Drawing.Point(100, 167);
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
            this.btn_Reset.Location = new System.Drawing.Point(170, 280);
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
            this.ganttChartPanel.Location = new System.Drawing.Point(99, 370);
            this.ganttChartPanel.Name = "ganttChartPanel";
            this.ganttChartPanel.Size = new System.Drawing.Size(700, 100);
            this.ganttChartPanel.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Gantt Chart";
            // 
            // lb_TmeTotal
            // 
            this.lb_TmeTotal.AutoSize = true;
            this.lb_TmeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TmeTotal.Location = new System.Drawing.Point(96, 472);
            this.lb_TmeTotal.Name = "lb_TmeTotal";
            this.lb_TmeTotal.Size = new System.Drawing.Size(98, 18);
            this.lb_TmeTotal.TabIndex = 12;
            this.lb_TmeTotal.Text = "Total Time: ";
            // 
            // tbx_Result
            // 
            this.tbx_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Result.Location = new System.Drawing.Point(99, 534);
            this.tbx_Result.Multiline = true;
            this.tbx_Result.Name = "tbx_Result";
            this.tbx_Result.ReadOnly = true;
            this.tbx_Result.Size = new System.Drawing.Size(700, 150);
            this.tbx_Result.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Result";
            // 
            // lb_Algorithms
            // 
            this.lb_Algorithms.AutoSize = true;
            this.lb_Algorithms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Algorithms.Location = new System.Drawing.Point(101, 125);
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
            this.lb_Quantum.Location = new System.Drawing.Point(102, 238);
            this.lb_Quantum.Name = "lb_Quantum";
            this.lb_Quantum.Size = new System.Drawing.Size(84, 20);
            this.lb_Quantum.TabIndex = 15;
            this.lb_Quantum.Text = "Quantum";
            this.lb_Quantum.Visible = false;
            // 
            // tbx_quantum
            // 
            this.tbx_quantum.Location = new System.Drawing.Point(204, 238);
            this.tbx_quantum.Name = "tbx_quantum";
            this.tbx_quantum.Size = new System.Drawing.Size(66, 22);
            this.tbx_quantum.TabIndex = 16;
            // 
            // process
            // 
            this.process.Frozen = true;
            this.process.HeaderText = "Process";
            this.process.MinimumWidth = 6;
            this.process.Name = "process";
            this.process.ReadOnly = true;
            this.process.Width = 50;
            // 
            // arrivalTime
            // 
            this.arrivalTime.HeaderText = "Arrival Time";
            this.arrivalTime.MinimumWidth = 6;
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Width = 75;
            // 
            // burstTime
            // 
            this.burstTime.HeaderText = "Burst Time";
            this.burstTime.MinimumWidth = 6;
            this.burstTime.Name = "burstTime";
            this.burstTime.Width = 75;
            // 
            // priority
            // 
            this.priority.HeaderText = "Priority";
            this.priority.MinimumWidth = 6;
            this.priority.Name = "priority";
            this.priority.Width = 65;
            // 
            // priorityToolStripMenuItem
            // 
            this.priorityToolStripMenuItem.Name = "priorityToolStripMenuItem";
            this.priorityToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.priorityToolStripMenuItem.Text = "Priority";
            this.priorityToolStripMenuItem.Click += new System.EventHandler(this.priorityToolStripMenuItem_Click);
            // 
            // frm_FCFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 714);
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
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuAlgorithms);
            this.MainMenuStrip = this.menuAlgorithms;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_FCFS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU Scheduling Altgorthms";
            this.Load += new System.EventHandler(this.frm_FCFS_Load);
            this.menuAlgorithms.ResumeLayout(false);
            this.menuAlgorithms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn process;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn burstTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority;
        private System.Windows.Forms.ToolStripMenuItem priorityToolStripMenuItem;
    }
}

