namespace FinalProject.CEO
{
    partial class ReturnCar
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
			this.Save = new System.Windows.Forms.Button();
			this.EmptyParkngPlaces = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Exit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Save
			// 
			this.Save.BackColor = System.Drawing.Color.MidnightBlue;
			this.Save.ForeColor = System.Drawing.Color.White;
			this.Save.Location = new System.Drawing.Point(12, 79);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(75, 32);
			this.Save.TabIndex = 0;
			this.Save.Text = "שמור";
			this.Save.UseVisualStyleBackColor = false;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// EmptyParkngPlaces
			// 
			this.EmptyParkngPlaces.FormattingEnabled = true;
			this.EmptyParkngPlaces.Location = new System.Drawing.Point(41, 29);
			this.EmptyParkngPlaces.Name = "EmptyParkngPlaces";
			this.EmptyParkngPlaces.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.EmptyParkngPlaces.Size = new System.Drawing.Size(135, 21);
			this.EmptyParkngPlaces.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.MidnightBlue;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(209, 32);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 24;
			this.label2.Text = "מס\' חניה";
			// 
			// Exit
			// 
			this.Exit.BackColor = System.Drawing.Color.MidnightBlue;
			this.Exit.ForeColor = System.Drawing.Color.White;
			this.Exit.Location = new System.Drawing.Point(101, 79);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(75, 32);
			this.Exit.TabIndex = 25;
			this.Exit.Text = "ביטול";
			this.Exit.UseVisualStyleBackColor = false;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// ReturnCar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(270, 123);
			this.ControlBox = false;
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.EmptyParkngPlaces);
			this.Controls.Add(this.Save);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "ReturnCar";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.ReturnCar_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox EmptyParkngPlaces;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exit;
    }
}