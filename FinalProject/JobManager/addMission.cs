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

namespace FinalProject.JobManager
{
	public partial class addMission : Form
	{
		// Fields
		private Database.DbMySQL dataB = Database.DbMySQL.Instance;
		private Contract con;

		// Constructor
		public addMission()
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

		// Pressing "Enter" key fills the car info in the Database
		private void textCarNumber_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			if (textCarNumber.Text.Length != 7 && textCarNumber.Text.Length != 8)
			{
				MessageBox.Show("Invalid Car number");
				return;
			}
			con = dataB.ContractCar(textCarNumber.Text);
			if (con != null)
			{
				FillInfo(con);
			}
		}

		// Pressing Add button
		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (CheckInfo())
			{
				MessageBox.Show("חסר נתונים");
				return;
			}
			if (textWorkerID.Text == "")
				dataB.InsertMission(null, con.ContractNumber, textMission.Text, textFaultDescription.Text);
			else
				dataB.InsertMission(textWorkerID.Text, con.ContractNumber, textMission.Text, textFaultDescription.Text);
			MessageBox.Show("Added Mission");
			Close();
		}

		// Pressing Close button
		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		// True when 3 textBoxes are filled
		private bool CheckInfo()
		{
			return (textCarNumber.Text == "" || textMission.Text == "" || textFaultDescription.Text == "");
		}

		// Fills info
		private void FillInfo(Contract con)
		{
			textMVANumber.Text = con.CosCar.MVANumber;
			textManufacture.Text = con.CosCar.Brand;
			textModel.Text = con.CosCar.Model;
			textYearOfCar.Text = con.CosCar.YearOfCar.ToString();
			textMilege.Text = con.CosCar.Mileage;
		}
	}
}
