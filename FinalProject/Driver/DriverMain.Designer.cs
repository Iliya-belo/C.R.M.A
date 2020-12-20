namespace FinalProject.Driver
{
    partial class DriverMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.parkingDiagram = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.התנתקToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalHour = new System.Windows.Forms.TextBox();
            this.dataGridMissionFinish = new System.Windows.Forms.DataGridView();
            this.License = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacture_Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Milege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysInGarage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EvintNum = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.DateEvent = new System.Windows.Forms.Label();
            this.TaskDetails = new System.Windows.Forms.Label();
            this.licencNumber = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMissionFinish)).BeginInit();
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
            this.toolStripMenuItem3,
            this.parkingDiagram,
            this.toolStripMenuItem2,
            this.התנתקToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1130, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(156, 806);
            this.menuStrip1.TabIndex = 132;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.MidnightBlue;
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 19);
            this.toolStripMenuItem1.Text = "תפריט";
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
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.MidnightBlue;
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(151, 19);
            this.toolStripMenuItem3.Text = "עדכון פרטים";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
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
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(151, 19);
            this.toolStripMenuItem2.Text = "יציאה/חזרה למשימה";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // התנתקToolStripMenuItem
            // 
            this.התנתקToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue;
            this.התנתקToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.התנתקToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.התנתקToolStripMenuItem.Name = "התנתקToolStripMenuItem";
            this.התנתקToolStripMenuItem.Size = new System.Drawing.Size(151, 19);
            this.התנתקToolStripMenuItem.Text = "התנתק";
            this.התנתקToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // totalHour
            // 
            this.totalHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHour.Location = new System.Drawing.Point(127, 54);
            this.totalHour.Margin = new System.Windows.Forms.Padding(2);
            this.totalHour.Multiline = true;
            this.totalHour.Name = "totalHour";
            this.totalHour.ReadOnly = true;
            this.totalHour.Size = new System.Drawing.Size(181, 50);
            this.totalHour.TabIndex = 168;
            this.totalHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridMissionFinish
            // 
            this.dataGridMissionFinish.AllowUserToResizeColumns = false;
            this.dataGridMissionFinish.AllowUserToResizeRows = false;
            this.dataGridMissionFinish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMissionFinish.ColumnHeadersVisible = false;
            this.dataGridMissionFinish.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.License,
            this.Manufacture_Model,
            this.Milege,
            this.daysInGarage,
            this.parkingPlace,
            this.comments});
            this.dataGridMissionFinish.Location = new System.Drawing.Point(9, 146);
            this.dataGridMissionFinish.Name = "dataGridMissionFinish";
            this.dataGridMissionFinish.ReadOnly = true;
            this.dataGridMissionFinish.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridMissionFinish.RowHeadersVisible = false;
            this.dataGridMissionFinish.RowHeadersWidth = 62;
            this.dataGridMissionFinish.Size = new System.Drawing.Size(1265, 656);
            this.dataGridMissionFinish.TabIndex = 160;
            // 
            // License
            // 
            this.License.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.License.HeaderText = "רישוי";
            this.License.MinimumWidth = 8;
            this.License.Name = "License";
            this.License.ReadOnly = true;
            this.License.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Manufacture_Model
            // 
            this.Manufacture_Model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manufacture_Model.HeaderText = "יצרן/דגם";
            this.Manufacture_Model.MinimumWidth = 8;
            this.Manufacture_Model.Name = "Manufacture_Model";
            this.Manufacture_Model.ReadOnly = true;
            this.Manufacture_Model.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Milege
            // 
            this.Milege.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Milege.HeaderText = "קילומטראז\'";
            this.Milege.MinimumWidth = 8;
            this.Milege.Name = "Milege";
            this.Milege.ReadOnly = true;
            this.Milege.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // daysInGarage
            // 
            this.daysInGarage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.daysInGarage.HeaderText = "ימים במגרש";
            this.daysInGarage.MinimumWidth = 8;
            this.daysInGarage.Name = "daysInGarage";
            this.daysInGarage.ReadOnly = true;
            this.daysInGarage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // parkingPlace
            // 
            this.parkingPlace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.parkingPlace.HeaderText = "מס\' חנייה";
            this.parkingPlace.MinimumWidth = 8;
            this.parkingPlace.Name = "parkingPlace";
            this.parkingPlace.ReadOnly = true;
            this.parkingPlace.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // comments
            // 
            this.comments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.comments.HeaderText = "הערות";
            this.comments.MinimumWidth = 8;
            this.comments.Name = "comments";
            this.comments.ReadOnly = true;
            this.comments.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(312, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 50);
            this.label1.TabIndex = 167;
            this.label1.Text = "סה\"כ שעות";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(223, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 25);
            this.label3.TabIndex = 161;
            this.label3.Text = "הערות";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EvintNum
            // 
            this.EvintNum.BackColor = System.Drawing.Color.MidnightBlue;
            this.EvintNum.ForeColor = System.Drawing.Color.White;
            this.EvintNum.Location = new System.Drawing.Point(1065, 118);
            this.EvintNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EvintNum.Name = "EvintNum";
            this.EvintNum.Size = new System.Drawing.Size(209, 25);
            this.EvintNum.TabIndex = 166;
            this.EvintNum.Text = "מספר אירוע";
            this.EvintNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.MidnightBlue;
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(8, 118);
            this.time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(211, 25);
            this.time.TabIndex = 162;
            this.time.Text = "שעות ביצוע";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateEvent
            // 
            this.DateEvent.BackColor = System.Drawing.Color.MidnightBlue;
            this.DateEvent.ForeColor = System.Drawing.Color.White;
            this.DateEvent.Location = new System.Drawing.Point(854, 118);
            this.DateEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateEvent.Name = "DateEvent";
            this.DateEvent.Size = new System.Drawing.Size(207, 25);
            this.DateEvent.TabIndex = 165;
            this.DateEvent.Text = "תאריך אירוע";
            this.DateEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaskDetails
            // 
            this.TaskDetails.BackColor = System.Drawing.Color.MidnightBlue;
            this.TaskDetails.ForeColor = System.Drawing.Color.White;
            this.TaskDetails.Location = new System.Drawing.Point(434, 118);
            this.TaskDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TaskDetails.Name = "TaskDetails";
            this.TaskDetails.Size = new System.Drawing.Size(206, 25);
            this.TaskDetails.TabIndex = 163;
            this.TaskDetails.Text = "פרטי משימה";
            this.TaskDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // licencNumber
            // 
            this.licencNumber.BackColor = System.Drawing.Color.MidnightBlue;
            this.licencNumber.ForeColor = System.Drawing.Color.White;
            this.licencNumber.Location = new System.Drawing.Point(644, 118);
            this.licencNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.licencNumber.Name = "licencNumber";
            this.licencNumber.Size = new System.Drawing.Size(206, 25);
            this.licencNumber.TabIndex = 164;
            this.licencNumber.Text = "מספר רכב";
            this.licencNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DriverMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 806);
            this.ControlBox = false;
            this.Controls.Add(this.totalHour);
            this.Controls.Add(this.dataGridMissionFinish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EvintNum);
            this.Controls.Add(this.time);
            this.Controls.Add(this.DateEvent);
            this.Controls.Add(this.TaskDetails);
            this.Controls.Add(this.licencNumber);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DriverMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DriverMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMissionFinish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parkingDiagram;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem התנתקToolStripMenuItem;
        private System.Windows.Forms.TextBox totalHour;
        private System.Windows.Forms.DataGridView dataGridMissionFinish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EvintNum;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label DateEvent;
        private System.Windows.Forms.Label TaskDetails;
        private System.Windows.Forms.Label licencNumber;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.DataGridViewTextBoxColumn License;
		private System.Windows.Forms.DataGridViewTextBoxColumn Manufacture_Model;
		private System.Windows.Forms.DataGridViewTextBoxColumn Milege;
		private System.Windows.Forms.DataGridViewTextBoxColumn daysInGarage;
		private System.Windows.Forms.DataGridViewTextBoxColumn parkingPlace;
		private System.Windows.Forms.DataGridViewTextBoxColumn comments;
	}
}