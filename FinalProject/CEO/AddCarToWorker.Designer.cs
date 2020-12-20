namespace FinalProject.CEO
{
    partial class AddCarToWorker
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
            this.GiveCar = new System.Windows.Forms.Button();
            this.ChengeCar = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.Eng_cap = new System.Windows.Forms.TextBox();
            this.DateLastCarCare = new System.Windows.Forms.DateTimePicker();
            this.DateTest = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textMilege = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textCarYear = new System.Windows.Forms.TextBox();
            this.textModel = new System.Windows.Forms.TextBox();
            this.textManufacture = new System.Windows.Forms.TextBox();
            this.textMVANo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.textStreet = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textRole = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ReturnCar = new System.Windows.Forms.Button();
            this.textLicensNum = new System.Windows.Forms.TextBox();
            this.dataGridCars = new System.Windows.Forms.DataGridView();
            this.dataGridCarsWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.License = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataWorkers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // GiveCar
            // 
            this.GiveCar.BackColor = System.Drawing.Color.MidnightBlue;
            this.GiveCar.ForeColor = System.Drawing.Color.White;
            this.GiveCar.Location = new System.Drawing.Point(16, 384);
            this.GiveCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GiveCar.Name = "GiveCar";
            this.GiveCar.Size = new System.Drawing.Size(111, 39);
            this.GiveCar.TabIndex = 0;
            this.GiveCar.Text = "הצמדת רכב";
            this.GiveCar.UseVisualStyleBackColor = false;
            this.GiveCar.Click += new System.EventHandler(this.GiveCar_Click);
            // 
            // ChengeCar
            // 
            this.ChengeCar.BackColor = System.Drawing.Color.MidnightBlue;
            this.ChengeCar.Enabled = false;
            this.ChengeCar.ForeColor = System.Drawing.Color.White;
            this.ChengeCar.Location = new System.Drawing.Point(135, 384);
            this.ChengeCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChengeCar.Name = "ChengeCar";
            this.ChengeCar.Size = new System.Drawing.Size(111, 39);
            this.ChengeCar.TabIndex = 1;
            this.ChengeCar.Text = "החלפת רכב";
            this.ChengeCar.UseVisualStyleBackColor = false;
            this.ChengeCar.Click += new System.EventHandler(this.ChengeCar_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.MidnightBlue;
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(372, 384);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(111, 39);
            this.exit.TabIndex = 110;
            this.exit.Text = "ביטול";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Eng_cap
            // 
            this.Eng_cap.Location = new System.Drawing.Point(108, 130);
            this.Eng_cap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Eng_cap.Name = "Eng_cap";
            this.Eng_cap.ReadOnly = true;
            this.Eng_cap.Size = new System.Drawing.Size(160, 22);
            this.Eng_cap.TabIndex = 139;
            // 
            // DateLastCarCare
            // 
            this.DateLastCarCare.Enabled = false;
            this.DateLastCarCare.Location = new System.Drawing.Point(27, 252);
            this.DateLastCarCare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateLastCarCare.Name = "DateLastCarCare";
            this.DateLastCarCare.Size = new System.Drawing.Size(241, 22);
            this.DateLastCarCare.TabIndex = 138;
            // 
            // DateTest
            // 
            this.DateTest.Enabled = false;
            this.DateTest.Location = new System.Drawing.Point(27, 220);
            this.DateTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateTest.Name = "DateTest";
            this.DateTest.Size = new System.Drawing.Size(241, 22);
            this.DateTest.TabIndex = 137;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(276, 260);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 17);
            this.label16.TabIndex = 136;
            this.label16.Text = "תאריך טיפול אחרון";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(335, 228);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 17);
            this.label17.TabIndex = 135;
            this.label17.Text = "תאריך טסט";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(332, 193);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 17);
            this.label15.TabIndex = 134;
            this.label15.Text = "\'קילומטראז";
            // 
            // textMilege
            // 
            this.textMilege.Location = new System.Drawing.Point(108, 190);
            this.textMilege.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textMilege.Name = "textMilege";
            this.textMilege.Size = new System.Drawing.Size(160, 22);
            this.textMilege.TabIndex = 133;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(349, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 132;
            this.label12.Text = "נפח מנוע";
            // 
            // textCarYear
            // 
            this.textCarYear.Location = new System.Drawing.Point(108, 160);
            this.textCarYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCarYear.Name = "textCarYear";
            this.textCarYear.ReadOnly = true;
            this.textCarYear.Size = new System.Drawing.Size(160, 22);
            this.textCarYear.TabIndex = 131;
            // 
            // textModel
            // 
            this.textModel.Location = new System.Drawing.Point(108, 101);
            this.textModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textModel.Name = "textModel";
            this.textModel.ReadOnly = true;
            this.textModel.Size = new System.Drawing.Size(160, 22);
            this.textModel.TabIndex = 130;
            // 
            // textManufacture
            // 
            this.textManufacture.Location = new System.Drawing.Point(108, 71);
            this.textManufacture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textManufacture.Name = "textManufacture";
            this.textManufacture.ReadOnly = true;
            this.textManufacture.Size = new System.Drawing.Size(160, 22);
            this.textManufacture.TabIndex = 129;
            // 
            // textMVANo
            // 
            this.textMVANo.Location = new System.Drawing.Point(108, 42);
            this.textMVANo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textMVANo.Name = "textMVANo";
            this.textMVANo.ReadOnly = true;
            this.textMVANo.Size = new System.Drawing.Size(160, 22);
            this.textMVANo.TabIndex = 128;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 127;
            this.label9.Text = "שנת הרכב";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(384, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 17);
            this.label10.TabIndex = 126;
            this.label10.Text = "דגם";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(380, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 125;
            this.label11.Text = "יצרן";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(355, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 124;
            this.label13.Text = "MVA \'מס";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(359, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 17);
            this.label14.TabIndex = 123;
            this.label14.Text = "מס\' רכב";
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Location = new System.Drawing.Point(473, 201);
            this.textPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.ReadOnly = true;
            this.textPhoneNumber.Size = new System.Drawing.Size(132, 22);
            this.textPhoneNumber.TabIndex = 122;
            // 
            // textStreet
            // 
            this.textStreet.Location = new System.Drawing.Point(473, 169);
            this.textStreet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textStreet.Name = "textStreet";
            this.textStreet.ReadOnly = true;
            this.textStreet.Size = new System.Drawing.Size(132, 22);
            this.textStreet.TabIndex = 121;
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(473, 137);
            this.textCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCity.Name = "textCity";
            this.textCity.ReadOnly = true;
            this.textCity.Size = new System.Drawing.Size(132, 22);
            this.textCity.TabIndex = 120;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(473, 74);
            this.textLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textLastName.Name = "textLastName";
            this.textLastName.ReadOnly = true;
            this.textLastName.Size = new System.Drawing.Size(132, 22);
            this.textLastName.TabIndex = 119;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(473, 42);
            this.textFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.ReadOnly = true;
            this.textFirstName.Size = new System.Drawing.Size(132, 22);
            this.textFirstName.TabIndex = 118;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(473, 10);
            this.textID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(132, 22);
            this.textID.TabIndex = 117;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(623, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 116;
            this.label6.Text = "מס\' טלפון";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 115;
            this.label5.Text = "רחוב";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(665, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 114;
            this.label4.Text = "עיר";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 113;
            this.label3.Text = "שם משפחה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 112;
            this.label2.Text = "שם פרטי";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 111;
            this.label1.Text = "ת\"ז";
            // 
            // textRole
            // 
            this.textRole.Location = new System.Drawing.Point(473, 105);
            this.textRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textRole.Name = "textRole";
            this.textRole.ReadOnly = true;
            this.textRole.Size = new System.Drawing.Size(132, 22);
            this.textRole.TabIndex = 141;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(645, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 142;
            this.label7.Text = "תפקיד";
            // 
            // ReturnCar
            // 
            this.ReturnCar.BackColor = System.Drawing.Color.MidnightBlue;
            this.ReturnCar.Enabled = false;
            this.ReturnCar.ForeColor = System.Drawing.Color.White;
            this.ReturnCar.Location = new System.Drawing.Point(253, 384);
            this.ReturnCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReturnCar.Name = "ReturnCar";
            this.ReturnCar.Size = new System.Drawing.Size(111, 39);
            this.ReturnCar.TabIndex = 143;
            this.ReturnCar.Text = "החזרת רכב";
            this.ReturnCar.UseVisualStyleBackColor = false;
            this.ReturnCar.Click += new System.EventHandler(this.ReturnCar_Click);
            // 
            // textLicensNum
            // 
            this.textLicensNum.Location = new System.Drawing.Point(108, 10);
            this.textLicensNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textLicensNum.Name = "textLicensNum";
            this.textLicensNum.Size = new System.Drawing.Size(160, 22);
            this.textLicensNum.TabIndex = 144;
            this.textLicensNum.TextChanged += new System.EventHandler(this.textLicensNum_TextChanged);
            // 
            // dataGridCars
            // 
            this.dataGridCars.AllowUserToResizeColumns = false;
            this.dataGridCars.AllowUserToResizeRows = false;
            this.dataGridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCars.ColumnHeadersVisible = false;
            this.dataGridCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridCarsWork});
            this.dataGridCars.Location = new System.Drawing.Point(108, 42);
            this.dataGridCars.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridCars.Name = "dataGridCars";
            this.dataGridCars.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridCars.RowHeadersVisible = false;
            this.dataGridCars.RowHeadersWidth = 62;
            this.dataGridCars.Size = new System.Drawing.Size(161, 182);
            this.dataGridCars.TabIndex = 165;
            this.dataGridCars.Visible = false;
            this.dataGridCars.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCars_CellContentDoubleClick);
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
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "nameLastName";
            this.name.Name = "name";
            // 
            // License
            // 
            this.License.HeaderText = "רישוי";
            this.License.MinimumWidth = 8;
            this.License.Name = "License";
            this.License.ReadOnly = true;
            this.License.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.License.Width = 90;
            // 
            // dataWorkers
            // 
            this.dataWorkers.AllowUserToResizeColumns = false;
            this.dataWorkers.AllowUserToResizeRows = false;
            this.dataWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataWorkers.ColumnHeadersVisible = false;
            this.dataWorkers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.License,
            this.name});
            this.dataWorkers.Location = new System.Drawing.Point(441, 36);
            this.dataWorkers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataWorkers.Name = "dataWorkers";
            this.dataWorkers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataWorkers.RowHeadersVisible = false;
            this.dataWorkers.RowHeadersWidth = 62;
            this.dataWorkers.Size = new System.Drawing.Size(293, 182);
            this.dataWorkers.TabIndex = 164;
            this.dataWorkers.Visible = false;
            this.dataWorkers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataWorkers_CellContentDoubleClick);
            // 
            // AddCarToWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 438);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridCars);
            this.Controls.Add(this.dataWorkers);
            this.Controls.Add(this.textLicensNum);
            this.Controls.Add(this.ReturnCar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textRole);
            this.Controls.Add(this.Eng_cap);
            this.Controls.Add(this.DateLastCarCare);
            this.Controls.Add(this.DateTest);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textMilege);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textCarYear);
            this.Controls.Add(this.textModel);
            this.Controls.Add(this.textManufacture);
            this.Controls.Add(this.textMVANo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textPhoneNumber);
            this.Controls.Add(this.textStreet);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.ChengeCar);
            this.Controls.Add(this.GiveCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "AddCarToWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddCarToWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataWorkers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GiveCar;
        private System.Windows.Forms.Button ChengeCar;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox Eng_cap;
        private System.Windows.Forms.DateTimePicker DateLastCarCare;
        private System.Windows.Forms.DateTimePicker DateTest;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textMilege;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textCarYear;
        private System.Windows.Forms.TextBox textModel;
        private System.Windows.Forms.TextBox textManufacture;
        private System.Windows.Forms.TextBox textMVANo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.TextBox textStreet;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textRole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ReturnCar;
        private System.Windows.Forms.TextBox textLicensNum;
        private System.Windows.Forms.DataGridView dataGridCars;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridCarsWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn License;
        private System.Windows.Forms.DataGridView dataWorkers;
    }
}