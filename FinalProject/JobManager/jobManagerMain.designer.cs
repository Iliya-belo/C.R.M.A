namespace FinalProject.JobManager
{
	partial class jobManagerMain
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
			this.addMission = new System.Windows.Forms.ToolStripMenuItem();
			this.missionList = new System.Windows.Forms.ToolStripMenuItem();
			this.exceptionsList = new System.Windows.Forms.ToolStripMenuItem();
			this.monthlyExecptionsHours = new System.Windows.Forms.ToolStripMenuItem();
			this.btnExitAccount = new System.Windows.Forms.ToolStripMenuItem();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.textFirstName = new System.Windows.Forms.TextBox();
			this.textID = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.dataGridJob = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AmountHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SequentialAmountHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.textLastName = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridJob)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.addMission,
            this.missionList,
            this.exceptionsList,
            this.monthlyExecptionsHours,
            this.btnExitAccount});
			this.menuStrip1.Location = new System.Drawing.Point(1659, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(183, 1115);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.BackColor = System.Drawing.Color.MidnightBlue;
			this.toolStripMenuItem1.Enabled = false;
			this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(176, 29);
			this.toolStripMenuItem1.Text = "תפריט";
			// 
			// addMission
			// 
			this.addMission.BackColor = System.Drawing.Color.MidnightBlue;
			this.addMission.ForeColor = System.Drawing.Color.White;
			this.addMission.Name = "addMission";
			this.addMission.Size = new System.Drawing.Size(176, 29);
			this.addMission.Text = "יצירת משימה";
			this.addMission.Click += new System.EventHandler(this.addMission_Click);
			// 
			// missionList
			// 
			this.missionList.BackColor = System.Drawing.Color.MidnightBlue;
			this.missionList.ForeColor = System.Drawing.Color.White;
			this.missionList.Name = "missionList";
			this.missionList.Size = new System.Drawing.Size(176, 29);
			this.missionList.Text = "רשימת משימות";
			this.missionList.Click += new System.EventHandler(this.missionList_Click);
			// 
			// exceptionsList
			// 
			this.exceptionsList.BackColor = System.Drawing.Color.MidnightBlue;
			this.exceptionsList.ForeColor = System.Drawing.Color.White;
			this.exceptionsList.Name = "exceptionsList";
			this.exceptionsList.Size = new System.Drawing.Size(176, 29);
			this.exceptionsList.Text = "רשימת רכבים במוסך";
			this.exceptionsList.Click += new System.EventHandler(this.exceptionsList_Click);
			// 
			// monthlyExecptionsHours
			// 
			this.monthlyExecptionsHours.BackColor = System.Drawing.Color.MidnightBlue;
			this.monthlyExecptionsHours.ForeColor = System.Drawing.Color.White;
			this.monthlyExecptionsHours.Name = "monthlyExecptionsHours";
			this.monthlyExecptionsHours.Size = new System.Drawing.Size(176, 29);
			this.monthlyExecptionsHours.Text = "חריגות שעות במשימה";
			this.monthlyExecptionsHours.Click += new System.EventHandler(this.monthlyExecptionsHours_Click);
			// 
			// btnExitAccount
			// 
			this.btnExitAccount.BackColor = System.Drawing.Color.MidnightBlue;
			this.btnExitAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExitAccount.ForeColor = System.Drawing.Color.White;
			this.btnExitAccount.Name = "btnExitAccount";
			this.btnExitAccount.Size = new System.Drawing.Size(176, 29);
			this.btnExitAccount.Text = "התנתק";
			this.btnExitAccount.Click += new System.EventHandler(this.btnExitAccount_Click);
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.MidnightBlue;
			this.label23.ForeColor = System.Drawing.Color.White;
			this.label23.Location = new System.Drawing.Point(16, 338);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(276, 51);
			this.label23.TabIndex = 94;
			this.label23.Text = "שעות מוגדרות עבור עובד";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.MidnightBlue;
			this.label22.ForeColor = System.Drawing.Color.White;
			this.label22.Location = new System.Drawing.Point(298, 338);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(270, 51);
			this.label22.TabIndex = 92;
			this.label22.Text = "סה\"כ שעות";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.MidnightBlue;
			this.label21.ForeColor = System.Drawing.Color.White;
			this.label21.Location = new System.Drawing.Point(574, 338);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(272, 51);
			this.label21.TabIndex = 90;
			this.label21.Text = "מס\' טלפון";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonSearch
			// 
			this.buttonSearch.BackColor = System.Drawing.Color.MidnightBlue;
			this.buttonSearch.ForeColor = System.Drawing.Color.White;
			this.buttonSearch.Location = new System.Drawing.Point(1240, 188);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(122, 35);
			this.buttonSearch.TabIndex = 87;
			this.buttonSearch.Text = "חיפוש";
			this.buttonSearch.UseVisualStyleBackColor = false;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(1618, 114);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(43, 29);
			this.label16.TabIndex = 83;
			this.label16.Text = "שם";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(1616, 77);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(44, 29);
			this.label14.TabIndex = 81;
			this.label14.Text = "ת\"ז";
			// 
			// textFirstName
			// 
			this.textFirstName.Location = new System.Drawing.Point(1240, 114);
			this.textFirstName.Name = "textFirstName";
			this.textFirstName.Size = new System.Drawing.Size(222, 26);
			this.textFirstName.TabIndex = 77;
			// 
			// textID
			// 
			this.textID.Location = new System.Drawing.Point(1240, 77);
			this.textID.Name = "textID";
			this.textID.Size = new System.Drawing.Size(222, 26);
			this.textID.TabIndex = 75;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.OrangeRed;
			this.label13.Location = new System.Drawing.Point(1234, 14);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(428, 60);
			this.label13.TabIndex = 74;
			this.label13.Text = "איתור מהיר";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.MidnightBlue;
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(1404, 338);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(274, 51);
			this.label9.TabIndex = 70;
			this.label9.Text = "ת\"ז";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.MidnightBlue;
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(1128, 338);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(270, 51);
			this.label10.TabIndex = 68;
			this.label10.Text = "שם";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.MidnightBlue;
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(852, 338);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(270, 51);
			this.label11.TabIndex = 67;
			this.label11.Text = "שם משפחה";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridJob
			// 
			this.dataGridJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridJob.ColumnHeadersVisible = false;
			this.dataGridJob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.PhoneNumber,
            this.AmountHours,
            this.SequentialAmountHours});
			this.dataGridJob.Location = new System.Drawing.Point(16, 394);
			this.dataGridJob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridJob.Name = "dataGridJob";
			this.dataGridJob.ReadOnly = true;
			this.dataGridJob.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dataGridJob.RowHeadersVisible = false;
			this.dataGridJob.RowHeadersWidth = 62;
			this.dataGridJob.Size = new System.Drawing.Size(1662, 771);
			this.dataGridJob.TabIndex = 98;
			// 
			// ID
			// 
			this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ID.HeaderText = "ת\"ז";
			this.ID.MinimumWidth = 8;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			// 
			// FirstName
			// 
			this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.FirstName.HeaderText = "שם";
			this.FirstName.MinimumWidth = 8;
			this.FirstName.Name = "FirstName";
			this.FirstName.ReadOnly = true;
			// 
			// LastName
			// 
			this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.LastName.HeaderText = "שם משפחה";
			this.LastName.MinimumWidth = 8;
			this.LastName.Name = "LastName";
			this.LastName.ReadOnly = true;
			// 
			// PhoneNumber
			// 
			this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.PhoneNumber.HeaderText = "מס\' טלפון";
			this.PhoneNumber.MinimumWidth = 8;
			this.PhoneNumber.Name = "PhoneNumber";
			this.PhoneNumber.ReadOnly = true;
			// 
			// AmountHours
			// 
			this.AmountHours.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.AmountHours.HeaderText = "סה\"כ שעות";
			this.AmountHours.MinimumWidth = 8;
			this.AmountHours.Name = "AmountHours";
			this.AmountHours.ReadOnly = true;
			// 
			// SequentialAmountHours
			// 
			this.SequentialAmountHours.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.SequentialAmountHours.HeaderText = "שעות מוגדרות עבור עובד";
			this.SequentialAmountHours.MinimumWidth = 8;
			this.SequentialAmountHours.Name = "SequentialAmountHours";
			this.SequentialAmountHours.ReadOnly = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(1540, 151);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 29);
			this.label1.TabIndex = 100;
			this.label1.Text = "שם משפחה";
			// 
			// textLastName
			// 
			this.textLastName.Location = new System.Drawing.Point(1240, 151);
			this.textLastName.Name = "textLastName";
			this.textLastName.Size = new System.Drawing.Size(222, 26);
			this.textLastName.TabIndex = 99;
			// 
			// jobManagerMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1842, 1115);
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textLastName);
			this.Controls.Add(this.dataGridJob);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.textFirstName);
			this.Controls.Add(this.textID);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "jobManagerMain";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridJob)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem addMission;
		private System.Windows.Forms.ToolStripMenuItem missionList;
		private System.Windows.Forms.ToolStripMenuItem exceptionsList;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textFirstName;
		private System.Windows.Forms.TextBox textID;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ToolStripMenuItem monthlyExecptionsHours;
		private System.Windows.Forms.DataGridView dataGridJob;
		private System.Windows.Forms.ToolStripMenuItem btnExitAccount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textLastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn AmountHours;
		private System.Windows.Forms.DataGridViewTextBoxColumn SequentialAmountHours;
	}
}

