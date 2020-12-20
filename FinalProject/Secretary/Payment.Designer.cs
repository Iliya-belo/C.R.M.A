namespace FinalProject.Secretary
{
    partial class Payment
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
			this.BTNpay = new System.Windows.Forms.Button();
			this.BTNcancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.ToPay = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// BTNpay
			// 
			this.BTNpay.BackColor = System.Drawing.Color.MidnightBlue;
			this.BTNpay.ForeColor = System.Drawing.Color.White;
			this.BTNpay.Location = new System.Drawing.Point(72, 62);
			this.BTNpay.Name = "BTNpay";
			this.BTNpay.Size = new System.Drawing.Size(75, 35);
			this.BTNpay.TabIndex = 0;
			this.BTNpay.Text = "שלם";
			this.BTNpay.UseVisualStyleBackColor = false;
			this.BTNpay.Click += new System.EventHandler(this.BTNpay_Click);
			// 
			// BTNcancel
			// 
			this.BTNcancel.BackColor = System.Drawing.Color.MidnightBlue;
			this.BTNcancel.ForeColor = System.Drawing.Color.White;
			this.BTNcancel.Location = new System.Drawing.Point(153, 62);
			this.BTNcancel.Name = "BTNcancel";
			this.BTNcancel.Size = new System.Drawing.Size(75, 35);
			this.BTNcancel.TabIndex = 1;
			this.BTNcancel.Text = "ביטול";
			this.BTNcancel.UseVisualStyleBackColor = false;
			this.BTNcancel.Click += new System.EventHandler(this.BTNcancel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(195, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "סכום לתשלום";
			// 
			// ToPay
			// 
			this.ToPay.Location = new System.Drawing.Point(48, 27);
			this.ToPay.Name = "ToPay";
			this.ToPay.Size = new System.Drawing.Size(125, 20);
			this.ToPay.TabIndex = 3;
			// 
			// Payment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(302, 109);
			this.ControlBox = false;
			this.Controls.Add(this.ToPay);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BTNcancel);
			this.Controls.Add(this.BTNpay);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Payment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNpay;
        private System.Windows.Forms.Button BTNcancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ToPay;
    }
}