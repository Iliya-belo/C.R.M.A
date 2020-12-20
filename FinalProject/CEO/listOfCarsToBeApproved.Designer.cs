namespace FinalProject.CEO
{
    partial class listOfCarsToBeApproved
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
			this.thisForm = new System.Windows.Forms.ToolStripMenuItem();
			this.listOfMeetings = new System.Windows.Forms.ToolStripMenuItem();
			this.WorkCar = new System.Windows.Forms.ToolStripMenuItem();
			this.exceptionList = new System.Windows.Forms.ToolStripMenuItem();
			this.monthlyExceptionsHours = new System.Windows.Forms.ToolStripMenuItem();
			this.btnExitAccount = new System.Windows.Forms.ToolStripMenuItem();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textLicenseNumber = new System.Windows.Forms.TextBox();
			this.textMilege = new System.Windows.Forms.TextBox();
			this.textBrandAndModel = new System.Windows.Forms.TextBox();
			this.textPrice = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.dataGridCars = new System.Windows.Forms.DataGridView();
			this.LicenseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BrandModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Milege = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CarDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Accept = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Refuse = new System.Windows.Forms.DataGridViewButtonColumn();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainCEO,
            this.thisForm,
            this.listOfMeetings,
            this.WorkCar,
            this.exceptionList,
            this.monthlyExceptionsHours,
            this.btnExitAccount});
			this.menuStrip1.Location = new System.Drawing.Point(1134, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(122, 753);
			this.menuStrip1.TabIndex = 129;
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
			// thisForm
			// 
			this.thisForm.BackColor = System.Drawing.Color.MidnightBlue;
			this.thisForm.Enabled = false;
			this.thisForm.ForeColor = System.Drawing.Color.White;
			this.thisForm.Name = "thisForm";
			this.thisForm.Size = new System.Drawing.Size(117, 19);
			this.thisForm.Text = "רשימת רכבים לאישור";
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
			// WorkCar
			// 
			this.WorkCar.BackColor = System.Drawing.Color.MidnightBlue;
			this.WorkCar.ForeColor = System.Drawing.Color.White;
			this.WorkCar.Name = "WorkCar";
			this.WorkCar.Size = new System.Drawing.Size(117, 19);
			this.WorkCar.Text = "הגדרת רכב עבודה";
			this.WorkCar.Click += new System.EventHandler(this.WorkCar_Click);
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
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.MidnightBlue;
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(328, 219);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(155, 33);
			this.label10.TabIndex = 140;
			this.label10.Text = "צבע";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.MidnightBlue;
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(486, 219);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(155, 33);
			this.label11.TabIndex = 138;
			this.label11.Text = "מחיר";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.MidnightBlue;
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(850, 219);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(81, 33);
			this.label12.TabIndex = 134;
			this.label12.Text = "\'קילומטראז";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.MidnightBlue;
			this.label18.ForeColor = System.Drawing.Color.White;
			this.label18.Location = new System.Drawing.Point(1034, 219);
			this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(90, 33);
			this.label18.TabIndex = 132;
			this.label18.Text = "רישוי";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.MidnightBlue;
			this.label19.ForeColor = System.Drawing.Color.White;
			this.label19.Location = new System.Drawing.Point(935, 219);
			this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(95, 33);
			this.label19.TabIndex = 131;
			this.label19.Text = "יצרן ודגם";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.MidnightBlue;
			this.label24.ForeColor = System.Drawing.Color.White;
			this.label24.Location = new System.Drawing.Point(645, 219);
			this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(201, 33);
			this.label24.TabIndex = 130;
			this.label24.Text = "תיאור הרכב";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.label6.TabIndex = 146;
			this.label6.Text = "איתור מהיר";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textLicenseNumber
			// 
			this.textLicenseNumber.Location = new System.Drawing.Point(839, 52);
			this.textLicenseNumber.Margin = new System.Windows.Forms.Padding(2);
			this.textLicenseNumber.Name = "textLicenseNumber";
			this.textLicenseNumber.Size = new System.Drawing.Size(149, 20);
			this.textLicenseNumber.TabIndex = 147;
			this.textLicenseNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textMilege
			// 
			this.textMilege.Location = new System.Drawing.Point(839, 76);
			this.textMilege.Margin = new System.Windows.Forms.Padding(2);
			this.textMilege.Name = "textMilege";
			this.textMilege.Size = new System.Drawing.Size(149, 20);
			this.textMilege.TabIndex = 148;
			this.textMilege.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBrandAndModel
			// 
			this.textBrandAndModel.Location = new System.Drawing.Point(839, 100);
			this.textBrandAndModel.Margin = new System.Windows.Forms.Padding(2);
			this.textBrandAndModel.Name = "textBrandAndModel";
			this.textBrandAndModel.Size = new System.Drawing.Size(149, 20);
			this.textBrandAndModel.TabIndex = 149;
			this.textBrandAndModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textPrice
			// 
			this.textPrice.Location = new System.Drawing.Point(839, 124);
			this.textPrice.Margin = new System.Windows.Forms.Padding(2);
			this.textPrice.Name = "textPrice";
			this.textPrice.Size = new System.Drawing.Size(149, 20);
			this.textPrice.TabIndex = 150;
			this.textPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(1080, 52);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 20);
			this.label5.TabIndex = 151;
			this.label5.Text = "רישוי";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(1056, 100);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 20);
			this.label4.TabIndex = 152;
			this.label4.Text = "יצרן/דגם";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(1039, 76);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 20);
			this.label3.TabIndex = 153;
			this.label3.Text = "\'קילומטראז";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(1081, 124);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 20);
			this.label2.TabIndex = 154;
			this.label2.Text = "מחיר";
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.MidnightBlue;
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(839, 148);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(81, 23);
			this.btnSearch.TabIndex = 156;
			this.btnSearch.Text = "חיפוש";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// dataGridCars
			// 
			this.dataGridCars.AllowUserToResizeColumns = false;
			this.dataGridCars.AllowUserToResizeRows = false;
			this.dataGridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridCars.ColumnHeadersVisible = false;
			this.dataGridCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LicenseNumber,
            this.BrandModel,
            this.Milege,
            this.CarDescription,
            this.Price,
            this.Color,
            this.Accept,
            this.Refuse});
			this.dataGridCars.Location = new System.Drawing.Point(12, 255);
			this.dataGridCars.Name = "dataGridCars";
			this.dataGridCars.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dataGridCars.RowHeadersVisible = false;
			this.dataGridCars.Size = new System.Drawing.Size(1112, 514);
			this.dataGridCars.TabIndex = 169;
			this.dataGridCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCars_CellContentClick);
			// 
			// LicenseNumber
			// 
			this.LicenseNumber.HeaderText = "רישוי";
			this.LicenseNumber.Name = "LicenseNumber";
			this.LicenseNumber.ReadOnly = true;
			this.LicenseNumber.Width = 91;
			// 
			// BrandModel
			// 
			this.BrandModel.HeaderText = "יצרן ודגם";
			this.BrandModel.Name = "BrandModel";
			this.BrandModel.ReadOnly = true;
			this.BrandModel.Width = 99;
			// 
			// Milege
			// 
			this.Milege.HeaderText = "קילומטראז\'";
			this.Milege.Name = "Milege";
			this.Milege.ReadOnly = true;
			this.Milege.Width = 85;
			// 
			// CarDescription
			// 
			this.CarDescription.HeaderText = "תיאור רכב";
			this.CarDescription.Name = "CarDescription";
			this.CarDescription.ReadOnly = true;
			this.CarDescription.Width = 204;
			// 
			// Price
			// 
			this.Price.HeaderText = "מחיר";
			this.Price.Name = "Price";
			this.Price.ReadOnly = true;
			this.Price.Width = 159;
			// 
			// Color
			// 
			this.Color.HeaderText = "צבע";
			this.Color.Name = "Color";
			this.Color.ReadOnly = true;
			this.Color.Width = 159;
			// 
			// Accept
			// 
			this.Accept.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Accept.HeaderText = "אושר";
			this.Accept.Name = "Accept";
			this.Accept.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Accept.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Accept.Text = "אושר";
			this.Accept.UseColumnTextForButtonValue = true;
			// 
			// Refuse
			// 
			this.Refuse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Refuse.HeaderText = "לא אושר";
			this.Refuse.Name = "Refuse";
			this.Refuse.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Refuse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Refuse.Text = "לא אושר";
			this.Refuse.UseColumnTextForButtonValue = true;
			// 
			// listOfCarsToBeApproved
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1256, 753);
			this.ControlBox = false;
			this.Controls.Add(this.dataGridCars);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textPrice);
			this.Controls.Add(this.textBrandAndModel);
			this.Controls.Add(this.textMilege);
			this.Controls.Add(this.textLicenseNumber);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "listOfCarsToBeApproved";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.listOfCarsToBeApproved_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainCEO;
        private System.Windows.Forms.ToolStripMenuItem thisForm;
        private System.Windows.Forms.ToolStripMenuItem listOfMeetings;
        private System.Windows.Forms.ToolStripMenuItem exceptionList;
        private System.Windows.Forms.ToolStripMenuItem monthlyExceptionsHours;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textLicenseNumber;
        private System.Windows.Forms.TextBox textMilege;
        private System.Windows.Forms.TextBox textBrandAndModel;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.DataGridView dataGridCars;
		private System.Windows.Forms.ToolStripMenuItem btnExitAccount;
		private System.Windows.Forms.DataGridViewTextBoxColumn LicenseNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn BrandModel;
		private System.Windows.Forms.DataGridViewTextBoxColumn Milege;
		private System.Windows.Forms.DataGridViewTextBoxColumn CarDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Color;
		private System.Windows.Forms.DataGridViewButtonColumn Accept;
		private System.Windows.Forms.DataGridViewButtonColumn Refuse;
        private System.Windows.Forms.ToolStripMenuItem WorkCar;
    }
}