using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
	public partial class addMeeting : Form
	{
		// Field
		private Database.DbMySQL dataB = Database.DbMySQL.Instance;

		// Constructor
		public addMeeting()
		{
			InitializeComponent();
		}

		// Pressing "Escape" key to close the Form
		protected override bool ProcessDialogKey(Keys keyData)
		{
			if (ModifierKeys == Keys.None && keyData == Keys.Escape)
			{
				Close();
				return true;
			}
			return base.ProcessDialogKey(keyData);
		}

		// Loading Form entities
		private void addMeeting_Load(object sender, EventArgs e)
		{
            DateTime dt = DateTime.Now;
			dateTimeRequest.CustomFormat = "dd/MM/yyyy";
			dateTimeRequest.Value = DateTime.Now;
			dateTimeRequest.MinDate = dt;
            dt = dt.AddMonths(2);
            dateTimeRequest.MaxDate = dt;
            dateTimeRequest.Format = DateTimePickerFormat.Custom;
		}

		// Pressing Add button
		private void btnAddMeeting_Click(object sender, EventArgs e)
		{
			if (textID.Text == string.Empty && textDescription.Text == string.Empty && dateTimeRequest.Value <= DateTime.Now && houersMetting.SelectedItem.Equals(""))
			{
				MessageBox.Show("אחד מהנתונים שגוים");
				return;
			}
			dataB.InsertMeeting(textID.Text, textDescription.Text, dateTimeRequest.Value, houersMetting.SelectedItem.ToString());
			MessageBox.Show("בקשה התקבלה היא עוברת לטיפול אצל מנהל ");
			Close();
		}

		// Pressing Close button
		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
