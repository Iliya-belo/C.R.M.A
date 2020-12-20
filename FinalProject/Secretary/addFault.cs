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

namespace FinalProject
{
	public partial class addFault : Form
	{
		// Fields
		private Database.DbMySQL dataB = Database.DbMySQL.Instance;
		private Contract[] con;

		// Constructors /////////////////
		public addFault()
		{
			InitializeComponent();
		}

		public addFault(object contract)
		{
			InitializeComponent();
			con = new Contract[1];
			con[0] = (Contract)contract;
			comboCarNo.Items.Add(con[0].CosCar.LicenseNumber.ToString());
			comboCarNo.Text = con[0].CosCar.LicenseNumber.ToString();
			FillInfo(con[0]);
		}
		/////////////////////////////////

		// Pressing "Escape" key to close the Form
		protected override bool ProcessDialogKey(Keys keyData)
		{
			if (ModifierKeys == Keys.None && keyData == Keys.Escape)
			{
				btnClose.PerformClick();
				return true;
			}
			return base.ProcessDialogKey(keyData);
		}

		// Pressing Add button
		private void btnAddFault_Click(object sender, EventArgs e)
		{
            int num;
			if (comboCarNo.Items == null || comboMissionType.Text == "" || textFaultDescription.Text == ""&& textMilege.Text==""&&int.TryParse(textMilege.Text,out num)==false)
			{
				MessageBox.Show("נתון שגוי");
				return;
			}
			dataB.InsertMission(null, con[comboCarNo.SelectedIndex].ContractNumber, comboMissionType.Text, textFaultDescription.Text);
            con[comboCarNo.SelectedIndex].CosCar.Mileage = textMilege.Text;
            con[comboCarNo.SelectedIndex].CosCar.DateOfTest = DateTest.Value;
            dataB.UpdateCar(con[comboCarNo.SelectedIndex].CosCar);
            MessageBox.Show("Added");
			btnClose.PerformClick();
		}

		// Pressing Close button
		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		// Pressing "Enter" key while on textID textField
		private void textID_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			comboCarNo.Items.Clear();
			if (textID.Text.Length != 9)
			{
				MessageBox.Show("Invalid ID");
				return;
			}
			con = dataB.ContractList(textID.Text);
			if (con != null)
			{
				for (int i = 0; i < con.Length; i++)
					comboCarNo.Items.Add(con[i].CosCar.LicenseNumber.ToString());
				FillInfo(con[0]);
			}
		}

		// Fills Constumer info
		private void FillInfo(Contract c)
		{
			textID.Text = c.Person.ID;
			textFirstName.Text = c.Person.FirstName;
			textLastName.Text = c.Person.LastName;
			textCity.Text = c.Person.City;
			textStreet.Text = c.Person.Street;
			textPhoneNumber.Text = c.Person.PhoneNumber;
		}

		// Fills Car info
		private void FillCarInfo(Contract c)
		{
			textMVANo.Text = c.CosCar.MVANumber;
			textManufacture.Text = c.CosCar.Brand;
			textModel.Text = c.CosCar.Model;
			Eng_cap.Text = c.CosCar.Engi_capacity;
			textCarYear.Text = c.CosCar.YearOfCar.ToString();
			textMilege.Text = c.CosCar.Mileage;
			DateTest.Value = c.CosCar.DateOfTest;
			DateLastCarCare.Value = c.CosCar.DateOfLastCarCare;
		}

		// Changes the car information after changing the comboBox options
		private void comboCarNo_SelectedIndexChanged(object sender, EventArgs e)
		{
			FillCarInfo(con[comboCarNo.SelectedIndex]);
		}
	}
}
