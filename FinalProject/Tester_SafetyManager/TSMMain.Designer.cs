namespace FinalProject.Tester_SafetyManager
{
    partial class TSMMain
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
			this.listOfRepairedCars = new System.Windows.Forms.ToolStripMenuItem();
			this.updateRepairedParts = new System.Windows.Forms.ToolStripMenuItem();
			this.carToGarage = new System.Windows.Forms.ToolStripMenuItem();
			this.monthlyExceptionsHours = new System.Windows.Forms.ToolStripMenuItem();
			this.btnExitAccount = new System.Windows.Forms.ToolStripMenuItem();
			this.label16 = new System.Windows.Forms.Label();
			this.textAddress = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textCity = new System.Windows.Forms.TextBox();
			this.textGarageName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.dataGridGarages = new System.Windows.Forms.DataGridView();
			this.GarageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AddGarage = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridGarages)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thisForm,
            this.listOfRepairedCars,
            this.updateRepairedParts,
            this.carToGarage,
            this.monthlyExceptionsHours,
            this.btnExitAccount});
			this.menuStrip1.Location = new System.Drawing.Point(1138, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(156, 814);
			this.menuStrip1.TabIndex = 131;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// thisForm
			// 
			this.thisForm.BackColor = System.Drawing.Color.MidnightBlue;
			this.thisForm.Enabled = false;
			this.thisForm.ForeColor = System.Drawing.Color.White;
			this.thisForm.Name = "thisForm";
			this.thisForm.Size = new System.Drawing.Size(151, 19);
			this.thisForm.Text = "תפריט";
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
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(1075, 100);
			this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(51, 20);
			this.label16.TabIndex = 172;
			this.label16.Text = "כתובת";
			// 
			// textAddress
			// 
			this.textAddress.Location = new System.Drawing.Point(839, 100);
			this.textAddress.Margin = new System.Windows.Forms.Padding(2);
			this.textAddress.Name = "textAddress";
			this.textAddress.Size = new System.Drawing.Size(149, 20);
			this.textAddress.TabIndex = 171;
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.MidnightBlue;
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(839, 124);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(81, 23);
			this.btnSearch.TabIndex = 170;
			this.btnSearch.Text = "חיפוש";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(1093, 76);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 20);
			this.label4.TabIndex = 167;
			this.label4.Text = "עיר";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(1060, 52);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 20);
			this.label5.TabIndex = 166;
			this.label5.Text = "שם מוסך";
			// 
			// textCity
			// 
			this.textCity.Location = new System.Drawing.Point(839, 76);
			this.textCity.Margin = new System.Windows.Forms.Padding(2);
			this.textCity.Name = "textCity";
			this.textCity.Size = new System.Drawing.Size(149, 20);
			this.textCity.TabIndex = 164;
			// 
			// textGarageName
			// 
			this.textGarageName.Location = new System.Drawing.Point(839, 52);
			this.textGarageName.Margin = new System.Windows.Forms.Padding(2);
			this.textGarageName.Name = "textGarageName";
			this.textGarageName.Size = new System.Drawing.Size(149, 20);
			this.textGarageName.TabIndex = 162;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.OrangeRed;
			this.label6.Location = new System.Drawing.Point(839, 9);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(287, 39);
			this.label6.TabIndex = 161;
			this.label6.Text = "איתור מהיר";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.MidnightBlue;
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(11, 219);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(255, 33);
			this.label8.TabIndex = 157;
			this.label8.Text = "מס\' טלפון";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.MidnightBlue;
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(270, 219);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(249, 33);
			this.label11.TabIndex = 153;
			this.label11.Text = "כתובת";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.MidnightBlue;
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(777, 219);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(253, 33);
			this.label12.TabIndex = 149;
			this.label12.Text = "שם מוסך";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.MidnightBlue;
			this.label24.ForeColor = System.Drawing.Color.White;
			this.label24.Location = new System.Drawing.Point(523, 219);
			this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(250, 33);
			this.label24.TabIndex = 145;
			this.label24.Text = "עיר";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridGarages
			// 
			this.dataGridGarages.AllowUserToDeleteRows = false;
			this.dataGridGarages.AllowUserToResizeColumns = false;
			this.dataGridGarages.AllowUserToResizeRows = false;
			this.dataGridGarages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridGarages.ColumnHeadersVisible = false;
			this.dataGridGarages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GarageName,
            this.City,
            this.Address,
            this.PhoneNumber});
			this.dataGridGarages.Location = new System.Drawing.Point(12, 255);
			this.dataGridGarages.Name = "dataGridGarages";
			this.dataGridGarages.ReadOnly = true;
			this.dataGridGarages.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dataGridGarages.RowHeadersVisible = false;
			this.dataGridGarages.RowHeadersWidth = 62;
			this.dataGridGarages.Size = new System.Drawing.Size(1018, 514);
			this.dataGridGarages.TabIndex = 173;
			// 
			// GarageName
			// 
			this.GarageName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.GarageName.HeaderText = "שם מוסך";
			this.GarageName.MinimumWidth = 8;
			this.GarageName.Name = "GarageName";
			this.GarageName.ReadOnly = true;
			// 
			// City
			// 
			this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.City.HeaderText = "עיר";
			this.City.MinimumWidth = 8;
			this.City.Name = "City";
			this.City.ReadOnly = true;
			// 
			// Address
			// 
			this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Address.HeaderText = "כתובת";
			this.Address.MinimumWidth = 8;
			this.Address.Name = "Address";
			this.Address.ReadOnly = true;
			// 
			// PhoneNumber
			// 
			this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.PhoneNumber.HeaderText = "מס\' טלפון";
			this.PhoneNumber.MinimumWidth = 8;
			this.PhoneNumber.Name = "PhoneNumber";
			this.PhoneNumber.ReadOnly = true;
			// 
			// AddGarage
			// 
			this.AddGarage.BackColor = System.Drawing.Color.MidnightBlue;
			this.AddGarage.ForeColor = System.Drawing.Color.White;
			this.AddGarage.Location = new System.Drawing.Point(968, 124);
			this.AddGarage.Margin = new System.Windows.Forms.Padding(2);
			this.AddGarage.Name = "AddGarage";
			this.AddGarage.Size = new System.Drawing.Size(81, 23);
			this.AddGarage.TabIndex = 174;
			this.AddGarage.Text = "הוספת מוסך";
			this.AddGarage.UseVisualStyleBackColor = false;
			this.AddGarage.Click += new System.EventHandler(this.AddGarage_Click);
			// 
			// TSMMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1294, 814);
			this.ControlBox = false;
			this.Controls.Add(this.AddGarage);
			this.Controls.Add(this.dataGridGarages);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.textAddress);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textCity);
			this.Controls.Add(this.textGarageName);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TSMMain";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.TSMMain_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridGarages)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thisForm;
        private System.Windows.Forms.ToolStripMenuItem listOfRepairedCars;
        private System.Windows.Forms.ToolStripMenuItem updateRepairedParts;
        private System.Windows.Forms.ToolStripMenuItem monthlyExceptionsHours;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textGarageName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label24;
		private System.Windows.Forms.ToolStripMenuItem carToGarage;
		private System.Windows.Forms.DataGridView dataGridGarages;
		private System.Windows.Forms.ToolStripMenuItem btnExitAccount;
		private System.Windows.Forms.DataGridViewTextBoxColumn GarageName;
		private System.Windows.Forms.DataGridViewTextBoxColumn City;
		private System.Windows.Forms.DataGridViewTextBoxColumn Address;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.Button AddGarage;
    }
}