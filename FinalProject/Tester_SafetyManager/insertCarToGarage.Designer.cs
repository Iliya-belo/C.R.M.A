namespace FinalProject.Tester_SafetyManager
{
	partial class insertCarToGarage
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
			this.TSMMain = new System.Windows.Forms.ToolStripMenuItem();
			this.listOfRepairedCars = new System.Windows.Forms.ToolStripMenuItem();
			this.updateRepairedParts = new System.Windows.Forms.ToolStripMenuItem();
			this.thisForm = new System.Windows.Forms.ToolStripMenuItem();
			this.monthlyExceptionsHours = new System.Windows.Forms.ToolStripMenuItem();
			this.btnExitAccount = new System.Windows.Forms.ToolStripMenuItem();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.textLicenseNumber = new System.Windows.Forms.TextBox();
			this.textEventNumber = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridPersonalMission = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridPersonalMission)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMMain,
            this.listOfRepairedCars,
            this.updateRepairedParts,
            this.thisForm,
            this.monthlyExceptionsHours,
            this.btnExitAccount});
			this.menuStrip1.Location = new System.Drawing.Point(1128, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(156, 804);
			this.menuStrip1.TabIndex = 132;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// TSMMain
			// 
			this.TSMMain.BackColor = System.Drawing.Color.MidnightBlue;
			this.TSMMain.ForeColor = System.Drawing.Color.White;
			this.TSMMain.Name = "TSMMain";
			this.TSMMain.Size = new System.Drawing.Size(151, 19);
			this.TSMMain.Text = "תפריט";
			this.TSMMain.Click += new System.EventHandler(this.TSMMain_Click);
			// 
			// listOfRepairedCars
			// 
			this.listOfRepairedCars.BackColor = System.Drawing.Color.MidnightBlue;
			this.listOfRepairedCars.ForeColor = System.Drawing.Color.White;
			this.listOfRepairedCars.Name = "listOfRepairedCars";
			this.listOfRepairedCars.Size = new System.Drawing.Size(151, 19);
			this.listOfRepairedCars.Text = "רשימת רכבים בתיקון";
			this.listOfRepairedCars.Click += new System.EventHandler(this.listOfRepairedCars_Click);
			// 
			// updateRepairedParts
			// 
			this.updateRepairedParts.BackColor = System.Drawing.Color.MidnightBlue;
			this.updateRepairedParts.ForeColor = System.Drawing.Color.White;
			this.updateRepairedParts.Name = "updateRepairedParts";
			this.updateRepairedParts.Size = new System.Drawing.Size(151, 19);
			this.updateRepairedParts.Text = "עדכון פרטי תיקון";
			this.updateRepairedParts.Click += new System.EventHandler(this.updateRepairedParts_Click);
			// 
			// thisForm
			// 
			this.thisForm.BackColor = System.Drawing.Color.MidnightBlue;
			this.thisForm.Enabled = false;
			this.thisForm.ForeColor = System.Drawing.Color.White;
			this.thisForm.Name = "thisForm";
			this.thisForm.Size = new System.Drawing.Size(151, 19);
			this.thisForm.Text = "הכנסת רכב למוסך";
			// 
			// monthlyExceptionsHours
			// 
			this.monthlyExceptionsHours.BackColor = System.Drawing.Color.MidnightBlue;
			this.monthlyExceptionsHours.ForeColor = System.Drawing.Color.White;
			this.monthlyExceptionsHours.Name = "monthlyExceptionsHours";
			this.monthlyExceptionsHours.Size = new System.Drawing.Size(151, 19);
			this.monthlyExceptionsHours.Text = "חריגות שעות במשימה";
			this.monthlyExceptionsHours.Click += new System.EventHandler(this.monthlyExceptionsHours_Click);
			// 
			// btnExitAccount
			// 
			this.btnExitAccount.BackColor = System.Drawing.Color.MidnightBlue;
			this.btnExitAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExitAccount.ForeColor = System.Drawing.Color.White;
			this.btnExitAccount.Name = "btnExitAccount";
			this.btnExitAccount.Size = new System.Drawing.Size(151, 19);
			this.btnExitAccount.Text = "התנתק";
			this.btnExitAccount.Click += new System.EventHandler(this.btnExitAccount_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.MidnightBlue;
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(845, 98);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(81, 23);
			this.btnSearch.TabIndex = 146;
			this.btnSearch.Text = "חיפוש";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(1051, 74);
			this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(75, 20);
			this.label16.TabIndex = 144;
			this.label16.Text = "מספר רכב";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(1038, 50);
			this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(88, 20);
			this.label14.TabIndex = 142;
			this.label14.Text = "מספר אירוע";
			// 
			// textLicenseNumber
			// 
			this.textLicenseNumber.Location = new System.Drawing.Point(845, 74);
			this.textLicenseNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textLicenseNumber.Name = "textLicenseNumber";
			this.textLicenseNumber.Size = new System.Drawing.Size(149, 20);
			this.textLicenseNumber.TabIndex = 139;
			this.textLicenseNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textEventNumber
			// 
			this.textEventNumber.Location = new System.Drawing.Point(845, 50);
			this.textEventNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textEventNumber.Name = "textEventNumber";
			this.textEventNumber.Size = new System.Drawing.Size(149, 20);
			this.textEventNumber.TabIndex = 138;
			this.textEventNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.OrangeRed;
			this.label13.Location = new System.Drawing.Point(841, 9);
			this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(285, 39);
			this.label13.TabIndex = 137;
			this.label13.Text = "איתור מהיר";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.MidnightBlue;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(657, 214);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 25);
			this.label1.TabIndex = 171;
			this.label1.Text = "שם לקוח";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridPersonalMission
			// 
			this.dataGridPersonalMission.AllowUserToResizeColumns = false;
			this.dataGridPersonalMission.AllowUserToResizeRows = false;
			this.dataGridPersonalMission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridPersonalMission.ColumnHeadersVisible = false;
			this.dataGridPersonalMission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.dataGridPersonalMission.Location = new System.Drawing.Point(11, 242);
			this.dataGridPersonalMission.Name = "dataGridPersonalMission";
			this.dataGridPersonalMission.ReadOnly = true;
			this.dataGridPersonalMission.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dataGridPersonalMission.RowHeadersVisible = false;
			this.dataGridPersonalMission.RowHeadersWidth = 62;
			this.dataGridPersonalMission.Size = new System.Drawing.Size(1165, 488);
			this.dataGridPersonalMission.TabIndex = 170;
			this.dataGridPersonalMission.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridPersonalMission_CellMouseDoubleClick);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.MidnightBlue;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(546, 214);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 25);
			this.label2.TabIndex = 165;
			this.label2.Text = "מספר טלפון";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.MidnightBlue;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(1077, 214);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 25);
			this.label4.TabIndex = 169;
			this.label4.Text = "מספר אירוע";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.MidnightBlue;
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(967, 214);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(106, 25);
			this.label5.TabIndex = 168;
			this.label5.Text = "תאריך אירוע";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.MidnightBlue;
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(11, 214);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(531, 25);
			this.label6.TabIndex = 166;
			this.label6.Text = "פרטי משימה";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.MidnightBlue;
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(857, 214);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(106, 25);
			this.label7.TabIndex = 167;
			this.label7.Text = "מספר רכב";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "מספר אירוע";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "תאריך אירוע";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn2.Width = 110;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "מספר רכב";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn3.Width = 110;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "שם לקוח";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn4.Width = 200;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "מספר טלפון";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn5.Width = 110;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn6.HeaderText = "הערות";
			this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// insertCarToGarage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1284, 804);
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridPersonalMission);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.textLicenseNumber);
			this.Controls.Add(this.textEventNumber);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.menuStrip1);
			this.Name = "insertCarToGarage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.insertCarToGarage_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridPersonalMission)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem TSMMain;
		private System.Windows.Forms.ToolStripMenuItem listOfRepairedCars;
		private System.Windows.Forms.ToolStripMenuItem updateRepairedParts;
		private System.Windows.Forms.ToolStripMenuItem thisForm;
		private System.Windows.Forms.ToolStripMenuItem monthlyExceptionsHours;
		private System.Windows.Forms.ToolStripMenuItem btnExitAccount;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textLicenseNumber;
		private System.Windows.Forms.TextBox textEventNumber;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridPersonalMission;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
	}
}