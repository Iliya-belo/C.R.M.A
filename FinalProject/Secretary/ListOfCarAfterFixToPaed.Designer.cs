namespace FinalProject.Secretary
{
    partial class ListOfCarAfterFixToPaed
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
			this.dataGridCostumers = new System.Windows.Forms.DataGridView();
			this.LicenseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BrandModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Milege = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CarDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Accept = new System.Windows.Forms.DataGridViewButtonColumn();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.IDCostumer = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.addEmployee = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.addCar = new System.Windows.Forms.ToolStripMenuItem();
			this.addFault = new System.Windows.Forms.ToolStripMenuItem();
			this.קביעתפגישותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.רשימתרכבימכירהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateEmployee = new System.Windows.Forms.ToolStripMenuItem();
			this.exitAccount = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.priceToByed = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCostumers)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridCostumers
			// 
			this.dataGridCostumers.AllowUserToResizeColumns = false;
			this.dataGridCostumers.AllowUserToResizeRows = false;
			this.dataGridCostumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridCostumers.ColumnHeadersVisible = false;
			this.dataGridCostumers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LicenseNumber,
            this.BrandModel,
            this.Milege,
            this.CarDescription,
            this.Price,
            this.Color,
            this.Accept});
			this.dataGridCostumers.Location = new System.Drawing.Point(6, 233);
			this.dataGridCostumers.Name = "dataGridCostumers";
			this.dataGridCostumers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dataGridCostumers.RowHeadersVisible = false;
			this.dataGridCostumers.Size = new System.Drawing.Size(1112, 514);
			this.dataGridCostumers.TabIndex = 187;
			this.dataGridCostumers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCostumers_CellContentClick);
			// 
			// LicenseNumber
			// 
			this.LicenseNumber.HeaderText = "ת\"ז";
			this.LicenseNumber.Name = "LicenseNumber";
			this.LicenseNumber.ReadOnly = true;
			this.LicenseNumber.Width = 105;
			// 
			// BrandModel
			// 
			this.BrandModel.HeaderText = "שם";
			this.BrandModel.Name = "BrandModel";
			this.BrandModel.ReadOnly = true;
			this.BrandModel.Width = 145;
			// 
			// Milege
			// 
			this.Milege.HeaderText = "שם משפחה";
			this.Milege.Name = "Milege";
			this.Milege.ReadOnly = true;
			this.Milege.Width = 153;
			// 
			// CarDescription
			// 
			this.CarDescription.HeaderText = "כתובת";
			this.CarDescription.Name = "CarDescription";
			this.CarDescription.ReadOnly = true;
			this.CarDescription.Width = 204;
			// 
			// Price
			// 
			this.Price.HeaderText = "מספר טלפון";
			this.Price.Name = "Price";
			this.Price.ReadOnly = true;
			this.Price.Width = 159;
			// 
			// Color
			// 
			this.Color.HeaderText = "מחיר";
			this.Color.Name = "Color";
			this.Color.ReadOnly = true;
			this.Color.Width = 180;
			// 
			// Accept
			// 
			this.Accept.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Accept.HeaderText = "תשלום";
			this.Accept.Name = "Accept";
			this.Accept.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Accept.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Accept.Text = "תשלום";
			this.Accept.UseColumnTextForButtonValue = true;
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.MidnightBlue;
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(833, 104);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(81, 23);
			this.btnSearch.TabIndex = 186;
			this.btnSearch.Text = "חיפוש";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(1030, 45);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 20);
			this.label5.TabIndex = 182;
			this.label5.Text = "ת\"ז של לקוח";
			// 
			// IDCostumer
			// 
			this.IDCostumer.Location = new System.Drawing.Point(833, 45);
			this.IDCostumer.Margin = new System.Windows.Forms.Padding(2);
			this.IDCostumer.Name = "IDCostumer";
			this.IDCostumer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.IDCostumer.Size = new System.Drawing.Size(149, 20);
			this.IDCostumer.TabIndex = 178;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.OrangeRed;
			this.label6.Location = new System.Drawing.Point(831, 0);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(287, 39);
			this.label6.TabIndex = 177;
			this.label6.Text = "איתור מהיר";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.MidnightBlue;
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(170, 197);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(177, 33);
			this.label10.TabIndex = 176;
			this.label10.Text = "מחיר";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.MidnightBlue;
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(351, 197);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(155, 33);
			this.label11.TabIndex = 175;
			this.label11.Text = "מספר טלפון";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.MidnightBlue;
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(715, 197);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(149, 33);
			this.label12.TabIndex = 174;
			this.label12.Text = "שם משפחה";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.MidnightBlue;
			this.label18.ForeColor = System.Drawing.Color.White;
			this.label18.Location = new System.Drawing.Point(1015, 197);
			this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(103, 33);
			this.label18.TabIndex = 173;
			this.label18.Text = "ת\"ז";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.MidnightBlue;
			this.label19.ForeColor = System.Drawing.Color.White;
			this.label19.Location = new System.Drawing.Point(868, 197);
			this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(143, 33);
			this.label19.TabIndex = 172;
			this.label19.Text = "שם";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.MidnightBlue;
			this.label24.ForeColor = System.Drawing.Color.White;
			this.label24.Location = new System.Drawing.Point(510, 197);
			this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(201, 33);
			this.label24.TabIndex = 171;
			this.label24.Text = "כתובת";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.MidnightBlue;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.addEmployee,
            this.toolStripMenuItem2,
            this.addCar,
            this.addFault,
            this.קביעתפגישותToolStripMenuItem,
            this.רשימתרכבימכירהToolStripMenuItem,
            this.updateEmployee,
            this.exitAccount});
			this.menuStrip1.Location = new System.Drawing.Point(1148, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(122, 744);
			this.menuStrip1.TabIndex = 188;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(113, 19);
			this.toolStripMenuItem1.Text = "מסח ראשי";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// addEmployee
			// 
			this.addEmployee.ForeColor = System.Drawing.Color.White;
			this.addEmployee.Name = "addEmployee";
			this.addEmployee.Size = new System.Drawing.Size(113, 19);
			this.addEmployee.Text = "הוספת עובד";
			this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(113, 19);
			this.toolStripMenuItem2.Text = "שינוי מטרת הרכב";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
			// 
			// addCar
			// 
			this.addCar.ForeColor = System.Drawing.Color.White;
			this.addCar.Name = "addCar";
			this.addCar.Size = new System.Drawing.Size(113, 19);
			this.addCar.Text = "הוספת רכב";
			this.addCar.Click += new System.EventHandler(this.addCar_Click);
			// 
			// addFault
			// 
			this.addFault.ForeColor = System.Drawing.Color.White;
			this.addFault.Name = "addFault";
			this.addFault.Size = new System.Drawing.Size(113, 19);
			this.addFault.Text = "פתיחת תקלה";
			this.addFault.Click += new System.EventHandler(this.addFault_Click);
			// 
			// קביעתפגישותToolStripMenuItem
			// 
			this.קביעתפגישותToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.קביעתפגישותToolStripMenuItem.Name = "קביעתפגישותToolStripMenuItem";
			this.קביעתפגישותToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
			this.קביעתפגישותToolStripMenuItem.Text = "קביעת פגישות";
			this.קביעתפגישותToolStripMenuItem.Click += new System.EventHandler(this.קביעתפגישותToolStripMenuItem_Click);
			// 
			// רשימתרכבימכירהToolStripMenuItem
			// 
			this.רשימתרכבימכירהToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.רשימתרכבימכירהToolStripMenuItem.Name = "רשימתרכבימכירהToolStripMenuItem";
			this.רשימתרכבימכירהToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
			this.רשימתרכבימכירהToolStripMenuItem.Text = "רשימת רכבי מכירה";
			this.רשימתרכבימכירהToolStripMenuItem.Click += new System.EventHandler(this.רשימתרכבימכירהToolStripMenuItem_Click);
			// 
			// updateEmployee
			// 
			this.updateEmployee.ForeColor = System.Drawing.Color.White;
			this.updateEmployee.Name = "updateEmployee";
			this.updateEmployee.Size = new System.Drawing.Size(113, 19);
			this.updateEmployee.Text = "עדכון פרטי העובד";
			this.updateEmployee.Click += new System.EventHandler(this.updateEmployee_Click);
			// 
			// exitAccount
			// 
			this.exitAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.exitAccount.ForeColor = System.Drawing.Color.White;
			this.exitAccount.Name = "exitAccount";
			this.exitAccount.Size = new System.Drawing.Size(113, 19);
			this.exitAccount.Text = "התנתק";
			this.exitAccount.Click += new System.EventHandler(this.exitAccount_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(1015, 69);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 20);
			this.label1.TabIndex = 190;
			this.label1.Text = "מחיר של תיקון";
			// 
			// priceToByed
			// 
			this.priceToByed.Location = new System.Drawing.Point(833, 69);
			this.priceToByed.Margin = new System.Windows.Forms.Padding(2);
			this.priceToByed.Name = "priceToByed";
			this.priceToByed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.priceToByed.Size = new System.Drawing.Size(149, 20);
			this.priceToByed.TabIndex = 189;
			// 
			// ListOfCarAfterFixToPaed
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1270, 744);
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.priceToByed);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.dataGridCostumers);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.IDCostumer);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label24);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MinimizeBox = false;
			this.Name = "ListOfCarAfterFixToPaed";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.ListOfCarAfterFixToPaed_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridCostumers)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridCostumers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDCostumer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addEmployee;
        private System.Windows.Forms.ToolStripMenuItem addCar;
        private System.Windows.Forms.ToolStripMenuItem addFault;
        private System.Windows.Forms.ToolStripMenuItem קביעתפגישותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem רשימתרכבימכירהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployee;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceToByed;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicenseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Milege;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewButtonColumn Accept;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}