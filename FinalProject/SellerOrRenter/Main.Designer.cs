namespace FinalProject.SellerOrRenter
{
    partial class Main
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
			this.dataGridParklCars = new System.Windows.Forms.DataGridView();
			this.License = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Manufacture_Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Milege = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.daysInGarage = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.parkingPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.מחיר = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.סיסמה = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.EvintNum = new System.Windows.Forms.Label();
			this.time = new System.Windows.Forms.Label();
			this.DateEvent = new System.Windows.Forms.Label();
			this.TaskDetails = new System.Windows.Forms.Label();
			this.licencNumber = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Find = new System.Windows.Forms.Button();
			this.prices = new System.Windows.Forms.TextBox();
			this.Brand_Model = new System.Windows.Forms.TextBox();
			this.milegeNum = new System.Windows.Forms.TextBox();
			this.LicenseNum = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.רשימתמשימותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.התנתקToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridParklCars)).BeginInit();
			this.menuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridParklCars
			// 
			this.dataGridParklCars.AllowUserToResizeColumns = false;
			this.dataGridParklCars.AllowUserToResizeRows = false;
			this.dataGridParklCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridParklCars.ColumnHeadersVisible = false;
			this.dataGridParklCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.License,
            this.Manufacture_Model,
            this.Milege,
            this.daysInGarage,
            this.parkingPlace,
            this.comments,
            this.מחיר,
            this.Column1,
            this.סיסמה});
			this.dataGridParklCars.Location = new System.Drawing.Point(12, 254);
			this.dataGridParklCars.Name = "dataGridParklCars";
			this.dataGridParklCars.ReadOnly = true;
			this.dataGridParklCars.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dataGridParklCars.RowHeadersVisible = false;
			this.dataGridParklCars.RowHeadersWidth = 62;
			this.dataGridParklCars.Size = new System.Drawing.Size(1253, 552);
			this.dataGridParklCars.TabIndex = 167;
			this.dataGridParklCars.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridParklCars_CellMouseDoubleClick);
			// 
			// License
			// 
			this.License.HeaderText = "רישוי";
			this.License.MinimumWidth = 8;
			this.License.Name = "License";
			this.License.ReadOnly = true;
			this.License.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.License.Width = 150;
			// 
			// Manufacture_Model
			// 
			this.Manufacture_Model.HeaderText = "יצרן/דגם";
			this.Manufacture_Model.MinimumWidth = 8;
			this.Manufacture_Model.Name = "Manufacture_Model";
			this.Manufacture_Model.ReadOnly = true;
			this.Manufacture_Model.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Manufacture_Model.Width = 190;
			// 
			// Milege
			// 
			this.Milege.HeaderText = "קילומטראז\'";
			this.Milege.MinimumWidth = 8;
			this.Milege.Name = "Milege";
			this.Milege.ReadOnly = true;
			this.Milege.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Milege.Width = 160;
			// 
			// daysInGarage
			// 
			this.daysInGarage.HeaderText = "סיסמה";
			this.daysInGarage.MinimumWidth = 8;
			this.daysInGarage.Name = "daysInGarage";
			this.daysInGarage.ReadOnly = true;
			this.daysInGarage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.daysInGarage.Width = 145;
			// 
			// parkingPlace
			// 
			this.parkingPlace.HeaderText = "נפח מנוע";
			this.parkingPlace.MinimumWidth = 8;
			this.parkingPlace.Name = "parkingPlace";
			this.parkingPlace.ReadOnly = true;
			this.parkingPlace.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.parkingPlace.Width = 175;
			// 
			// comments
			// 
			this.comments.HeaderText = "שנת יצור";
			this.comments.MinimumWidth = 8;
			this.comments.Name = "comments";
			this.comments.ReadOnly = true;
			this.comments.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// מחיר
			// 
			this.מחיר.HeaderText = "צבע";
			this.מחיר.MinimumWidth = 8;
			this.מחיר.Name = "מחיר";
			this.מחיר.ReadOnly = true;
			this.מחיר.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.מחיר.Width = 112;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "מחיר";
			this.Column1.MinimumWidth = 8;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column1.Width = 135;
			// 
			// סיסמה
			// 
			this.סיסמה.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.סיסמה.HeaderText = "מספר חניה";
			this.סיסמה.MinimumWidth = 8;
			this.סיסמה.Name = "סיסמה";
			this.סיסמה.ReadOnly = true;
			this.סיסמה.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.MidnightBlue;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(234, 226);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 25);
			this.label3.TabIndex = 168;
			this.label3.Text = "צבע";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// EvintNum
			// 
			this.EvintNum.BackColor = System.Drawing.Color.MidnightBlue;
			this.EvintNum.ForeColor = System.Drawing.Color.White;
			this.EvintNum.Location = new System.Drawing.Point(1116, 226);
			this.EvintNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.EvintNum.Name = "EvintNum";
			this.EvintNum.Size = new System.Drawing.Size(149, 25);
			this.EvintNum.TabIndex = 173;
			this.EvintNum.Text = "מספר רכב";
			this.EvintNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// time
			// 
			this.time.BackColor = System.Drawing.Color.MidnightBlue;
			this.time.ForeColor = System.Drawing.Color.White;
			this.time.Location = new System.Drawing.Point(346, 226);
			this.time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.time.Name = "time";
			this.time.Size = new System.Drawing.Size(95, 25);
			this.time.TabIndex = 169;
			this.time.Text = "שנת יצור";
			this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DateEvent
			// 
			this.DateEvent.BackColor = System.Drawing.Color.MidnightBlue;
			this.DateEvent.ForeColor = System.Drawing.Color.White;
			this.DateEvent.Location = new System.Drawing.Point(925, 226);
			this.DateEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DateEvent.Name = "DateEvent";
			this.DateEvent.Size = new System.Drawing.Size(187, 25);
			this.DateEvent.TabIndex = 172;
			this.DateEvent.Text = "יצרן/דגם";
			this.DateEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TaskDetails
			// 
			this.TaskDetails.BackColor = System.Drawing.Color.MidnightBlue;
			this.TaskDetails.ForeColor = System.Drawing.Color.White;
			this.TaskDetails.Location = new System.Drawing.Point(445, 226);
			this.TaskDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.TaskDetails.Name = "TaskDetails";
			this.TaskDetails.Size = new System.Drawing.Size(171, 25);
			this.TaskDetails.TabIndex = 170;
			this.TaskDetails.Text = "נפח מנוע";
			this.TaskDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// licencNumber
			// 
			this.licencNumber.BackColor = System.Drawing.Color.MidnightBlue;
			this.licencNumber.ForeColor = System.Drawing.Color.White;
			this.licencNumber.Location = new System.Drawing.Point(765, 226);
			this.licencNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.licencNumber.Name = "licencNumber";
			this.licencNumber.Size = new System.Drawing.Size(156, 25);
			this.licencNumber.TabIndex = 171;
			this.licencNumber.Text = "קילומטראזי";
			this.licencNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.MidnightBlue;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(100, 226);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 25);
			this.label2.TabIndex = 175;
			this.label2.Text = "מחיר";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.MidnightBlue;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 226);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 25);
			this.label1.TabIndex = 176;
			this.label1.Text = "מספר חניה";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Find
			// 
			this.Find.BackColor = System.Drawing.Color.MidnightBlue;
			this.Find.ForeColor = System.Drawing.Color.White;
			this.Find.Location = new System.Drawing.Point(827, 146);
			this.Find.Margin = new System.Windows.Forms.Padding(2);
			this.Find.Name = "Find";
			this.Find.Size = new System.Drawing.Size(81, 23);
			this.Find.TabIndex = 184;
			this.Find.Text = "חיפוש";
			this.Find.UseVisualStyleBackColor = false;
			this.Find.Click += new System.EventHandler(this.Find_Click);
			// 
			// prices
			// 
			this.prices.Location = new System.Drawing.Point(827, 122);
			this.prices.Margin = new System.Windows.Forms.Padding(2);
			this.prices.Name = "prices";
			this.prices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.prices.Size = new System.Drawing.Size(149, 20);
			this.prices.TabIndex = 183;
			// 
			// Brand_Model
			// 
			this.Brand_Model.Location = new System.Drawing.Point(827, 98);
			this.Brand_Model.Margin = new System.Windows.Forms.Padding(2);
			this.Brand_Model.Name = "Brand_Model";
			this.Brand_Model.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Brand_Model.Size = new System.Drawing.Size(149, 20);
			this.Brand_Model.TabIndex = 182;
			// 
			// milegeNum
			// 
			this.milegeNum.Location = new System.Drawing.Point(827, 74);
			this.milegeNum.Margin = new System.Windows.Forms.Padding(2);
			this.milegeNum.Name = "milegeNum";
			this.milegeNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.milegeNum.Size = new System.Drawing.Size(149, 20);
			this.milegeNum.TabIndex = 181;
			// 
			// LicenseNum
			// 
			this.LicenseNum.Location = new System.Drawing.Point(827, 50);
			this.LicenseNum.Margin = new System.Windows.Forms.Padding(2);
			this.LicenseNum.Name = "LicenseNum";
			this.LicenseNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.LicenseNum.Size = new System.Drawing.Size(149, 20);
			this.LicenseNum.TabIndex = 180;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.OrangeRed;
			this.label6.Location = new System.Drawing.Point(822, 9);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(287, 39);
			this.label6.TabIndex = 179;
			this.label6.Text = "איתור מהיר";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(1066, 122);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 20);
			this.label4.TabIndex = 188;
			this.label4.Text = "מחיר";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(1024, 74);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 20);
			this.label5.TabIndex = 187;
			this.label5.Text = "\'קילומטראז";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(1041, 98);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 20);
			this.label7.TabIndex = 186;
			this.label7.Text = "יצרן/דגם";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(1065, 50);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(44, 20);
			this.label8.TabIndex = 185;
			this.label8.Text = "רישוי";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.BackColor = System.Drawing.Color.MidnightBlue;
			this.toolStripMenuItem1.Enabled = false;
			this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 19);
			this.toolStripMenuItem1.Text = "מסך ראשי";
			// 
			// testToolStripMenuItem
			// 
			this.testToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue;
			this.testToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.testToolStripMenuItem.Name = "testToolStripMenuItem";
			this.testToolStripMenuItem.Size = new System.Drawing.Size(151, 19);
			this.testToolStripMenuItem.Text = "יצירת חוזה";
			this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click_1);
			// 
			// רשימתמשימותToolStripMenuItem
			// 
			this.רשימתמשימותToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue;
			this.רשימתמשימותToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.רשימתמשימותToolStripMenuItem.Name = "רשימתמשימותToolStripMenuItem";
			this.רשימתמשימותToolStripMenuItem.Size = new System.Drawing.Size(151, 19);
			this.רשימתמשימותToolStripMenuItem.Text = "הכנה רכב ללקוח";
			this.רשימתמשימותToolStripMenuItem.Click += new System.EventHandler(this.רשימתמשימותToolStripMenuItem_Click);
			// 
			// התנתקToolStripMenuItem
			// 
			this.התנתקToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue;
			this.התנתקToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.התנתקToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.התנתקToolStripMenuItem.Name = "התנתקToolStripMenuItem";
			this.התנתקToolStripMenuItem.Size = new System.Drawing.Size(151, 19);
			this.התנתקToolStripMenuItem.Text = "התנתק";
			this.התנתקToolStripMenuItem.Click += new System.EventHandler(this.התנתקToolStripMenuItem_Click);
			// 
			// menuStrip2
			// 
			this.menuStrip2.AutoSize = false;
			this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Right;
			this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.testToolStripMenuItem,
            this.רשימתמשימותToolStripMenuItem,
            this.התנתקToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(1142, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip2.Size = new System.Drawing.Size(156, 818);
			this.menuStrip2.TabIndex = 178;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.MidnightBlue;
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(620, 226);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(141, 25);
			this.label9.TabIndex = 189;
			this.label9.Text = "סיסמה";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1298, 818);
			this.ControlBox = false;
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.Find);
			this.Controls.Add(this.prices);
			this.Controls.Add(this.Brand_Model);
			this.Controls.Add(this.milegeNum);
			this.Controls.Add(this.LicenseNum);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridParklCars);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.EvintNum);
			this.Controls.Add(this.time);
			this.Controls.Add(this.DateEvent);
			this.Controls.Add(this.TaskDetails);
			this.Controls.Add(this.licencNumber);
			this.Controls.Add(this.menuStrip2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainSeller_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridParklCars)).EndInit();
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridParklCars;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EvintNum;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label DateEvent;
        private System.Windows.Forms.Label TaskDetails;
        private System.Windows.Forms.Label licencNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.TextBox prices;
        private System.Windows.Forms.TextBox Brand_Model;
        private System.Windows.Forms.TextBox milegeNum;
        private System.Windows.Forms.TextBox LicenseNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem רשימתמשימותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem התנתקToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DataGridViewTextBoxColumn License;
		private System.Windows.Forms.DataGridViewTextBoxColumn Manufacture_Model;
		private System.Windows.Forms.DataGridViewTextBoxColumn Milege;
		private System.Windows.Forms.DataGridViewTextBoxColumn daysInGarage;
		private System.Windows.Forms.DataGridViewTextBoxColumn parkingPlace;
		private System.Windows.Forms.DataGridViewTextBoxColumn comments;
		private System.Windows.Forms.DataGridViewTextBoxColumn מחיר;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn סיסמה;
	}
}