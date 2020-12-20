namespace FinalProject
{
    partial class addMeeting
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
			this.textDescription = new System.Windows.Forms.TextBox();
			this.textID = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimeRequest = new System.Windows.Forms.DateTimePicker();
			this.btnAddMeeting = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.houersMetting = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// textDescription
			// 
			this.textDescription.Location = new System.Drawing.Point(11, 35);
			this.textDescription.Margin = new System.Windows.Forms.Padding(2);
			this.textDescription.Multiline = true;
			this.textDescription.Name = "textDescription";
			this.textDescription.Size = new System.Drawing.Size(200, 131);
			this.textDescription.TabIndex = 56;
			this.textDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textID
			// 
			this.textID.Location = new System.Drawing.Point(11, 11);
			this.textID.Margin = new System.Windows.Forms.Padding(2);
			this.textID.Name = "textID";
			this.textID.Size = new System.Drawing.Size(200, 20);
			this.textID.TabIndex = 54;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(255, 177);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(73, 13);
			this.label8.TabIndex = 51;
			this.label8.Text = "בקשת תאריך";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(257, 38);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 13);
			this.label7.TabIndex = 50;
			this.label7.Text = "תיאור בקשה";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(245, 14);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 48;
			this.label2.Text = "מס\' ת\"ז המבקש";
			// 
			// dateTimeRequest
			// 
			this.dateTimeRequest.Location = new System.Drawing.Point(11, 171);
			this.dateTimeRequest.Name = "dateTimeRequest";
			this.dateTimeRequest.Size = new System.Drawing.Size(200, 20);
			this.dateTimeRequest.TabIndex = 69;
			this.dateTimeRequest.Value = new System.DateTime(2020, 6, 20, 19, 57, 9, 0);
			// 
			// btnAddMeeting
			// 
			this.btnAddMeeting.BackColor = System.Drawing.Color.MidnightBlue;
			this.btnAddMeeting.ForeColor = System.Drawing.Color.White;
			this.btnAddMeeting.Location = new System.Drawing.Point(89, 226);
			this.btnAddMeeting.Name = "btnAddMeeting";
			this.btnAddMeeting.Size = new System.Drawing.Size(122, 35);
			this.btnAddMeeting.TabIndex = 70;
			this.btnAddMeeting.Text = "הוספה";
			this.btnAddMeeting.UseVisualStyleBackColor = false;
			this.btnAddMeeting.Click += new System.EventHandler(this.btnAddMeeting_Click);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.MidnightBlue;
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(239, 281);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(89, 35);
			this.btnClose.TabIndex = 71;
			this.btnClose.Text = "יציאה";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(265, 200);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 72;
			this.label1.Text = "בקשת שעה";
			// 
			// houersMetting
			// 
			this.houersMetting.FormattingEnabled = true;
			this.houersMetting.Items.AddRange(new object[] {
            "8:15",
            "8:30",
            "8:45",
            "9:00",
            "9:15",
            "9:30",
            "9:45",
            "10:00",
            "10:15",
            "10:30",
            "10:45",
            "11:00",
            "11:15",
            "11:30",
            "11:45",
            "12:00"});
			this.houersMetting.Location = new System.Drawing.Point(11, 200);
			this.houersMetting.Name = "houersMetting";
			this.houersMetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.houersMetting.Size = new System.Drawing.Size(200, 21);
			this.houersMetting.TabIndex = 73;
			// 
			// addMeeting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(340, 328);
			this.Controls.Add(this.houersMetting);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnAddMeeting);
			this.Controls.Add(this.dateTimeRequest);
			this.Controls.Add(this.textDescription);
			this.Controls.Add(this.textID);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "addMeeting";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.addMeeting_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeRequest;
        private System.Windows.Forms.Button btnAddMeeting;
        private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox houersMetting;
    }
}