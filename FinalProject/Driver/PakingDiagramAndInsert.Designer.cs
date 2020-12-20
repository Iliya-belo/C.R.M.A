namespace FinalProject.Driver
{
    partial class PakingDiagramAndInsert
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
			this.parking = new System.Windows.Forms.PictureBox();
			this.floor = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.close = new System.Windows.Forms.Button();
			this.insertCar = new System.Windows.Forms.Button();
			this.empParking = new System.Windows.Forms.ComboBox();
			this.dataGridCars = new System.Windows.Forms.DataGridView();
			this.dataGridCarsWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textLicensNum = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.parking)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).BeginInit();
			this.SuspendLayout();
			// 
			// parking
			// 
			this.parking.Location = new System.Drawing.Point(12, 12);
			this.parking.Name = "parking";
			this.parking.Size = new System.Drawing.Size(809, 459);
			this.parking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.parking.TabIndex = 0;
			this.parking.TabStop = false;
			this.parking.DoubleClick += new System.EventHandler(this.parking_DoubleClick);
			// 
			// floor
			// 
			this.floor.FormattingEnabled = true;
			this.floor.Items.AddRange(new object[] {
            "1",
            "2"});
			this.floor.Location = new System.Drawing.Point(827, 40);
			this.floor.Name = "floor";
			this.floor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.floor.Size = new System.Drawing.Size(121, 21);
			this.floor.TabIndex = 1;
			this.floor.SelectedIndexChanged += new System.EventHandler(this.floor_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(1009, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "קומה";
			// 
			// close
			// 
			this.close.BackColor = System.Drawing.Color.MidnightBlue;
			this.close.ForeColor = System.Drawing.Color.White;
			this.close.Location = new System.Drawing.Point(827, 339);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(101, 35);
			this.close.TabIndex = 3;
			this.close.Text = "סגור";
			this.close.UseVisualStyleBackColor = false;
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// insertCar
			// 
			this.insertCar.BackColor = System.Drawing.Color.MidnightBlue;
			this.insertCar.ForeColor = System.Drawing.Color.White;
			this.insertCar.Location = new System.Drawing.Point(827, 155);
			this.insertCar.Name = "insertCar";
			this.insertCar.Size = new System.Drawing.Size(129, 35);
			this.insertCar.TabIndex = 5;
			this.insertCar.Text = "הכנס רכב לחניה";
			this.insertCar.UseVisualStyleBackColor = false;
			this.insertCar.Click += new System.EventHandler(this.insertCar_Click);
			// 
			// empParking
			// 
			this.empParking.FormattingEnabled = true;
			this.empParking.Items.AddRange(new object[] {
            "1",
            "2"});
			this.empParking.Location = new System.Drawing.Point(827, 108);
			this.empParking.Name = "empParking";
			this.empParking.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.empParking.Size = new System.Drawing.Size(121, 21);
			this.empParking.TabIndex = 6;
			// 
			// dataGridCars
			// 
			this.dataGridCars.AllowUserToResizeColumns = false;
			this.dataGridCars.AllowUserToResizeRows = false;
			this.dataGridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridCars.ColumnHeadersVisible = false;
			this.dataGridCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridCarsWork});
			this.dataGridCars.Location = new System.Drawing.Point(827, 108);
			this.dataGridCars.Name = "dataGridCars";
			this.dataGridCars.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dataGridCars.RowHeadersVisible = false;
			this.dataGridCars.RowHeadersWidth = 62;
			this.dataGridCars.Size = new System.Drawing.Size(121, 148);
			this.dataGridCars.TabIndex = 169;
			this.dataGridCars.Visible = false;
			this.dataGridCars.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCars_CellDoubleClick);
			// 
			// dataGridCarsWork
			// 
			this.dataGridCarsWork.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridCarsWork.HeaderText = "רישוי";
			this.dataGridCarsWork.MinimumWidth = 8;
			this.dataGridCarsWork.Name = "dataGridCarsWork";
			this.dataGridCarsWork.ReadOnly = true;
			this.dataGridCarsWork.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// textLicensNum
			// 
			this.textLicensNum.Location = new System.Drawing.Point(827, 82);
			this.textLicensNum.Name = "textLicensNum";
			this.textLicensNum.Size = new System.Drawing.Size(121, 20);
			this.textLicensNum.TabIndex = 168;
			this.textLicensNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textLicensNum.TextChanged += new System.EventHandler(this.textLicensNum_TextChanged);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(996, 82);
			this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(46, 13);
			this.label14.TabIndex = 167;
			this.label14.Text = "מס\' רכב";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(969, 111);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 170;
			this.label2.Text = "חניות פנויות";
			// 
			// PakingDiagramAndInsert
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(963, 550);
			this.ControlBox = false;
			this.Controls.Add(this.dataGridCars);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textLicensNum);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.empParking);
			this.Controls.Add(this.insertCar);
			this.Controls.Add(this.close);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.floor);
			this.Controls.Add(this.parking);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "PakingDiagramAndInsert";
			this.Load += new System.EventHandler(this.PakingDiagramAndInsert_Load);
			((System.ComponentModel.ISupportInitialize)(this.parking)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox parking;
        private System.Windows.Forms.ComboBox floor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button insertCar;
        private System.Windows.Forms.ComboBox empParking;
        private System.Windows.Forms.DataGridView dataGridCars;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridCarsWork;
        private System.Windows.Forms.TextBox textLicensNum;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
    }
}