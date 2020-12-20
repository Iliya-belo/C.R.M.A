namespace FinalProject.CEO
{
    partial class SendPurporseOfCar
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
			this.purporseOfCar = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nameWorker = new System.Windows.Forms.TextBox();
			this.MailText = new System.Windows.Forms.TextBox();
			this.send = new System.Windows.Forms.Button();
			this.exit = new System.Windows.Forms.Button();
			this.dataWorkers = new System.Windows.Forms.DataGridView();
			this.License = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataWorkers)).BeginInit();
			this.SuspendLayout();
			// 
			// purporseOfCar
			// 
			this.purporseOfCar.FormattingEnabled = true;
			this.purporseOfCar.Items.AddRange(new object[] {
            "השכרה",
            "מכירה"});
			this.purporseOfCar.Location = new System.Drawing.Point(49, 44);
			this.purporseOfCar.Name = "purporseOfCar";
			this.purporseOfCar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.purporseOfCar.Size = new System.Drawing.Size(237, 21);
			this.purporseOfCar.TabIndex = 0;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.MidnightBlue;
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(300, 44);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(155, 21);
			this.label10.TabIndex = 141;
			this.label10.Text = "מטרת הרכב";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.MidnightBlue;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(300, 94);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 21);
			this.label1.TabIndex = 142;
			this.label1.Text = "שם המזכיר/ה";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.MidnightBlue;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(300, 157);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(155, 21);
			this.label2.TabIndex = 143;
			this.label2.Text = "הערות לעובד";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nameWorker
			// 
			this.nameWorker.Location = new System.Drawing.Point(49, 94);
			this.nameWorker.Margin = new System.Windows.Forms.Padding(2);
			this.nameWorker.Name = "nameWorker";
			this.nameWorker.ReadOnly = true;
			this.nameWorker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.nameWorker.Size = new System.Drawing.Size(237, 20);
			this.nameWorker.TabIndex = 144;
			// 
			// MailText
			// 
			this.MailText.Location = new System.Drawing.Point(49, 157);
			this.MailText.Margin = new System.Windows.Forms.Padding(2);
			this.MailText.Multiline = true;
			this.MailText.Name = "MailText";
			this.MailText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.MailText.Size = new System.Drawing.Size(237, 170);
			this.MailText.TabIndex = 158;
			// 
			// send
			// 
			this.send.BackColor = System.Drawing.Color.MidnightBlue;
			this.send.ForeColor = System.Drawing.Color.White;
			this.send.Location = new System.Drawing.Point(11, 346);
			this.send.Name = "send";
			this.send.Size = new System.Drawing.Size(97, 35);
			this.send.TabIndex = 159;
			this.send.Text = "שלח";
			this.send.UseVisualStyleBackColor = false;
			this.send.Click += new System.EventHandler(this.send_Click);
			// 
			// exit
			// 
			this.exit.BackColor = System.Drawing.Color.MidnightBlue;
			this.exit.ForeColor = System.Drawing.Color.White;
			this.exit.Location = new System.Drawing.Point(199, 346);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(97, 35);
			this.exit.TabIndex = 160;
			this.exit.Text = "ביטול";
			this.exit.UseVisualStyleBackColor = false;
			this.exit.Click += new System.EventHandler(this.exit_Click);
			// 
			// dataWorkers
			// 
			this.dataWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataWorkers.ColumnHeadersVisible = false;
			this.dataWorkers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.License,
            this.name});
			this.dataWorkers.Location = new System.Drawing.Point(49, 94);
			this.dataWorkers.Name = "dataWorkers";
			this.dataWorkers.ReadOnly = true;
			this.dataWorkers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dataWorkers.RowHeadersVisible = false;
			this.dataWorkers.RowHeadersWidth = 62;
			this.dataWorkers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataWorkers.Size = new System.Drawing.Size(237, 148);
			this.dataWorkers.TabIndex = 165;
			this.dataWorkers.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataWorkers_CellMouseDoubleClick);
			// 
			// License
			// 
			this.License.HeaderText = "ID";
			this.License.MinimumWidth = 8;
			this.License.Name = "License";
			this.License.ReadOnly = true;
			this.License.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.License.Width = 90;
			// 
			// name
			// 
			this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.name.HeaderText = "nameLastName";
			this.name.Name = "name";
			this.name.ReadOnly = true;
			this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// SendPurporseOfCar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(519, 393);
			this.ControlBox = false;
			this.Controls.Add(this.dataWorkers);
			this.Controls.Add(this.exit);
			this.Controls.Add(this.send);
			this.Controls.Add(this.MailText);
			this.Controls.Add(this.nameWorker);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.purporseOfCar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "SendPurporseOfCar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.SendPurporseOfCar_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataWorkers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox purporseOfCar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameWorker;
        private System.Windows.Forms.TextBox MailText;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DataGridView dataWorkers;
		private System.Windows.Forms.DataGridViewTextBoxColumn License;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
	}
}