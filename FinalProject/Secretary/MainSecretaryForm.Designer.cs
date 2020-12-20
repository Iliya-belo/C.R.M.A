namespace FinalProject
{
    partial class SecretaryMenu
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
			this.addEmployee = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.addCar = new System.Windows.Forms.ToolStripMenuItem();
			this.addFault = new System.Windows.Forms.ToolStripMenuItem();
			this.קביעתפגישותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.רשימתרכבימכירהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.updateEmployee = new System.Windows.Forms.ToolStripMenuItem();
			this.exitAccount = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.garageTab = new System.Windows.Forms.TabPage();
			this.Find = new System.Windows.Forms.Button();
			this.dataGridGarage = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.ChooseBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.FindTable = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.costumerTab = new System.Windows.Forms.TabPage();
			this.search = new System.Windows.Forms.Button();
			this.dataGridCostumer = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label8 = new System.Windows.Forms.Label();
			this.box = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.valueLable = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.License = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Manufacture_Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Milege = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.daysInGarage = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.parkingPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.garageTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridGarage)).BeginInit();
			this.costumerTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCostumer)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.MidnightBlue;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployee,
            this.toolStripMenuItem2,
            this.addCar,
            this.addFault,
            this.קביעתפגישותToolStripMenuItem,
            this.רשימתרכבימכירהToolStripMenuItem,
            this.toolStripMenuItem1,
            this.updateEmployee,
            this.exitAccount});
			this.menuStrip1.Location = new System.Drawing.Point(1144, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(146, 810);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// addEmployee
			// 
			this.addEmployee.ForeColor = System.Drawing.Color.White;
			this.addEmployee.Name = "addEmployee";
			this.addEmployee.Size = new System.Drawing.Size(137, 19);
			this.addEmployee.Text = "הוספת עובד";
			this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(137, 19);
			this.toolStripMenuItem2.Text = "שינוי מטרת הרכב";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
			// 
			// addCar
			// 
			this.addCar.ForeColor = System.Drawing.Color.White;
			this.addCar.Name = "addCar";
			this.addCar.Size = new System.Drawing.Size(137, 19);
			this.addCar.Text = "הוספת רכב";
			this.addCar.Click += new System.EventHandler(this.addCar_Click);
			// 
			// addFault
			// 
			this.addFault.ForeColor = System.Drawing.Color.White;
			this.addFault.Name = "addFault";
			this.addFault.Size = new System.Drawing.Size(137, 19);
			this.addFault.Text = "פתיחת תקלה";
			this.addFault.Click += new System.EventHandler(this.addFault_Click);
			// 
			// קביעתפגישותToolStripMenuItem
			// 
			this.קביעתפגישותToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.קביעתפגישותToolStripMenuItem.Name = "קביעתפגישותToolStripMenuItem";
			this.קביעתפגישותToolStripMenuItem.Size = new System.Drawing.Size(137, 19);
			this.קביעתפגישותToolStripMenuItem.Text = "קביעת פגישות";
			this.קביעתפגישותToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemMetting_Click);
			// 
			// רשימתרכבימכירהToolStripMenuItem
			// 
			this.רשימתרכבימכירהToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.רשימתרכבימכירהToolStripMenuItem.Name = "רשימתרכבימכירהToolStripMenuItem";
			this.רשימתרכבימכירהToolStripMenuItem.Size = new System.Drawing.Size(137, 19);
			this.רשימתרכבימכירהToolStripMenuItem.Text = "רשימת רכבי מכירה";
			this.רשימתרכבימכירהToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(137, 19);
			this.toolStripMenuItem1.Text = "תשלום לקוחות על תיקון";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// updateEmployee
			// 
			this.updateEmployee.ForeColor = System.Drawing.Color.White;
			this.updateEmployee.Name = "updateEmployee";
			this.updateEmployee.Size = new System.Drawing.Size(137, 19);
			this.updateEmployee.Text = "עדכון פרטי העובד";
			this.updateEmployee.Click += new System.EventHandler(this.updateEmployee_Click);
			// 
			// exitAccount
			// 
			this.exitAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.exitAccount.ForeColor = System.Drawing.Color.White;
			this.exitAccount.Name = "exitAccount";
			this.exitAccount.Size = new System.Drawing.Size(137, 19);
			this.exitAccount.Text = "התנתק";
			this.exitAccount.Click += new System.EventHandler(this.exitAccount_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.garageTab);
			this.tabControl1.Controls.Add(this.costumerTab);
			this.tabControl1.Location = new System.Drawing.Point(6, 11);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tabControl1.RightToLeftLayout = true;
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1140, 792);
			this.tabControl1.TabIndex = 1;
			// 
			// garageTab
			// 
			this.garageTab.Controls.Add(this.Find);
			this.garageTab.Controls.Add(this.dataGridGarage);
			this.garageTab.Controls.Add(this.label2);
			this.garageTab.Controls.Add(this.ChooseBox);
			this.garageTab.Controls.Add(this.label3);
			this.garageTab.Controls.Add(this.FindTable);
			this.garageTab.Controls.Add(this.label4);
			this.garageTab.Controls.Add(this.label5);
			this.garageTab.Controls.Add(this.label6);
			this.garageTab.Controls.Add(this.label7);
			this.garageTab.Location = new System.Drawing.Point(4, 22);
			this.garageTab.Margin = new System.Windows.Forms.Padding(2);
			this.garageTab.Name = "garageTab";
			this.garageTab.Padding = new System.Windows.Forms.Padding(2);
			this.garageTab.Size = new System.Drawing.Size(1132, 766);
			this.garageTab.TabIndex = 0;
			this.garageTab.Text = "במגרש";
			this.garageTab.UseVisualStyleBackColor = true;
			// 
			// Find
			// 
			this.Find.Location = new System.Drawing.Point(4, 4);
			this.Find.Margin = new System.Windows.Forms.Padding(2);
			this.Find.Name = "Find";
			this.Find.Size = new System.Drawing.Size(140, 19);
			this.Find.TabIndex = 28;
			this.Find.Text = "Search";
			this.Find.UseVisualStyleBackColor = true;
			this.Find.Click += new System.EventHandler(this.Find_Click);
			// 
			// dataGridGarage
			// 
			this.dataGridGarage.AllowUserToResizeColumns = false;
			this.dataGridGarage.AllowUserToResizeRows = false;
			this.dataGridGarage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridGarage.ColumnHeadersVisible = false;
			this.dataGridGarage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.License,
            this.Manufacture_Model,
            this.Milege,
            this.daysInGarage,
            this.parkingPlace,
            this.comments});
			this.dataGridGarage.Location = new System.Drawing.Point(4, 63);
			this.dataGridGarage.Name = "dataGridGarage";
			this.dataGridGarage.ReadOnly = true;
			this.dataGridGarage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dataGridGarage.RowHeadersVisible = false;
			this.dataGridGarage.RowHeadersWidth = 62;
			this.dataGridGarage.Size = new System.Drawing.Size(1123, 698);
			this.dataGridGarage.TabIndex = 27;
			this.dataGridGarage.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridGarage_CellDoubleClick);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.MidnightBlue;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(752, 27);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(188, 33);
			this.label2.TabIndex = 22;
			this.label2.Text = "יצרן/דגם";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ChooseBox
			// 
			this.ChooseBox.FormattingEnabled = true;
			this.ChooseBox.Items.AddRange(new object[] {
            "רישוי",
            "יצרן/דגם",
            "קילומטראז\'",
            "ימים במגרש",
            "מס\' חנייה",
            "הכל",
            "רכבי מכירה",
            "רכבי השכרה"});
			this.ChooseBox.Location = new System.Drawing.Point(944, 4);
			this.ChooseBox.Margin = new System.Windows.Forms.Padding(2);
			this.ChooseBox.Name = "ChooseBox";
			this.ChooseBox.Size = new System.Drawing.Size(184, 21);
			this.ChooseBox.TabIndex = 26;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.MidnightBlue;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(4, 27);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(188, 33);
			this.label3.TabIndex = 18;
			this.label3.Text = "הערות";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FindTable
			// 
			this.FindTable.Location = new System.Drawing.Point(149, 4);
			this.FindTable.Margin = new System.Windows.Forms.Padding(2);
			this.FindTable.Name = "FindTable";
			this.FindTable.Size = new System.Drawing.Size(791, 20);
			this.FindTable.TabIndex = 25;
			this.FindTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.MidnightBlue;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(190, 27);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(188, 33);
			this.label4.TabIndex = 19;
			this.label4.Text = "מס\' חנייה";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.MidnightBlue;
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(939, 27);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(189, 33);
			this.label5.TabIndex = 23;
			this.label5.Text = "רישוי";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.MidnightBlue;
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(378, 27);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(188, 33);
			this.label6.TabIndex = 20;
			this.label6.Text = "ימים במגרש";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.MidnightBlue;
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(565, 27);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(187, 33);
			this.label7.TabIndex = 21;
			this.label7.Text = "\'קילומטראז";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// costumerTab
			// 
			this.costumerTab.Controls.Add(this.search);
			this.costumerTab.Controls.Add(this.dataGridCostumer);
			this.costumerTab.Controls.Add(this.label8);
			this.costumerTab.Controls.Add(this.box);
			this.costumerTab.Controls.Add(this.label9);
			this.costumerTab.Controls.Add(this.valueLable);
			this.costumerTab.Controls.Add(this.label10);
			this.costumerTab.Controls.Add(this.label11);
			this.costumerTab.Controls.Add(this.label12);
			this.costumerTab.Controls.Add(this.label13);
			this.costumerTab.Location = new System.Drawing.Point(4, 22);
			this.costumerTab.Margin = new System.Windows.Forms.Padding(2);
			this.costumerTab.Name = "costumerTab";
			this.costumerTab.Padding = new System.Windows.Forms.Padding(2);
			this.costumerTab.Size = new System.Drawing.Size(1132, 766);
			this.costumerTab.TabIndex = 1;
			this.costumerTab.Text = "אצל לקוח";
			this.costumerTab.UseVisualStyleBackColor = true;
			// 
			// search
			// 
			this.search.Location = new System.Drawing.Point(5, 5);
			this.search.Margin = new System.Windows.Forms.Padding(2);
			this.search.Name = "search";
			this.search.Size = new System.Drawing.Size(140, 19);
			this.search.TabIndex = 29;
			this.search.Text = "Search";
			this.search.UseVisualStyleBackColor = true;
			this.search.Click += new System.EventHandler(this.search_Click);
			// 
			// dataGridCostumer
			// 
			this.dataGridCostumer.AllowUserToResizeColumns = false;
			this.dataGridCostumer.AllowUserToResizeRows = false;
			this.dataGridCostumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridCostumer.ColumnHeadersVisible = false;
			this.dataGridCostumer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.dataGridCostumer.Location = new System.Drawing.Point(5, 63);
			this.dataGridCostumer.Name = "dataGridCostumer";
			this.dataGridCostumer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dataGridCostumer.RowHeadersVisible = false;
			this.dataGridCostumer.RowHeadersWidth = 62;
			this.dataGridCostumer.Size = new System.Drawing.Size(1123, 650);
			this.dataGridCostumer.TabIndex = 28;
			this.dataGridCostumer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCostumer_CellDoubleClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.HeaderText = "רישוי";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.HeaderText = "יצרן/דגם";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.HeaderText = "קילומטראז\'";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.HeaderText = "שם לקוח";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn5.HeaderText = "מס\' טלפון";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn6.HeaderText = "תאריך טסט";
			this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.MidnightBlue;
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(752, 27);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(188, 33);
			this.label8.TabIndex = 13;
			this.label8.Text = "יצרן/דגם";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// box
			// 
			this.box.FormattingEnabled = true;
			this.box.Items.AddRange(new object[] {
            "רישוי",
            "יצרן/דגם",
            "קילומטראז\'",
            "שם הלקוח",
            "מס\' טלפון"});
			this.box.Location = new System.Drawing.Point(944, 4);
			this.box.Margin = new System.Windows.Forms.Padding(2);
			this.box.Name = "box";
			this.box.Size = new System.Drawing.Size(184, 21);
			this.box.TabIndex = 17;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.MidnightBlue;
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(4, 27);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(188, 33);
			this.label9.TabIndex = 9;
			this.label9.Text = "תאריך טסט";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// valueLable
			// 
			this.valueLable.Location = new System.Drawing.Point(149, 4);
			this.valueLable.Margin = new System.Windows.Forms.Padding(2);
			this.valueLable.Name = "valueLable";
			this.valueLable.Size = new System.Drawing.Size(791, 20);
			this.valueLable.TabIndex = 16;
			this.valueLable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.MidnightBlue;
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(190, 27);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(188, 33);
			this.label10.TabIndex = 10;
			this.label10.Text = "מס\' טלפון";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.MidnightBlue;
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(939, 27);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(189, 33);
			this.label11.TabIndex = 14;
			this.label11.Text = "רישוי";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.MidnightBlue;
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(378, 27);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(188, 33);
			this.label12.TabIndex = 11;
			this.label12.Text = "שם הלקוח";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.MidnightBlue;
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(565, 27);
			this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(187, 33);
			this.label13.TabIndex = 12;
			this.label13.Text = "\'קילומטראז";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// SecretaryMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1290, 810);
			this.ControlBox = false;
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SecretaryMenu";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.SecretaryMenu_Load);
			this.Enter += new System.EventHandler(this.SecretaryMenu_Enter);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.garageTab.ResumeLayout(false);
			this.garageTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridGarage)).EndInit();
			this.costumerTab.ResumeLayout(false);
			this.costumerTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCostumer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addEmployee;
        private System.Windows.Forms.ToolStripMenuItem addCar;
        private System.Windows.Forms.ToolStripMenuItem addFault;
        private System.Windows.Forms.ToolStripMenuItem קביעתפגישותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem רשימתרכבימכירהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployee;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage garageTab;
        private System.Windows.Forms.TabPage costumerTab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox valueLable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ChooseBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FindTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dataGridGarage;
		private System.Windows.Forms.ToolStripMenuItem exitAccount;
        private System.Windows.Forms.Button Find;
		private System.Windows.Forms.DataGridView dataGridCostumer;
		private System.Windows.Forms.Button search;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.DataGridViewTextBoxColumn License;
		private System.Windows.Forms.DataGridViewTextBoxColumn Manufacture_Model;
		private System.Windows.Forms.DataGridViewTextBoxColumn Milege;
		private System.Windows.Forms.DataGridViewTextBoxColumn daysInGarage;
		private System.Windows.Forms.DataGridViewTextBoxColumn parkingPlace;
		private System.Windows.Forms.DataGridViewTextBoxColumn comments;
	}
}

