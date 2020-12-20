namespace FinalProject.Driver
{
    partial class Job
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.רשימתמשימותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parkingDiagram = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkerInfo = new System.Windows.Forms.TextBox();
            this.licenceNum = new System.Windows.Forms.TextBox();
            this.InfoOfMission = new System.Windows.Forms.TextBox();
            this.EventNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.timerPause = new System.Windows.Forms.Label();
            this.timeWork = new System.Windows.Forms.Label();
            this.workTime = new System.Windows.Forms.Timer(this.components);
            this.pauseTime = new System.Windows.Forms.Timer(this.components);
            this.dataCars = new System.Windows.Forms.DataGridView();
            this.License = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarToChenge = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCars)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.testToolStripMenuItem,
            this.רשימתמשימותToolStripMenuItem,
            this.parkingDiagram,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(801, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(156, 549);
            this.menuStrip1.TabIndex = 134;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.MidnightBlue;
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 19);
            this.toolStripMenuItem1.Text = "תפריט";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue;
            this.testToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(151, 19);
            this.testToolStripMenuItem.Text = "רשימת משימות";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // רשימתמשימותToolStripMenuItem
            // 
            this.רשימתמשימותToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue;
            this.רשימתמשימותToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.רשימתמשימותToolStripMenuItem.Name = "רשימתמשימותToolStripMenuItem";
            this.רשימתמשימותToolStripMenuItem.Size = new System.Drawing.Size(151, 19);
            this.רשימתמשימותToolStripMenuItem.Text = "עדכון פרטים";
            this.רשימתמשימותToolStripMenuItem.Click += new System.EventHandler(this.רשימתמשימותToolStripMenuItem_Click);
            // 
            // parkingDiagram
            // 
            this.parkingDiagram.BackColor = System.Drawing.Color.MidnightBlue;
            this.parkingDiagram.ForeColor = System.Drawing.Color.White;
            this.parkingDiagram.Name = "parkingDiagram";
            this.parkingDiagram.Size = new System.Drawing.Size(151, 19);
            this.parkingDiagram.Text = "מגרש חניה";
            this.parkingDiagram.Click += new System.EventHandler(this.parkingDiagram_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.MidnightBlue;
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(151, 19);
            this.toolStripMenuItem2.Text = "יציאה/חזרה למשימה";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.MidnightBlue;
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(151, 19);
            this.toolStripMenuItem3.Text = "התנתק";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // WorkerInfo
            // 
            this.WorkerInfo.Location = new System.Drawing.Point(328, 293);
            this.WorkerInfo.Margin = new System.Windows.Forms.Padding(2);
            this.WorkerInfo.Multiline = true;
            this.WorkerInfo.Name = "WorkerInfo";
            this.WorkerInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WorkerInfo.Size = new System.Drawing.Size(322, 215);
            this.WorkerInfo.TabIndex = 157;
            // 
            // licenceNum
            // 
            this.licenceNum.Location = new System.Drawing.Point(519, 33);
            this.licenceNum.Margin = new System.Windows.Forms.Padding(2);
            this.licenceNum.Name = "licenceNum";
            this.licenceNum.ReadOnly = true;
            this.licenceNum.Size = new System.Drawing.Size(131, 20);
            this.licenceNum.TabIndex = 155;
            this.licenceNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InfoOfMission
            // 
            this.InfoOfMission.Location = new System.Drawing.Point(328, 86);
            this.InfoOfMission.Margin = new System.Windows.Forms.Padding(2);
            this.InfoOfMission.Multiline = true;
            this.InfoOfMission.Name = "InfoOfMission";
            this.InfoOfMission.ReadOnly = true;
            this.InfoOfMission.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InfoOfMission.Size = new System.Drawing.Size(322, 195);
            this.InfoOfMission.TabIndex = 154;
            // 
            // EventNum
            // 
            this.EventNum.Location = new System.Drawing.Point(519, 9);
            this.EventNum.Margin = new System.Windows.Forms.Padding(2);
            this.EventNum.Name = "EventNum";
            this.EventNum.Size = new System.Drawing.Size(131, 20);
            this.EventNum.TabIndex = 153;
            this.EventNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EventNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(685, 293);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 152;
            this.label6.Text = "הערות העובד למשימה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(714, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 151;
            this.label5.Text = "מס\' רכב להחלפה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(759, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 150;
            this.label4.Text = "מס\' רכב";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(735, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 149;
            this.label3.Text = "פרטי משימה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(748, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 148;
            this.label2.Text = "מס\' אירוע";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.MidnightBlue;
            this.Start.Enabled = false;
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(102, 155);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(162, 35);
            this.Start.TabIndex = 158;
            this.Start.Text = "התחלה/סיום";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.MidnightBlue;
            this.Pause.ForeColor = System.Drawing.Color.White;
            this.Pause.Location = new System.Drawing.Point(102, 352);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(162, 35);
            this.Pause.TabIndex = 159;
            this.Pause.Text = "יציאה להפסקה";
            this.Pause.UseVisualStyleBackColor = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // timerPause
            // 
            this.timerPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerPause.Location = new System.Drawing.Point(108, 296);
            this.timerPause.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timerPause.Name = "timerPause";
            this.timerPause.Size = new System.Drawing.Size(156, 53);
            this.timerPause.TabIndex = 161;
            this.timerPause.Text = "00:30:00";
            this.timerPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeWork
            // 
            this.timeWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeWork.Location = new System.Drawing.Point(108, 94);
            this.timeWork.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeWork.Name = "timeWork";
            this.timeWork.Size = new System.Drawing.Size(156, 53);
            this.timeWork.TabIndex = 160;
            this.timeWork.Text = "00:00:00";
            this.timeWork.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // workTime
            // 
            this.workTime.Interval = 10;
            this.workTime.Tick += new System.EventHandler(this.workTime_Tick);
            // 
            // pauseTime
            // 
            this.pauseTime.Interval = 10;
            this.pauseTime.Tick += new System.EventHandler(this.pauseTime_Tick);
            // 
            // dataCars
            // 
            this.dataCars.AllowUserToResizeColumns = false;
            this.dataCars.AllowUserToResizeRows = false;
            this.dataCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCars.ColumnHeadersVisible = false;
            this.dataCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.License});
            this.dataCars.Location = new System.Drawing.Point(519, 85);
            this.dataCars.Name = "dataCars";
            this.dataCars.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataCars.RowHeadersVisible = false;
            this.dataCars.RowHeadersWidth = 62;
            this.dataCars.Size = new System.Drawing.Size(131, 148);
            this.dataCars.TabIndex = 163;
            this.dataCars.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCars_CellDoubleClick);
            // 
            // License
            // 
            this.License.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.License.HeaderText = "רישוי";
            this.License.MinimumWidth = 8;
            this.License.Name = "License";
            this.License.ReadOnly = true;
            this.License.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CarToChenge
            // 
            this.CarToChenge.Location = new System.Drawing.Point(519, 57);
            this.CarToChenge.Margin = new System.Windows.Forms.Padding(2);
            this.CarToChenge.Name = "CarToChenge";
            this.CarToChenge.Size = new System.Drawing.Size(131, 20);
            this.CarToChenge.TabIndex = 164;
            this.CarToChenge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CarToChenge.TextChanged += new System.EventHandler(this.CarToChenge_TextChanged);
            // 
            // Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 549);
            this.ControlBox = false;
            this.Controls.Add(this.CarToChenge);
            this.Controls.Add(this.dataCars);
            this.Controls.Add(this.timerPause);
            this.Controls.Add(this.timeWork);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.WorkerInfo);
            this.Controls.Add(this.licenceNum);
            this.Controls.Add(this.InfoOfMission);
            this.Controls.Add(this.EventNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Job";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Job_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem רשימתמשימותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TextBox WorkerInfo;
        private System.Windows.Forms.TextBox licenceNum;
        private System.Windows.Forms.TextBox InfoOfMission;
        private System.Windows.Forms.TextBox EventNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Label timerPause;
        private System.Windows.Forms.Label timeWork;
        private System.Windows.Forms.Timer workTime;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Timer pauseTime;
        private System.Windows.Forms.DataGridView dataCars;
        private System.Windows.Forms.DataGridViewTextBoxColumn License;
        private System.Windows.Forms.TextBox CarToChenge;
		private System.Windows.Forms.ToolStripMenuItem parkingDiagram;
	}
}