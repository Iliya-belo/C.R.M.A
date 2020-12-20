namespace FinalProject.Tester_SafetyManager
{
    partial class InsertForm
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
			this.insertCar = new System.Windows.Forms.Button();
			this.UpdateCar = new System.Windows.Forms.Button();
			this.Exit = new System.Windows.Forms.Button();
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
			this.licensNum = new System.Windows.Forms.TextBox();
			this.InfoOfMission = new System.Windows.Forms.TextBox();
			this.EventNum = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TextComponent = new System.Windows.Forms.TextBox();
			this.CurrantActivity = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.GarageNum = new System.Windows.Forms.ComboBox();
			this.ComponentsReady = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimeInsertGarage = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.CostumerInfo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// insertCar
			// 
			this.insertCar.BackColor = System.Drawing.Color.MidnightBlue;
			this.insertCar.ForeColor = System.Drawing.Color.White;
			this.insertCar.Location = new System.Drawing.Point(12, 367);
			this.insertCar.Name = "insertCar";
			this.insertCar.Size = new System.Drawing.Size(126, 48);
			this.insertCar.TabIndex = 0;
			this.insertCar.Text = "הכנסת למסך";
			this.insertCar.UseVisualStyleBackColor = false;
			this.insertCar.Click += new System.EventHandler(this.insertCar_Click);
			// 
			// UpdateCar
			// 
			this.UpdateCar.BackColor = System.Drawing.Color.MidnightBlue;
			this.UpdateCar.ForeColor = System.Drawing.Color.White;
			this.UpdateCar.Location = new System.Drawing.Point(144, 367);
			this.UpdateCar.Name = "UpdateCar";
			this.UpdateCar.Size = new System.Drawing.Size(123, 48);
			this.UpdateCar.TabIndex = 1;
			this.UpdateCar.Text = "עדכון רכב קיים";
			this.UpdateCar.UseVisualStyleBackColor = false;
			this.UpdateCar.Click += new System.EventHandler(this.UpdateCar_Click);
			// 
			// Exit
			// 
			this.Exit.BackColor = System.Drawing.Color.MidnightBlue;
			this.Exit.ForeColor = System.Drawing.Color.White;
			this.Exit.Location = new System.Drawing.Point(273, 367);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(141, 48);
			this.Exit.TabIndex = 2;
			this.Exit.Text = "ביטול";
			this.Exit.UseVisualStyleBackColor = false;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// Eng_cap
			// 
			this.Eng_cap.Location = new System.Drawing.Point(910, 104);
			this.Eng_cap.Margin = new System.Windows.Forms.Padding(2);
			this.Eng_cap.Name = "Eng_cap";
			this.Eng_cap.ReadOnly = true;
			this.Eng_cap.Size = new System.Drawing.Size(121, 20);
			this.Eng_cap.TabIndex = 116;
			// 
			// DateLastCarCare
			// 
			this.DateLastCarCare.Enabled = false;
			this.DateLastCarCare.Location = new System.Drawing.Point(849, 203);
			this.DateLastCarCare.Name = "DateLastCarCare";
			this.DateLastCarCare.Size = new System.Drawing.Size(182, 20);
			this.DateLastCarCare.TabIndex = 115;
			// 
			// DateTest
			// 
			this.DateTest.Enabled = false;
			this.DateTest.Location = new System.Drawing.Point(849, 177);
			this.DateTest.Name = "DateTest";
			this.DateTest.Size = new System.Drawing.Size(182, 20);
			this.DateTest.TabIndex = 114;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(1036, 209);
			this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(108, 13);
			this.label16.TabIndex = 113;
			this.label16.Text = "תאריך טיפול אחרון";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(1080, 183);
			this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(64, 13);
			this.label17.TabIndex = 112;
			this.label17.Text = "תאריך טסט";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(1078, 155);
			this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(66, 13);
			this.label15.TabIndex = 111;
			this.label15.Text = "\'קילומטראז";
			// 
			// textMilege
			// 
			this.textMilege.Location = new System.Drawing.Point(910, 152);
			this.textMilege.Margin = new System.Windows.Forms.Padding(2);
			this.textMilege.Name = "textMilege";
			this.textMilege.Size = new System.Drawing.Size(121, 20);
			this.textMilege.TabIndex = 110;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(1091, 106);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(53, 13);
			this.label12.TabIndex = 109;
			this.label12.Text = "נפח מנוע";
			// 
			// textCarYear
			// 
			this.textCarYear.Location = new System.Drawing.Point(910, 128);
			this.textCarYear.Margin = new System.Windows.Forms.Padding(2);
			this.textCarYear.Name = "textCarYear";
			this.textCarYear.ReadOnly = true;
			this.textCarYear.Size = new System.Drawing.Size(121, 20);
			this.textCarYear.TabIndex = 108;
			// 
			// textModel
			// 
			this.textModel.Location = new System.Drawing.Point(910, 80);
			this.textModel.Margin = new System.Windows.Forms.Padding(2);
			this.textModel.Name = "textModel";
			this.textModel.ReadOnly = true;
			this.textModel.Size = new System.Drawing.Size(121, 20);
			this.textModel.TabIndex = 107;
			// 
			// textManufacture
			// 
			this.textManufacture.Location = new System.Drawing.Point(910, 56);
			this.textManufacture.Margin = new System.Windows.Forms.Padding(2);
			this.textManufacture.Name = "textManufacture";
			this.textManufacture.ReadOnly = true;
			this.textManufacture.Size = new System.Drawing.Size(121, 20);
			this.textManufacture.TabIndex = 106;
			// 
			// textMVANo
			// 
			this.textMVANo.Location = new System.Drawing.Point(910, 32);
			this.textMVANo.Margin = new System.Windows.Forms.Padding(2);
			this.textMVANo.Name = "textMVANo";
			this.textMVANo.ReadOnly = true;
			this.textMVANo.Size = new System.Drawing.Size(121, 20);
			this.textMVANo.TabIndex = 105;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(1086, 131);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(58, 13);
			this.label9.TabIndex = 104;
			this.label9.Text = "שנת הרכב";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(1117, 83);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(27, 13);
			this.label10.TabIndex = 103;
			this.label10.Text = "דגם";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(1114, 59);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(30, 13);
			this.label11.TabIndex = 102;
			this.label11.Text = "יצרן";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(1095, 35);
			this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(49, 13);
			this.label13.TabIndex = 101;
			this.label13.Text = "MVA \'מס";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(1098, 9);
			this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(46, 13);
			this.label14.TabIndex = 100;
			this.label14.Text = "מס\' רכב";
			// 
			// licensNum
			// 
			this.licensNum.Location = new System.Drawing.Point(910, 8);
			this.licensNum.Margin = new System.Windows.Forms.Padding(2);
			this.licensNum.Name = "licensNum";
			this.licensNum.ReadOnly = true;
			this.licensNum.Size = new System.Drawing.Size(121, 20);
			this.licensNum.TabIndex = 117;
			// 
			// InfoOfMission
			// 
			this.InfoOfMission.Location = new System.Drawing.Point(428, 35);
			this.InfoOfMission.Margin = new System.Windows.Forms.Padding(2);
			this.InfoOfMission.Multiline = true;
			this.InfoOfMission.Name = "InfoOfMission";
			this.InfoOfMission.ReadOnly = true;
			this.InfoOfMission.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.InfoOfMission.Size = new System.Drawing.Size(322, 195);
			this.InfoOfMission.TabIndex = 171;
			this.InfoOfMission.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// EventNum
			// 
			this.EventNum.Location = new System.Drawing.Point(620, 7);
			this.EventNum.Margin = new System.Windows.Forms.Padding(2);
			this.EventNum.Name = "EventNum";
			this.EventNum.ReadOnly = true;
			this.EventNum.Size = new System.Drawing.Size(131, 20);
			this.EventNum.TabIndex = 170;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(754, 41);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 166;
			this.label3.Text = "פרטי משימה";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(767, 11);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 165;
			this.label2.Text = "מס\' אירוע";
			// 
			// TextComponent
			// 
			this.TextComponent.Location = new System.Drawing.Point(12, 62);
			this.TextComponent.Margin = new System.Windows.Forms.Padding(2);
			this.TextComponent.Name = "TextComponent";
			this.TextComponent.Size = new System.Drawing.Size(244, 20);
			this.TextComponent.TabIndex = 178;
			// 
			// CurrantActivity
			// 
			this.CurrantActivity.Location = new System.Drawing.Point(12, 38);
			this.CurrantActivity.Margin = new System.Windows.Forms.Padding(2);
			this.CurrantActivity.Name = "CurrantActivity";
			this.CurrantActivity.Size = new System.Drawing.Size(244, 20);
			this.CurrantActivity.TabIndex = 177;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(284, 65);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 13);
			this.label6.TabIndex = 175;
			this.label6.Text = "כמות המרכיבים";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(287, 41);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(84, 13);
			this.label7.TabIndex = 174;
			this.label7.Text = "פעילות נוכחית";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(308, 14);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(63, 13);
			this.label8.TabIndex = 173;
			this.label8.Text = "מספר מוסך";
			// 
			// GarageNum
			// 
			this.GarageNum.FormattingEnabled = true;
			this.GarageNum.Location = new System.Drawing.Point(12, 12);
			this.GarageNum.Name = "GarageNum";
			this.GarageNum.Size = new System.Drawing.Size(244, 21);
			this.GarageNum.TabIndex = 182;
			// 
			// ComponentsReady
			// 
			this.ComponentsReady.Location = new System.Drawing.Point(12, 86);
			this.ComponentsReady.Margin = new System.Windows.Forms.Padding(2);
			this.ComponentsReady.Name = "ComponentsReady";
			this.ComponentsReady.Size = new System.Drawing.Size(244, 20);
			this.ComponentsReady.TabIndex = 184;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(294, 89);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 183;
			this.label1.Text = "כמות שהורכב";
			// 
			// dateTimeInsertGarage
			// 
			this.dateTimeInsertGarage.Location = new System.Drawing.Point(12, 111);
			this.dateTimeInsertGarage.Name = "dateTimeInsertGarage";
			this.dateTimeInsertGarage.Size = new System.Drawing.Size(244, 20);
			this.dateTimeInsertGarage.TabIndex = 185;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(261, 117);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 13);
			this.label4.TabIndex = 186;
			this.label4.Text = "תאריך כניסה למוסך";
			// 
			// CostumerInfo
			// 
			this.CostumerInfo.BackColor = System.Drawing.Color.MidnightBlue;
			this.CostumerInfo.ForeColor = System.Drawing.Color.White;
			this.CostumerInfo.Location = new System.Drawing.Point(910, 229);
			this.CostumerInfo.Name = "CostumerInfo";
			this.CostumerInfo.Size = new System.Drawing.Size(85, 35);
			this.CostumerInfo.TabIndex = 187;
			this.CostumerInfo.Text = "פרטי לקוח";
			this.CostumerInfo.UseVisualStyleBackColor = false;
			this.CostumerInfo.Click += new System.EventHandler(this.CostumerInfo_Click);
			// 
			// InsertForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1155, 427);
			this.ControlBox = false;
			this.Controls.Add(this.CostumerInfo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dateTimeInsertGarage);
			this.Controls.Add(this.ComponentsReady);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.GarageNum);
			this.Controls.Add(this.TextComponent);
			this.Controls.Add(this.CurrantActivity);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.InfoOfMission);
			this.Controls.Add(this.EventNum);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.licensNum);
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
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.UpdateCar);
			this.Controls.Add(this.insertCar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "InsertForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.InsertForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertCar;
        private System.Windows.Forms.Button UpdateCar;
        private System.Windows.Forms.Button Exit;
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
        private System.Windows.Forms.TextBox licensNum;
        private System.Windows.Forms.TextBox InfoOfMission;
        private System.Windows.Forms.TextBox EventNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextComponent;
        private System.Windows.Forms.TextBox CurrantActivity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox GarageNum;
        private System.Windows.Forms.TextBox ComponentsReady;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeInsertGarage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CostumerInfo;
    }
}