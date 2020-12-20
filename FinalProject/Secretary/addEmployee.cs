using FinalProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace FinalProject
{
	public partial class addEmployee : Form
	{
		// Fields
		private Database.DbMySQL dataB = Database.DbMySQL.Instance;

		// Constructor
		public addEmployee()
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

		// Pressing Add button
		private void btnAdd_Click(object sender, EventArgs e)
		{
			int num;
			if (textID.Text != "" && textFirstName.Text != "" && textLastName.Text.Length > 4 && textEmail.Text != "" && textCity.SelectedItem.ToString() != "" && textStreet.Text != "" && textHouseNumber.Text != "" && textPhoneNumber.Text.Length == 10 && (!comboRole.Items.Equals(null)) && int.TryParse(textExperience.Text, out num) == true && textPassword.Text != "" && num > 0 && textEmail.Text.Contains("@"))
			{
				hashing password = new hashing();
				dataB.InsertCandidate(new Candidate(textID.Text, textFirstName.Text, textLastName.Text, textEmail.Text, textCity.Text, textStreet.Text, textHouseNumber.Text, textPhoneNumber.Text, comboRole.SelectedItem.ToString(), int.Parse(textExperience.Text), password.encryptPassword(textPassword.Text)));
				MessageBox.Show("מועמד שמור בהצלחה");
				Close();
			}
			else
				MessageBox.Show("נתון שגוי");
			Clear();
		}

		// Clears the textBoxes
		public void Clear()
		{
			textID.Text = string.Empty;
			textFirstName.Text = string.Empty;
			textLastName.Text = string.Empty;
			textEmail.Text = string.Empty;
			textCity.Text = string.Empty;
			textStreet.Text = string.Empty;
			textHouseNumber.Text = string.Empty;
			textPhoneNumber.Text = string.Empty;
			textExperience.Text = string.Empty;
			textPassword.Text = string.Empty;
			comboRole.Text = string.Empty;
		}

		// Pressing Close button
		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
