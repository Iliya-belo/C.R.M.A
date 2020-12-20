
namespace FinalProject.Shared_Forms
{
	partial class CarHistory
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.carNameLabel = new System.Windows.Forms.Label();
			this.dataGridCarHistory = new System.Windows.Forms.DataGridView();
			this.EventNumber1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LicenseNumber1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BrandModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ConponentStatusToOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCarHistory)).BeginInit();
			this.SuspendLayout();
			// 
			// carNameLabel
			// 
			this.carNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.carNameLabel.Location = new System.Drawing.Point(8, 6);
			this.carNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.carNameLabel.Name = "carNameLabel";
			this.carNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.carNameLabel.Size = new System.Drawing.Size(615, 50);
			this.carNameLabel.TabIndex = 0;
			this.carNameLabel.Text = "היסטוריה לרכב ";
			this.carNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridCarHistory
			// 
			this.dataGridCarHistory.AllowUserToResizeColumns = false;
			this.dataGridCarHistory.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridCarHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridCarHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridCarHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventNumber1,
            this.LicenseNumber1,
            this.BrandModel,
            this.EventDate,
            this.ConponentStatusToOrder});
			this.dataGridCarHistory.EnableHeadersVisualStyles = false;
			this.dataGridCarHistory.Location = new System.Drawing.Point(12, 59);
			this.dataGridCarHistory.Name = "dataGridCarHistory";
			this.dataGridCarHistory.ReadOnly = true;
			this.dataGridCarHistory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dataGridCarHistory.RowHeadersVisible = false;
			this.dataGridCarHistory.RowHeadersWidth = 62;
			this.dataGridCarHistory.Size = new System.Drawing.Size(610, 290);
			this.dataGridCarHistory.TabIndex = 38;
			// 
			// EventNumber1
			// 
			this.EventNumber1.HeaderText = "מס\' אירוע";
			this.EventNumber1.MinimumWidth = 8;
			this.EventNumber1.Name = "EventNumber1";
			this.EventNumber1.ReadOnly = true;
			this.EventNumber1.Width = 60;
			// 
			// LicenseNumber1
			// 
			this.LicenseNumber1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.LicenseNumber1.HeaderText = "רישוי";
			this.LicenseNumber1.MinimumWidth = 8;
			this.LicenseNumber1.Name = "LicenseNumber1";
			this.LicenseNumber1.ReadOnly = true;
			// 
			// BrandModel
			// 
			this.BrandModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.BrandModel.HeaderText = "יצרן/דגם";
			this.BrandModel.MinimumWidth = 8;
			this.BrandModel.Name = "BrandModel";
			this.BrandModel.ReadOnly = true;
			// 
			// EventDate
			// 
			this.EventDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.EventDate.HeaderText = "תאריך אירוע";
			this.EventDate.MinimumWidth = 8;
			this.EventDate.Name = "EventDate";
			this.EventDate.ReadOnly = true;
			// 
			// ConponentStatusToOrder
			// 
			this.ConponentStatusToOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ConponentStatusToOrder.HeaderText = "כמות רכיבים";
			this.ConponentStatusToOrder.MinimumWidth = 8;
			this.ConponentStatusToOrder.Name = "ConponentStatusToOrder";
			this.ConponentStatusToOrder.ReadOnly = true;
			// 
			// CarHistory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 361);
			this.Controls.Add(this.dataGridCarHistory);
			this.Controls.Add(this.carNameLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CarHistory";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.CarHistory_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridCarHistory)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label carNameLabel;
		private System.Windows.Forms.DataGridView dataGridCarHistory;
		private System.Windows.Forms.DataGridViewTextBoxColumn EventNumber1;
		private System.Windows.Forms.DataGridViewTextBoxColumn LicenseNumber1;
		private System.Windows.Forms.DataGridViewTextBoxColumn BrandModel;
		private System.Windows.Forms.DataGridViewTextBoxColumn EventDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn ConponentStatusToOrder;
	}
}