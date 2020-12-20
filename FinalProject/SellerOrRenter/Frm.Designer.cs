namespace FinalProject.SellerOrRenter
{
    partial class Frm
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
            this.contract = new System.Windows.Forms.Button();
            this.preaparation = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contract
            // 
            this.contract.BackColor = System.Drawing.Color.MidnightBlue;
            this.contract.ForeColor = System.Drawing.Color.White;
            this.contract.Location = new System.Drawing.Point(10, 11);
            this.contract.Name = "contract";
            this.contract.Size = new System.Drawing.Size(93, 52);
            this.contract.TabIndex = 0;
            this.contract.Text = "חוזה";
            this.contract.UseVisualStyleBackColor = false;
            this.contract.Click += new System.EventHandler(this.contract_Click);
            // 
            // preaparation
            // 
            this.preaparation.BackColor = System.Drawing.Color.MidnightBlue;
            this.preaparation.ForeColor = System.Drawing.Color.White;
            this.preaparation.Location = new System.Drawing.Point(146, 11);
            this.preaparation.Name = "preaparation";
            this.preaparation.Size = new System.Drawing.Size(88, 52);
            this.preaparation.TabIndex = 1;
            this.preaparation.Text = "הכנת רכב";
            this.preaparation.UseVisualStyleBackColor = false;
            this.preaparation.Click += new System.EventHandler(this.preaparation_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.MidnightBlue;
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(77, 96);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(98, 49);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "ביטול";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 157);
            this.ControlBox = false;
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.preaparation);
            this.Controls.Add(this.contract);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button contract;
        private System.Windows.Forms.Button preaparation;
        private System.Windows.Forms.Button Exit;
    }
}