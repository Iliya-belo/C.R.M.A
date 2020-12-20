namespace FinalProject.Tester_SafetyManager
{
    partial class listOfRepairedCars
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
			this.thisForm = new System.Windows.Forms.ToolStripMenuItem();
			this.updateRepairedParts = new System.Windows.Forms.ToolStripMenuItem();
			this.carToGarage = new System.Windows.Forms.ToolStripMenuItem();
			this.monthlyExceptionsHours = new System.Windows.Forms.ToolStripMenuItem();
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
			this.GarageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CurrentActivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DaysOfState = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LotPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ConponentStatusToOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ComponentStatusReady = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label19 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.textDaysOfState = new System.Windows.Forms.TextBox();
			this.textBrandAndModel = new System.Windows.Forms.TextBox();
			this.textEventNumber = new System.Windows.Forms.TextBox();
			this.textLicenseNumber = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.comboGarageID = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textReadyDays = new System.Windows.Forms.TextBox();
			this.checkReadyDays = new System.Windows.Forms.CheckBox();
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
            this.TSMMain,
            this.thisForm,
            this.updateRepairedParts,
            this.carToGarage,
            this.monthlyExceptionsHours,
            this.btnExitAccount});
			this.menuStrip1.Location = new System.Drawing.Point(1128, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(156, 781);
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
			// thisForm
			// 
			this.thisForm.BackColor = System.Drawing.Color.MidnightBlue;
			this.thisForm.Enabled = false;
			this.thisForm.ForeColor = System.Drawing.Color.White;
			this.thisForm.Name = "thisForm";
			this.thisForm.Size = new System.Drawing.Size(151, 19);
			this.thisForm.Text = "רשימת רכבים בתיקון";
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
			// carToGarage
			// 
			this.carToGarage.BackColor = System.Drawing.Color.MidnightBlue;
			this.carToGarage.ForeColor = System.Drawing.Color.White;
			this.carToGarage.Name = "carToGarage";
			this.carToGarage.Size = new System.Drawing.Size(151, 19);
			this.carToGarage.Text = "הכנסת רכב למוסך";
			this.carToGarage.Click += new System.EventHandler(this.carToGarage_Click);
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
			// labelEvent
			// 
			this.labelEvent.BackColor = System.Drawing.Color.MidnightBlue;
			this.labelEvent.ForeColor = System.Drawing.Color.White;
			this.labelEvent.Location = new System.Drawing.Point(1047, 239);
			this.labelEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelEvent.Name = "labelEvent";
			this.labelEvent.Size = new System.Drawing.Size(81, 33);
			this.labelEvent.TabIndex = 143;
			this.labelEvent.Text = "אירוע";
			this.labelEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.MidnightBlue;
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(953, 239);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(90, 33);
			this.label8.TabIndex = 141;
			this.label8.Text = "רישוי";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.MidnightBlue;
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(854, 239);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(95, 33);
			this.label7.TabIndex = 140;
			this.label7.Text = "יצרן ודגם";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.MidnightBlue;
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(649, 239);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(201, 33);
			this.label6.TabIndex = 139;
			this.label6.Text = "שם מוסך";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.MidnightBlue;
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(332, 239);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(313, 33);
			this.label5.TabIndex = 138;
			this.label5.Text = "פעילות נוכחית";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.MidnightBlue;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(260, 239);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 33);
			this.label4.TabIndex = 137;
			this.label4.Text = "ימי עמידה";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.MidnightBlue;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(190, 239);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 33);
			this.label3.TabIndex = 136;
			this.label3.Text = "ימי עמידה לתנועה";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.MidnightBlue;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(112, 239);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 33);
			this.label2.TabIndex = 135;
			this.label2.Text = "מצב מרכיבים";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.MidnightBlue;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(11, 239);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 33);
			this.label1.TabIndex = 134;
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
            this.GarageName,
            this.CurrentActivity,
            this.DaysOfState,
            this.LotPhone,
            this.ConponentStatusToOrder,
            this.ComponentStatusReady});
			this.dataGridEvents.Location = new System.Drawing.Point(11, 275);
			this.dataGridEvents.Name = "dataGridEvents";
			this.dataGridEvents.ReadOnly = true;
			this.dataGridEvents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dataGridEvents.RowHeadersVisible = false;
			this.dataGridEvents.Size = new System.Drawing.Size(1117, 494);
			this.dataGridEvents.TabIndex = 152;
			this.dataGridEvents.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridEvents_CellMouseDoubleClick);
			// 
			// EventNumber1
			// 
			this.EventNumber1.HeaderText = "מס\' אירוע";
			this.EventNumber1.Name = "EventNumber1";
			this.EventNumber1.ReadOnly = true;
			this.EventNumber1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.EventNumber1.Width = 83;
			// 
			// LicenseNumber1
			// 
			this.LicenseNumber1.HeaderText = "רישוי";
			this.LicenseNumber1.Name = "LicenseNumber1";
			this.LicenseNumber1.ReadOnly = true;
			this.LicenseNumber1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.LicenseNumber1.Width = 92;
			// 
			// BrandModel1
			// 
			this.BrandModel1.HeaderText = "יצרן/דגם";
			this.BrandModel1.Name = "BrandModel1";
			this.BrandModel1.ReadOnly = true;
			this.BrandModel1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.BrandModel1.Width = 99;
			// 
			// GarageName
			// 
			this.GarageName.HeaderText = "שם מוסך";
			this.GarageName.Name = "GarageName";
			this.GarageName.ReadOnly = true;
			this.GarageName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.GarageName.Width = 205;
			// 
			// CurrentActivity
			// 
			this.CurrentActivity.HeaderText = "פעילות נוכחית";
			this.CurrentActivity.Name = "CurrentActivity";
			this.CurrentActivity.ReadOnly = true;
			this.CurrentActivity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.CurrentActivity.Width = 317;
			// 
			// DaysOfState
			// 
			this.DaysOfState.HeaderText = "ימי עמידה";
			this.DaysOfState.Name = "DaysOfState";
			this.DaysOfState.ReadOnly = true;
			this.DaysOfState.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.DaysOfState.Width = 72;
			// 
			// LotPhone
			// 
			this.LotPhone.HeaderText = "מס\' טלפון של המוסך";
			this.LotPhone.Name = "LotPhone";
			this.LotPhone.ReadOnly = true;
			this.LotPhone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.LotPhone.Width = 70;
			// 
			// ConponentStatusToOrder
			// 
			this.ConponentStatusToOrder.HeaderText = "מצב רכיבים";
			this.ConponentStatusToOrder.Name = "ConponentStatusToOrder";
			this.ConponentStatusToOrder.ReadOnly = true;
			this.ConponentStatusToOrder.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ConponentStatusToOrder.Width = 79;
			// 
			// ComponentStatusReady
			// 
			this.ComponentStatusReady.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ComponentStatusReady.HeaderText = "כמות זמינות פעילות";
			this.ComponentStatusReady.Name = "ComponentStatusReady";
			this.ComponentStatusReady.ReadOnly = true;
			this.ComponentStatusReady.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.MidnightBlue;
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(845, 197);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(81, 23);
			this.btnSearch.TabIndex = 164;
			this.btnSearch.Text = "חיפוש";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(1050, 149);
			this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(76, 20);
			this.label19.TabIndex = 163;
			this.label19.Text = "ימי עמידה";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(1058, 124);
			this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(68, 20);
			this.label17.TabIndex = 162;
			this.label17.Text = "מס\' מוסך";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(1052, 48);
			this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(74, 20);
			this.label16.TabIndex = 161;
			this.label16.Text = "מס\' אירוע";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(1053, 96);
			this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(73, 20);
			this.label15.TabIndex = 160;
			this.label15.Text = "יצרן ודגם";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(1082, 72);
			this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(44, 20);
			this.label14.TabIndex = 159;
			this.label14.Text = "רישוי";
			// 
			// textDaysOfState
			// 
			this.textDaysOfState.Location = new System.Drawing.Point(845, 149);
			this.textDaysOfState.Margin = new System.Windows.Forms.Padding(2);
			this.textDaysOfState.Name = "textDaysOfState";
			this.textDaysOfState.Size = new System.Drawing.Size(149, 20);
			this.textDaysOfState.TabIndex = 158;
			this.textDaysOfState.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBrandAndModel
			// 
			this.textBrandAndModel.Location = new System.Drawing.Point(845, 98);
			this.textBrandAndModel.Margin = new System.Windows.Forms.Padding(2);
			this.textBrandAndModel.Name = "textBrandAndModel";
			this.textBrandAndModel.Size = new System.Drawing.Size(149, 20);
			this.textBrandAndModel.TabIndex = 156;
			this.textBrandAndModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textEventNumber
			// 
			this.textEventNumber.Location = new System.Drawing.Point(845, 50);
			this.textEventNumber.Margin = new System.Windows.Forms.Padding(2);
			this.textEventNumber.Name = "textEventNumber";
			this.textEventNumber.Size = new System.Drawing.Size(149, 20);
			this.textEventNumber.TabIndex = 155;
			this.textEventNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textLicenseNumber
			// 
			this.textLicenseNumber.Location = new System.Drawing.Point(845, 74);
			this.textLicenseNumber.Margin = new System.Windows.Forms.Padding(2);
			this.textLicenseNumber.Name = "textLicenseNumber";
			this.textLicenseNumber.Size = new System.Drawing.Size(149, 20);
			this.textLicenseNumber.TabIndex = 154;
			this.textLicenseNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
			this.label13.TabIndex = 153;
			this.label13.Text = "איתור מהיר";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboGarageID
			// 
			this.comboGarageID.FormattingEnabled = true;
			this.comboGarageID.Location = new System.Drawing.Point(845, 123);
			this.comboGarageID.Name = "comboGarageID";
			this.comboGarageID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.comboGarageID.Size = new System.Drawing.Size(149, 21);
			this.comboGarageID.TabIndex = 165;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(997, 173);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(129, 20);
			this.label9.TabIndex = 166;
			this.label9.Text = "ימי עמידה לתנועה";
			// 
			// textReadyDays
			// 
			this.textReadyDays.Location = new System.Drawing.Point(845, 173);
			this.textReadyDays.Margin = new System.Windows.Forms.Padding(2);
			this.textReadyDays.Name = "textReadyDays";
			this.textReadyDays.Size = new System.Drawing.Size(149, 20);
			this.textReadyDays.TabIndex = 167;
			this.textReadyDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// checkReadyDays
			// 
			this.checkReadyDays.AutoSize = true;
			this.checkReadyDays.Location = new System.Drawing.Point(1009, 201);
			this.checkReadyDays.Name = "checkReadyDays";
			this.checkReadyDays.Size = new System.Drawing.Size(116, 17);
			this.checkReadyDays.TabIndex = 168;
			this.checkReadyDays.Text = "רכב עומד לתנועה";
			this.checkReadyDays.UseVisualStyleBackColor = true;
			// 
			// listOfRepairedCars
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1284, 781);
			this.ControlBox = false;
			this.Controls.Add(this.checkReadyDays);
			this.Controls.Add(this.textReadyDays);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.comboGarageID);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.textDaysOfState);
			this.Controls.Add(this.textBrandAndModel);
			this.Controls.Add(this.textEventNumber);
			this.Controls.Add(this.textLicenseNumber);
			this.Controls.Add(this.label13);
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
			this.Name = "listOfRepairedCars";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.listOfRepairedCars_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridEvents)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label labelEvent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem TSMMain;
		private System.Windows.Forms.ToolStripMenuItem thisForm;
		private System.Windows.Forms.ToolStripMenuItem updateRepairedParts;
		private System.Windows.Forms.ToolStripMenuItem carToGarage;
		private System.Windows.Forms.ToolStripMenuItem monthlyExceptionsHours;
		private System.Windows.Forms.ToolStripMenuItem btnExitAccount;
		private System.Windows.Forms.DataGridView dataGridEvents;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textDaysOfState;
		private System.Windows.Forms.TextBox textBrandAndModel;
		private System.Windows.Forms.TextBox textEventNumber;
		private System.Windows.Forms.TextBox textLicenseNumber;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox comboGarageID;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textReadyDays;
		private System.Windows.Forms.CheckBox checkReadyDays;
		private System.Windows.Forms.DataGridViewTextBoxColumn EventNumber1;
		private System.Windows.Forms.DataGridViewTextBoxColumn LicenseNumber1;
		private System.Windows.Forms.DataGridViewTextBoxColumn BrandModel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn GarageName;
		private System.Windows.Forms.DataGridViewTextBoxColumn CurrentActivity;
		private System.Windows.Forms.DataGridViewTextBoxColumn DaysOfState;
		private System.Windows.Forms.DataGridViewTextBoxColumn LotPhone;
		private System.Windows.Forms.DataGridViewTextBoxColumn ConponentStatusToOrder;
		private System.Windows.Forms.DataGridViewTextBoxColumn ComponentStatusReady;
	}
}