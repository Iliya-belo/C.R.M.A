namespace FinalProject.CEO
{
    partial class listOfMeetings
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
			this.mainCEO = new System.Windows.Forms.ToolStripMenuItem();
			this.listOfCarsToBeApproved = new System.Windows.Forms.ToolStripMenuItem();
			this.thisForm = new System.Windows.Forms.ToolStripMenuItem();
			this.exceptionList = new System.Windows.Forms.ToolStripMenuItem();
			this.WorkCar = new System.Windows.Forms.ToolStripMenuItem();
			this.monthlyExceptionsHours = new System.Windows.Forms.ToolStripMenuItem();
			this.btnExitAccount = new System.Windows.Forms.ToolStripMenuItem();
			this.label22 = new System.Windows.Forms.Label();
			this.textPhoneNumber = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.textInfoRequest = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.textFirstName = new System.Windows.Forms.TextBox();
			this.textLastName = new System.Windows.Forms.TextBox();
			this.textRole = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textID = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.dataGridMeetings = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.InfoRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MeetingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Accept = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Refuse = new System.Windows.Forms.DataGridViewButtonColumn();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridMeetings)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainCEO,
            this.listOfCarsToBeApproved,
            this.thisForm,
            this.exceptionList,
            this.WorkCar,
            this.monthlyExceptionsHours,
            this.btnExitAccount});
			this.menuStrip1.Location = new System.Drawing.Point(1156, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(122, 798);
			this.menuStrip1.TabIndex = 130;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mainCEO
			// 
			this.mainCEO.BackColor = System.Drawing.Color.MidnightBlue;
			this.mainCEO.ForeColor = System.Drawing.Color.White;
			this.mainCEO.Name = "mainCEO";
			this.mainCEO.Size = new System.Drawing.Size(117, 19);
			this.mainCEO.Text = "תפריט";
			this.mainCEO.Click += new System.EventHandler(this.mainCEO_Click);
			// 
			// listOfCarsToBeApproved
			// 
			this.listOfCarsToBeApproved.BackColor = System.Drawing.Color.MidnightBlue;
			this.listOfCarsToBeApproved.ForeColor = System.Drawing.Color.White;
			this.listOfCarsToBeApproved.Name = "listOfCarsToBeApproved";
			this.listOfCarsToBeApproved.Size = new System.Drawing.Size(117, 19);
			this.listOfCarsToBeApproved.Text = "רשימת רכבים לאישור";
			this.listOfCarsToBeApproved.Click += new System.EventHandler(this.listOfCarsToBeApproved_Click);
			// 
			// thisForm
			// 
			this.thisForm.BackColor = System.Drawing.Color.MidnightBlue;
			this.thisForm.Enabled = false;
			this.thisForm.ForeColor = System.Drawing.Color.White;
			this.thisForm.Name = "thisForm";
			this.thisForm.Size = new System.Drawing.Size(117, 19);
			this.thisForm.Text = "רשימת אנשים לשיחה";
			// 
			// exceptionList
			// 
			this.exceptionList.BackColor = System.Drawing.Color.MidnightBlue;
			this.exceptionList.ForeColor = System.Drawing.Color.White;
			this.exceptionList.Name = "exceptionList";
			this.exceptionList.Size = new System.Drawing.Size(117, 19);
			this.exceptionList.Text = "רשימת רכבים במוסך";
			this.exceptionList.Click += new System.EventHandler(this.exceptionList_Click);
			// 
			// WorkCar
			// 
			this.WorkCar.BackColor = System.Drawing.Color.MidnightBlue;
			this.WorkCar.ForeColor = System.Drawing.Color.White;
			this.WorkCar.Name = "WorkCar";
			this.WorkCar.Size = new System.Drawing.Size(117, 19);
			this.WorkCar.Text = "הגדרת רכב עבודה";
			this.WorkCar.Click += new System.EventHandler(this.WorkCar_Click);
			// 
			// monthlyExceptionsHours
			// 
			this.monthlyExceptionsHours.BackColor = System.Drawing.Color.MidnightBlue;
			this.monthlyExceptionsHours.ForeColor = System.Drawing.Color.White;
			this.monthlyExceptionsHours.Name = "monthlyExceptionsHours";
			this.monthlyExceptionsHours.Size = new System.Drawing.Size(117, 19);
			this.monthlyExceptionsHours.Text = "חריגות שעות במשימה";
			this.monthlyExceptionsHours.Click += new System.EventHandler(this.monthlyExceptionsHours_Click);
			// 
			// btnExitAccount
			// 
			this.btnExitAccount.BackColor = System.Drawing.Color.MidnightBlue;
			this.btnExitAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExitAccount.ForeColor = System.Drawing.Color.White;
			this.btnExitAccount.Name = "btnExitAccount";
			this.btnExitAccount.Size = new System.Drawing.Size(117, 19);
			this.btnExitAccount.Text = "התנתק";
			this.btnExitAccount.Click += new System.EventHandler(this.btnExitAccount_Click);
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.MidnightBlue;
			this.label22.ForeColor = System.Drawing.Color.White;
			this.label22.Location = new System.Drawing.Point(204, 9);
			this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(155, 33);
			this.label22.TabIndex = 143;
			this.label22.Text = "תאריך המבוקש לפגישה";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textPhoneNumber
			// 
			this.textPhoneNumber.Location = new System.Drawing.Point(363, 44);
			this.textPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
			this.textPhoneNumber.Name = "textPhoneNumber";
			this.textPhoneNumber.Size = new System.Drawing.Size(156, 20);
			this.textPhoneNumber.TabIndex = 142;
			this.textPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textPhoneNumber.TextChanged += new System.EventHandler(this.textPhoneNumber_TextChanged);
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.MidnightBlue;
			this.label21.ForeColor = System.Drawing.Color.White;
			this.label21.Location = new System.Drawing.Point(363, 9);
			this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(155, 33);
			this.label21.TabIndex = 141;
			this.label21.Text = "מס\' טלפון";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textInfoRequest
			// 
			this.textInfoRequest.Location = new System.Drawing.Point(521, 44);
			this.textInfoRequest.Margin = new System.Windows.Forms.Padding(2);
			this.textInfoRequest.Name = "textInfoRequest";
			this.textInfoRequest.Size = new System.Drawing.Size(156, 20);
			this.textInfoRequest.TabIndex = 140;
			this.textInfoRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textInfoRequest.TextChanged += new System.EventHandler(this.textInfoRequest_TextChanged);
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.MidnightBlue;
			this.label20.ForeColor = System.Drawing.Color.White;
			this.label20.Location = new System.Drawing.Point(521, 9);
			this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(155, 33);
			this.label20.TabIndex = 139;
			this.label20.Text = "פרטי בקשה";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textFirstName
			// 
			this.textFirstName.Location = new System.Drawing.Point(984, 44);
			this.textFirstName.Margin = new System.Windows.Forms.Padding(2);
			this.textFirstName.Name = "textFirstName";
			this.textFirstName.Size = new System.Drawing.Size(91, 20);
			this.textFirstName.TabIndex = 138;
			this.textFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textFirstName.TextChanged += new System.EventHandler(this.textFirstName_TextChanged);
			// 
			// textLastName
			// 
			this.textLastName.Location = new System.Drawing.Point(847, 44);
			this.textLastName.Margin = new System.Windows.Forms.Padding(2);
			this.textLastName.Name = "textLastName";
			this.textLastName.Size = new System.Drawing.Size(134, 20);
			this.textLastName.TabIndex = 137;
			this.textLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textLastName.TextChanged += new System.EventHandler(this.textLastName_TextChanged);
			// 
			// textRole
			// 
			this.textRole.Location = new System.Drawing.Point(680, 44);
			this.textRole.Margin = new System.Windows.Forms.Padding(2);
			this.textRole.Name = "textRole";
			this.textRole.Size = new System.Drawing.Size(163, 20);
			this.textRole.TabIndex = 136;
			this.textRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textRole.TextChanged += new System.EventHandler(this.textRole_TextChanged);
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.MidnightBlue;
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(1078, 9);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(81, 33);
			this.label9.TabIndex = 135;
			this.label9.Text = "ת\"ז";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textID
			// 
			this.textID.Location = new System.Drawing.Point(1078, 44);
			this.textID.Margin = new System.Windows.Forms.Padding(2);
			this.textID.Name = "textID";
			this.textID.Size = new System.Drawing.Size(81, 20);
			this.textID.TabIndex = 134;
			this.textID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.MidnightBlue;
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(984, 9);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(90, 33);
			this.label10.TabIndex = 133;
			this.label10.Text = "שם";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.MidnightBlue;
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(847, 9);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(133, 33);
			this.label11.TabIndex = 132;
			this.label11.Text = "שם משפחה";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.MidnightBlue;
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(680, 9);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(163, 33);
			this.label12.TabIndex = 131;
			this.label12.Text = "תפקיד";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridMeetings
			// 
			this.dataGridMeetings.AllowUserToResizeColumns = false;
			this.dataGridMeetings.AllowUserToResizeRows = false;
			this.dataGridMeetings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridMeetings.ColumnHeadersVisible = false;
			this.dataGridMeetings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.Role,
            this.InfoRequest,
            this.PhoneNumber,
            this.MeetingDate,
            this.Accept,
            this.Refuse});
			this.dataGridMeetings.EnableHeadersVisualStyles = false;
			this.dataGridMeetings.Location = new System.Drawing.Point(11, 69);
			this.dataGridMeetings.Name = "dataGridMeetings";
			this.dataGridMeetings.ReadOnly = true;
			this.dataGridMeetings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dataGridMeetings.RowHeadersVisible = false;
			this.dataGridMeetings.Size = new System.Drawing.Size(1148, 700);
			this.dataGridMeetings.TabIndex = 145;
			this.dataGridMeetings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMeetings_CellContentClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ת\"ז";
			this.ID.Name = "ID";
			this.ID.Width = 82;
			// 
			// FirstName
			// 
			this.FirstName.HeaderText = "שם";
			this.FirstName.Name = "FirstName";
			this.FirstName.Width = 94;
			// 
			// LastName
			// 
			this.LastName.HeaderText = "שם משפחה";
			this.LastName.Name = "LastName";
			this.LastName.Width = 137;
			// 
			// Role
			// 
			this.Role.HeaderText = "תפקיד";
			this.Role.Name = "Role";
			this.Role.Width = 167;
			// 
			// InfoRequest
			// 
			this.InfoRequest.HeaderText = "פרטי בקשה";
			this.InfoRequest.Name = "InfoRequest";
			this.InfoRequest.Width = 159;
			// 
			// PhoneNumber
			// 
			this.PhoneNumber.HeaderText = "מס\' טלפון";
			this.PhoneNumber.Name = "PhoneNumber";
			this.PhoneNumber.Width = 159;
			// 
			// MeetingDate
			// 
			this.MeetingDate.HeaderText = "תאריך המבוקש לפגישה";
			this.MeetingDate.Name = "MeetingDate";
			this.MeetingDate.Width = 157;
			// 
			// Accept
			// 
			this.Accept.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Accept.HeaderText = "אישור";
			this.Accept.Name = "Accept";
			this.Accept.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Accept.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Accept.Text = "אישור";
			this.Accept.UseColumnTextForButtonValue = true;
			// 
			// Refuse
			// 
			this.Refuse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Refuse.HeaderText = "ביטול";
			this.Refuse.Name = "Refuse";
			this.Refuse.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Refuse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Refuse.Text = "ביטול";
			this.Refuse.UseColumnTextForButtonValue = true;
			// 
			// listOfMeetings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1278, 798);
			this.ControlBox = false;
			this.Controls.Add(this.dataGridMeetings);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.textPhoneNumber);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.textInfoRequest);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.textFirstName);
			this.Controls.Add(this.textLastName);
			this.Controls.Add(this.textRole);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textID);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "listOfMeetings";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.listOfMeetings_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridMeetings)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainCEO;
        private System.Windows.Forms.ToolStripMenuItem listOfCarsToBeApproved;
        private System.Windows.Forms.ToolStripMenuItem thisForm;
        private System.Windows.Forms.ToolStripMenuItem exceptionList;
        private System.Windows.Forms.ToolStripMenuItem monthlyExceptionsHours;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textInfoRequest;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textRole;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ToolStripMenuItem btnExitAccount;
		private System.Windows.Forms.DataGridView dataGridMeetings;
        private System.Windows.Forms.ToolStripMenuItem WorkCar;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Role;
		private System.Windows.Forms.DataGridViewTextBoxColumn InfoRequest;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn MeetingDate;
		private System.Windows.Forms.DataGridViewButtonColumn Accept;
		private System.Windows.Forms.DataGridViewButtonColumn Refuse;
	}
}