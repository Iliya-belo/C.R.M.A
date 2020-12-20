namespace FinalProject.CEO
{
    partial class mainCEO
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
			this.thisForm = new System.Windows.Forms.ToolStripMenuItem();
			this.listOfCarsToBeApproved = new System.Windows.Forms.ToolStripMenuItem();
			this.listOfMeetings = new System.Windows.Forms.ToolStripMenuItem();
			this.exceptionList = new System.Windows.Forms.ToolStripMenuItem();
			this.WorkCar = new System.Windows.Forms.ToolStripMenuItem();
			this.monthlyExceptionsHours = new System.Windows.Forms.ToolStripMenuItem();
			this.btnExitAccount = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageJob = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.dataGridJobs = new System.Windows.Forms.DataGridView();
			this.tabPageOptions = new System.Windows.Forms.TabPage();
			this.textLimitation = new System.Windows.Forms.TextBox();
			this.textGuideLine = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dataGridOptions = new System.Windows.Forms.DataGridView();
			this.GuideLineNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GuideLineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Limitation = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Accept = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Reject = new System.Windows.Forms.DataGridViewButtonColumn();
			this.menuStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPageJob.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridJobs)).BeginInit();
			this.tabPageOptions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridOptions)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thisForm,
            this.listOfCarsToBeApproved,
            this.listOfMeetings,
            this.exceptionList,
            this.WorkCar,
            this.monthlyExceptionsHours,
            this.btnExitAccount});
			this.menuStrip1.Location = new System.Drawing.Point(1157, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(122, 709);
			this.menuStrip1.TabIndex = 130;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// thisForm
			// 
			this.thisForm.BackColor = System.Drawing.Color.MidnightBlue;
			this.thisForm.Enabled = false;
			this.thisForm.ForeColor = System.Drawing.Color.White;
			this.thisForm.Name = "thisForm";
			this.thisForm.Size = new System.Drawing.Size(117, 19);
			this.thisForm.Text = "תפריט";
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
			// listOfMeetings
			// 
			this.listOfMeetings.BackColor = System.Drawing.Color.MidnightBlue;
			this.listOfMeetings.ForeColor = System.Drawing.Color.White;
			this.listOfMeetings.Name = "listOfMeetings";
			this.listOfMeetings.Size = new System.Drawing.Size(117, 19);
			this.listOfMeetings.Text = "רשימת אנשים לשיחה";
			this.listOfMeetings.Click += new System.EventHandler(this.listOfMeetings_Click);
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
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageJob);
			this.tabControl1.Controls.Add(this.tabPageOptions);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tabControl1.RightToLeftLayout = true;
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1139, 749);
			this.tabControl1.TabIndex = 131;
			// 
			// tabPageJob
			// 
			this.tabPageJob.Controls.Add(this.label1);
			this.tabPageJob.Controls.Add(this.label21);
			this.tabPageJob.Controls.Add(this.label9);
			this.tabPageJob.Controls.Add(this.label10);
			this.tabPageJob.Controls.Add(this.label11);
			this.tabPageJob.Controls.Add(this.label12);
			this.tabPageJob.Controls.Add(this.dataGridJobs);
			this.tabPageJob.Location = new System.Drawing.Point(4, 22);
			this.tabPageJob.Name = "tabPageJob";
			this.tabPageJob.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageJob.Size = new System.Drawing.Size(1131, 723);
			this.tabPageJob.TabIndex = 0;
			this.tabPageJob.Text = "ראיונות עבודה";
			this.tabPageJob.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.MidnightBlue;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(329, 3);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 33);
			this.label1.TabIndex = 147;
			this.label1.Text = "אימייל";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.MidnightBlue;
			this.label21.ForeColor = System.Drawing.Color.White;
			this.label21.Location = new System.Drawing.Point(488, 3);
			this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(155, 33);
			this.label21.TabIndex = 146;
			this.label21.Text = "מס\' טלפון";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.MidnightBlue;
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(1045, 3);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(81, 33);
			this.label9.TabIndex = 145;
			this.label9.Text = "ת\"ז";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.MidnightBlue;
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(951, 3);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(90, 33);
			this.label10.TabIndex = 144;
			this.label10.Text = "שם";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.MidnightBlue;
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(814, 3);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(133, 33);
			this.label11.TabIndex = 143;
			this.label11.Text = "שם משפחה";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.MidnightBlue;
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(647, 3);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(163, 33);
			this.label12.TabIndex = 142;
			this.label12.Text = "תפקיד";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridJobs
			// 
			this.dataGridJobs.AllowUserToResizeColumns = false;
			this.dataGridJobs.AllowUserToResizeRows = false;
			this.dataGridJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridJobs.ColumnHeadersVisible = false;
			this.dataGridJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.Role,
            this.PhoneNumber,
            this.Email,
            this.Accept,
            this.Reject});
			this.dataGridJobs.Location = new System.Drawing.Point(164, 39);
			this.dataGridJobs.Name = "dataGridJobs";
			this.dataGridJobs.ReadOnly = true;
			this.dataGridJobs.RowHeadersVisible = false;
			this.dataGridJobs.Size = new System.Drawing.Size(961, 678);
			this.dataGridJobs.TabIndex = 0;
			this.dataGridJobs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridJobs_CellContentClick);
			// 
			// tabPageOptions
			// 
			this.tabPageOptions.Controls.Add(this.textLimitation);
			this.tabPageOptions.Controls.Add(this.textGuideLine);
			this.tabPageOptions.Controls.Add(this.label2);
			this.tabPageOptions.Controls.Add(this.label3);
			this.tabPageOptions.Controls.Add(this.btnUpdate);
			this.tabPageOptions.Controls.Add(this.label4);
			this.tabPageOptions.Controls.Add(this.label5);
			this.tabPageOptions.Controls.Add(this.label6);
			this.tabPageOptions.Controls.Add(this.label7);
			this.tabPageOptions.Controls.Add(this.dataGridOptions);
			this.tabPageOptions.Location = new System.Drawing.Point(4, 22);
			this.tabPageOptions.Name = "tabPageOptions";
			this.tabPageOptions.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageOptions.Size = new System.Drawing.Size(1131, 723);
			this.tabPageOptions.TabIndex = 1;
			this.tabPageOptions.Text = "הגדרת נהלים";
			this.tabPageOptions.UseVisualStyleBackColor = true;
			// 
			// textLimitation
			// 
			this.textLimitation.Location = new System.Drawing.Point(918, 29);
			this.textLimitation.Name = "textLimitation";
			this.textLimitation.Size = new System.Drawing.Size(100, 20);
			this.textLimitation.TabIndex = 156;
			// 
			// textGuideLine
			// 
			this.textGuideLine.Location = new System.Drawing.Point(918, 3);
			this.textGuideLine.Name = "textGuideLine";
			this.textGuideLine.Size = new System.Drawing.Size(100, 20);
			this.textGuideLine.TabIndex = 155;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(1023, 3);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 20);
			this.label2.TabIndex = 154;
			this.label2.Text = "מס\' הנחייה";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(1023, 29);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 20);
			this.label3.TabIndex = 153;
			this.label3.Text = "הגבלת שעות";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.MidnightBlue;
			this.btnUpdate.ForeColor = System.Drawing.Color.White;
			this.btnUpdate.Location = new System.Drawing.Point(789, 5);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(124, 34);
			this.btnUpdate.TabIndex = 152;
			this.btnUpdate.Text = "עדכן";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.MidnightBlue;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(1045, 52);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 33);
			this.label4.TabIndex = 151;
			this.label4.Text = "מס\' הנחייה";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.MidnightBlue;
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(824, 52);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(217, 33);
			this.label5.TabIndex = 150;
			this.label5.Text = "שם הנחייה";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.MidnightBlue;
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(113, 52);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(707, 33);
			this.label6.TabIndex = 149;
			this.label6.Text = "תיאור הנחייה";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.MidnightBlue;
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(6, 52);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(103, 33);
			this.label7.TabIndex = 148;
			this.label7.Text = "הגבלת שעות";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridOptions
			// 
			this.dataGridOptions.AllowUserToAddRows = false;
			this.dataGridOptions.AllowUserToDeleteRows = false;
			this.dataGridOptions.AllowUserToResizeColumns = false;
			this.dataGridOptions.AllowUserToResizeRows = false;
			this.dataGridOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridOptions.ColumnHeadersVisible = false;
			this.dataGridOptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GuideLineNumber,
            this.GuideLineName,
            this.Description,
            this.Limitation});
			this.dataGridOptions.Location = new System.Drawing.Point(6, 88);
			this.dataGridOptions.Name = "dataGridOptions";
			this.dataGridOptions.ReadOnly = true;
			this.dataGridOptions.RowHeadersVisible = false;
			this.dataGridOptions.Size = new System.Drawing.Size(1119, 629);
			this.dataGridOptions.TabIndex = 0;
			this.dataGridOptions.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOptions_CellContentDoubleClick);
			// 
			// GuideLineNumber
			// 
			this.GuideLineNumber.HeaderText = "מס\' הנחייה";
			this.GuideLineNumber.Name = "GuideLineNumber";
			this.GuideLineNumber.ReadOnly = true;
			this.GuideLineNumber.Width = 81;
			// 
			// GuideLineName
			// 
			this.GuideLineName.HeaderText = "שם הנחייה";
			this.GuideLineName.Name = "GuideLineName";
			this.GuideLineName.ReadOnly = true;
			this.GuideLineName.Width = 221;
			// 
			// Description
			// 
			this.Description.HeaderText = "תיאור הנחייה";
			this.Description.Name = "Description";
			this.Description.ReadOnly = true;
			this.Description.Width = 711;
			// 
			// Limitation
			// 
			this.Limitation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Limitation.HeaderText = "הגבלת שעות";
			this.Limitation.Name = "Limitation";
			this.Limitation.ReadOnly = true;
			// 
			// ID
			// 
			this.ID.HeaderText = "ת\"ז";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 79;
			// 
			// FirstName
			// 
			this.FirstName.HeaderText = "שם";
			this.FirstName.Name = "FirstName";
			this.FirstName.ReadOnly = true;
			this.FirstName.Width = 94;
			// 
			// LastName
			// 
			this.LastName.HeaderText = "שם משפחה";
			this.LastName.Name = "LastName";
			this.LastName.ReadOnly = true;
			this.LastName.Width = 137;
			// 
			// Role
			// 
			this.Role.HeaderText = "תפקיד";
			this.Role.Name = "Role";
			this.Role.ReadOnly = true;
			this.Role.Width = 167;
			// 
			// PhoneNumber
			// 
			this.PhoneNumber.HeaderText = "מס\' טלפון";
			this.PhoneNumber.Name = "PhoneNumber";
			this.PhoneNumber.ReadOnly = true;
			this.PhoneNumber.Width = 159;
			// 
			// Email
			// 
			this.Email.HeaderText = "אימייל";
			this.Email.Name = "Email";
			this.Email.ReadOnly = true;
			this.Email.Width = 159;
			// 
			// Accept
			// 
			this.Accept.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Accept.HeaderText = "התקבל";
			this.Accept.Name = "Accept";
			this.Accept.ReadOnly = true;
			this.Accept.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Accept.Text = "התקבל";
			this.Accept.UseColumnTextForButtonValue = true;
			// 
			// Reject
			// 
			this.Reject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Reject.HeaderText = "לא התקבל";
			this.Reject.Name = "Reject";
			this.Reject.ReadOnly = true;
			this.Reject.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Reject.Text = "לא התקבל";
			this.Reject.UseColumnTextForButtonValue = true;
			// 
			// mainCEO
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1279, 709);
			this.ControlBox = false;
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "mainCEO";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.mainCEO_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPageJob.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridJobs)).EndInit();
			this.tabPageOptions.ResumeLayout(false);
			this.tabPageOptions.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridOptions)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thisForm;
        private System.Windows.Forms.ToolStripMenuItem listOfCarsToBeApproved;
        private System.Windows.Forms.ToolStripMenuItem listOfMeetings;
        private System.Windows.Forms.ToolStripMenuItem exceptionList;
        private System.Windows.Forms.ToolStripMenuItem monthlyExceptionsHours;
		private System.Windows.Forms.ToolStripMenuItem btnExitAccount;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageJob;
		private System.Windows.Forms.TabPage tabPageOptions;
		private System.Windows.Forms.DataGridView dataGridJobs;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dataGridOptions;
		private System.Windows.Forms.TextBox textLimitation;
		private System.Windows.Forms.TextBox textGuideLine;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.DataGridViewTextBoxColumn GuideLineNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn GuideLineName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.DataGridViewTextBoxColumn Limitation;
        private System.Windows.Forms.ToolStripMenuItem WorkCar;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Role;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
		private System.Windows.Forms.DataGridViewButtonColumn Accept;
		private System.Windows.Forms.DataGridViewButtonColumn Reject;
	}
}