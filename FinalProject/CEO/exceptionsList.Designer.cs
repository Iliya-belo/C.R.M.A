namespace FinalProject.CEO
{
    partial class exceptionsList
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
			this.listOfMeetings = new System.Windows.Forms.ToolStripMenuItem();
			this.thisForm = new System.Windows.Forms.ToolStripMenuItem();
			this.WorkCar = new System.Windows.Forms.ToolStripMenuItem();
			this.monthlyExecptionsHours = new System.Windows.Forms.ToolStripMenuItem();
			this.btnExitAccount = new System.Windows.Forms.ToolStripMenuItem();
			this.labelEvent = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridEvents = new System.Windows.Forms.DataGridView();
			this.EventNumber1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LicenseNumber1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BrandModel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CostumerName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CurrentActivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DaysOfState = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LotPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ConponentStatusToOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ComponentStatusReady = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textComponentStatusReady = new System.Windows.Forms.TextBox();
			this.textComponentStatusToOrder = new System.Windows.Forms.TextBox();
			this.textLicenseNumber = new System.Windows.Forms.TextBox();
			this.textBrandAndModel = new System.Windows.Forms.TextBox();
			this.textName = new System.Windows.Forms.TextBox();
			this.textCurrentActivity = new System.Windows.Forms.TextBox();
			this.textDaysOfState = new System.Windows.Forms.TextBox();
			this.textEventNumber = new System.Windows.Forms.TextBox();
			this.textGaragePhoneNumber = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridEvents)).BeginInit();
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
            this.listOfMeetings,
            this.thisForm,
            this.WorkCar,
            this.monthlyExecptionsHours,
            this.btnExitAccount});
			this.menuStrip1.Location = new System.Drawing.Point(1144, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(122, 786);
			this.menuStrip1.TabIndex = 2;
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
			// listOfMeetings
			// 
			this.listOfMeetings.BackColor = System.Drawing.Color.MidnightBlue;
			this.listOfMeetings.ForeColor = System.Drawing.Color.White;
			this.listOfMeetings.Name = "listOfMeetings";
			this.listOfMeetings.Size = new System.Drawing.Size(117, 19);
			this.listOfMeetings.Text = "רשימת אנשים לשיחה";
			this.listOfMeetings.Click += new System.EventHandler(this.listOfMeetings_Click);
			// 
			// thisForm
			// 
			this.thisForm.BackColor = System.Drawing.Color.MidnightBlue;
			this.thisForm.Enabled = false;
			this.thisForm.ForeColor = System.Drawing.Color.White;
			this.thisForm.Name = "thisForm";
			this.thisForm.Size = new System.Drawing.Size(117, 19);
			this.thisForm.Text = "רשימת רכבים במוסך";
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
			// monthlyExecptionsHours
			// 
			this.monthlyExecptionsHours.BackColor = System.Drawing.Color.MidnightBlue;
			this.monthlyExecptionsHours.ForeColor = System.Drawing.Color.White;
			this.monthlyExecptionsHours.Name = "monthlyExecptionsHours";
			this.monthlyExecptionsHours.Size = new System.Drawing.Size(117, 19);
			this.monthlyExecptionsHours.Text = "חריגות שעות במשימה";
			this.monthlyExecptionsHours.Click += new System.EventHandler(this.monthlyExecptionsHours_Click);
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
			// labelEvent
			// 
			this.labelEvent.BackColor = System.Drawing.Color.MidnightBlue;
			this.labelEvent.ForeColor = System.Drawing.Color.White;
			this.labelEvent.Location = new System.Drawing.Point(1047, 9);
			this.labelEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelEvent.Name = "labelEvent";
			this.labelEvent.Size = new System.Drawing.Size(88, 33);
			this.labelEvent.TabIndex = 47;
			this.labelEvent.Text = "אירוע";
			this.labelEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.MidnightBlue;
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(953, 9);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(90, 33);
			this.label8.TabIndex = 45;
			this.label8.Text = "רישוי";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.MidnightBlue;
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(854, 9);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(95, 33);
			this.label7.TabIndex = 44;
			this.label7.Text = "יצרן ודגם";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.MidnightBlue;
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(649, 9);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(201, 33);
			this.label6.TabIndex = 43;
			this.label6.Text = "שם לקוח/נהג";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.MidnightBlue;
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(332, 9);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(313, 33);
			this.label5.TabIndex = 42;
			this.label5.Text = "פעילות נוכחית";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.MidnightBlue;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(260, 9);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 33);
			this.label4.TabIndex = 41;
			this.label4.Text = "ימי עמידה";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.MidnightBlue;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(190, 9);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 33);
			this.label3.TabIndex = 40;
			this.label3.Text = "מס\' טלפון של מוסך";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.MidnightBlue;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(112, 9);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 33);
			this.label2.TabIndex = 39;
			this.label2.Text = "מצב מרכיבים";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.MidnightBlue;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(11, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 33);
			this.label1.TabIndex = 38;
			this.label1.Text = "כמות הזמנות פעילות";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridEvents
			// 
			this.dataGridEvents.AllowUserToResizeColumns = false;
			this.dataGridEvents.AllowUserToResizeRows = false;
			this.dataGridEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridEvents.ColumnHeadersVisible = false;
			this.dataGridEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventNumber1,
            this.LicenseNumber1,
            this.BrandModel1,
            this.CostumerName1,
            this.CurrentActivity,
            this.DaysOfState,
            this.LotPhone,
            this.ConponentStatusToOrder,
            this.ComponentStatusReady});
			this.dataGridEvents.Location = new System.Drawing.Point(11, 66);
			this.dataGridEvents.Name = "dataGridEvents";
			this.dataGridEvents.ReadOnly = true;
			this.dataGridEvents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dataGridEvents.RowHeadersVisible = false;
			this.dataGridEvents.Size = new System.Drawing.Size(1124, 695);
			this.dataGridEvents.TabIndex = 51;
			this.dataGridEvents.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEvents_CellContentDoubleClick);
			// 
			// EventNumber1
			// 
			this.EventNumber1.HeaderText = "מס\' אירוע";
			this.EventNumber1.Name = "EventNumber1";
			this.EventNumber1.ReadOnly = true;
			this.EventNumber1.Width = 88;
			// 
			// LicenseNumber1
			// 
			this.LicenseNumber1.HeaderText = "רישוי";
			this.LicenseNumber1.Name = "LicenseNumber1";
			this.LicenseNumber1.ReadOnly = true;
			this.LicenseNumber1.Width = 92;
			// 
			// BrandModel1
			// 
			this.BrandModel1.HeaderText = "יצרן/דגם";
			this.BrandModel1.Name = "BrandModel1";
			this.BrandModel1.ReadOnly = true;
			this.BrandModel1.Width = 99;
			// 
			// CostumerName1
			// 
			this.CostumerName1.HeaderText = "שם לקוח/נהג";
			this.CostumerName1.Name = "CostumerName1";
			this.CostumerName1.ReadOnly = true;
			this.CostumerName1.Width = 205;
			// 
			// CurrentActivity
			// 
			this.CurrentActivity.HeaderText = "פעילות נוכחית";
			this.CurrentActivity.Name = "CurrentActivity";
			this.CurrentActivity.ReadOnly = true;
			this.CurrentActivity.Width = 317;
			// 
			// DaysOfState
			// 
			this.DaysOfState.HeaderText = "ימי עמידה";
			this.DaysOfState.Name = "DaysOfState";
			this.DaysOfState.ReadOnly = true;
			this.DaysOfState.Width = 72;
			// 
			// LotPhone
			// 
			this.LotPhone.HeaderText = "מס\' טלפון של המוסך";
			this.LotPhone.Name = "LotPhone";
			this.LotPhone.ReadOnly = true;
			this.LotPhone.Width = 70;
			// 
			// ConponentStatusToOrder
			// 
			this.ConponentStatusToOrder.HeaderText = "מצב רכיבים";
			this.ConponentStatusToOrder.Name = "ConponentStatusToOrder";
			this.ConponentStatusToOrder.ReadOnly = true;
			this.ConponentStatusToOrder.Width = 79;
			// 
			// ComponentStatusReady
			// 
			this.ComponentStatusReady.HeaderText = "כמות זמינות פעילות";
			this.ComponentStatusReady.Name = "ComponentStatusReady";
			this.ComponentStatusReady.ReadOnly = true;
			this.ComponentStatusReady.Width = 99;
			// 
			// textComponentStatusReady
			// 
			this.textComponentStatusReady.Location = new System.Drawing.Point(11, 44);
			this.textComponentStatusReady.Margin = new System.Windows.Forms.Padding(2);
			this.textComponentStatusReady.Name = "textComponentStatusReady";
			this.textComponentStatusReady.Size = new System.Drawing.Size(97, 20);
			this.textComponentStatusReady.TabIndex = 59;
			this.textComponentStatusReady.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textComponentStatusReady.TextChanged += new System.EventHandler(this.textComponentStatusReady_TextChanged);
			// 
			// textComponentStatusToOrder
			// 
			this.textComponentStatusToOrder.Location = new System.Drawing.Point(110, 44);
			this.textComponentStatusToOrder.Margin = new System.Windows.Forms.Padding(2);
			this.textComponentStatusToOrder.Name = "textComponentStatusToOrder";
			this.textComponentStatusToOrder.Size = new System.Drawing.Size(77, 20);
			this.textComponentStatusToOrder.TabIndex = 60;
			this.textComponentStatusToOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textComponentStatusToOrder.TextChanged += new System.EventHandler(this.textComponentStatusToOrder_TextChanged);
			// 
			// textLicenseNumber
			// 
			this.textLicenseNumber.Location = new System.Drawing.Point(953, 44);
			this.textLicenseNumber.Margin = new System.Windows.Forms.Padding(2);
			this.textLicenseNumber.Name = "textLicenseNumber";
			this.textLicenseNumber.Size = new System.Drawing.Size(91, 20);
			this.textLicenseNumber.TabIndex = 58;
			this.textLicenseNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textLicenseNumber.TextChanged += new System.EventHandler(this.textLicenseNumber_TextChanged);
			// 
			// textBrandAndModel
			// 
			this.textBrandAndModel.Location = new System.Drawing.Point(854, 44);
			this.textBrandAndModel.Margin = new System.Windows.Forms.Padding(2);
			this.textBrandAndModel.Name = "textBrandAndModel";
			this.textBrandAndModel.Size = new System.Drawing.Size(96, 20);
			this.textBrandAndModel.TabIndex = 57;
			this.textBrandAndModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBrandAndModel.TextChanged += new System.EventHandler(this.textBrandAndModel_TextChanged);
			// 
			// textName
			// 
			this.textName.Location = new System.Drawing.Point(649, 44);
			this.textName.Margin = new System.Windows.Forms.Padding(2);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(203, 20);
			this.textName.TabIndex = 56;
			this.textName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
			// 
			// textCurrentActivity
			// 
			this.textCurrentActivity.Location = new System.Drawing.Point(332, 44);
			this.textCurrentActivity.Margin = new System.Windows.Forms.Padding(2);
			this.textCurrentActivity.Name = "textCurrentActivity";
			this.textCurrentActivity.Size = new System.Drawing.Size(315, 20);
			this.textCurrentActivity.TabIndex = 55;
			this.textCurrentActivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textCurrentActivity.TextChanged += new System.EventHandler(this.textCurrentActivity_TextChanged);
			// 
			// textDaysOfState
			// 
			this.textDaysOfState.Location = new System.Drawing.Point(260, 44);
			this.textDaysOfState.Margin = new System.Windows.Forms.Padding(2);
			this.textDaysOfState.Name = "textDaysOfState";
			this.textDaysOfState.Size = new System.Drawing.Size(69, 20);
			this.textDaysOfState.TabIndex = 54;
			this.textDaysOfState.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textDaysOfState.TextChanged += new System.EventHandler(this.textDaysOfState_TextChanged);
			// 
			// textEventNumber
			// 
			this.textEventNumber.Location = new System.Drawing.Point(1047, 44);
			this.textEventNumber.Margin = new System.Windows.Forms.Padding(2);
			this.textEventNumber.Name = "textEventNumber";
			this.textEventNumber.Size = new System.Drawing.Size(88, 20);
			this.textEventNumber.TabIndex = 52;
			this.textEventNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textEventNumber.TextChanged += new System.EventHandler(this.textEventNumber_TextChanged);
			// 
			// textGaragePhoneNumber
			// 
			this.textGaragePhoneNumber.Location = new System.Drawing.Point(191, 44);
			this.textGaragePhoneNumber.Margin = new System.Windows.Forms.Padding(2);
			this.textGaragePhoneNumber.Name = "textGaragePhoneNumber";
			this.textGaragePhoneNumber.Size = new System.Drawing.Size(65, 20);
			this.textGaragePhoneNumber.TabIndex = 63;
			// 
			// exceptionsList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1266, 786);
			this.ControlBox = false;
			this.Controls.Add(this.textGaragePhoneNumber);
			this.Controls.Add(this.textComponentStatusReady);
			this.Controls.Add(this.textComponentStatusToOrder);
			this.Controls.Add(this.textLicenseNumber);
			this.Controls.Add(this.textBrandAndModel);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.textCurrentActivity);
			this.Controls.Add(this.textDaysOfState);
			this.Controls.Add(this.textEventNumber);
			this.Controls.Add(this.dataGridEvents);
			this.Controls.Add(this.labelEvent);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "exceptionsList";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.exceptionsList_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridEvents)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thisForm;
        private System.Windows.Forms.Label labelEvent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem monthlyExecptionsHours;
		private System.Windows.Forms.ToolStripMenuItem btnExitAccount;
		private System.Windows.Forms.DataGridView dataGridEvents;
		private System.Windows.Forms.DataGridViewTextBoxColumn EventNumber1;
		private System.Windows.Forms.DataGridViewTextBoxColumn LicenseNumber1;
		private System.Windows.Forms.DataGridViewTextBoxColumn BrandModel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn CostumerName1;
		private System.Windows.Forms.DataGridViewTextBoxColumn CurrentActivity;
		private System.Windows.Forms.DataGridViewTextBoxColumn DaysOfState;
		private System.Windows.Forms.DataGridViewTextBoxColumn LotPhone;
		private System.Windows.Forms.DataGridViewTextBoxColumn ConponentStatusToOrder;
		private System.Windows.Forms.DataGridViewTextBoxColumn ComponentStatusReady;
		private System.Windows.Forms.ToolStripMenuItem mainCEO;
		private System.Windows.Forms.ToolStripMenuItem listOfCarsToBeApproved;
		private System.Windows.Forms.ToolStripMenuItem listOfMeetings;
		private System.Windows.Forms.TextBox textComponentStatusReady;
		private System.Windows.Forms.TextBox textComponentStatusToOrder;
		private System.Windows.Forms.TextBox textLicenseNumber;
		private System.Windows.Forms.TextBox textBrandAndModel;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.TextBox textCurrentActivity;
		private System.Windows.Forms.TextBox textDaysOfState;
		private System.Windows.Forms.TextBox textEventNumber;
        private System.Windows.Forms.ToolStripMenuItem WorkCar;
		private System.Windows.Forms.TextBox textGaragePhoneNumber;
	}
}