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

namespace FinalProject.Tester_SafetyManager
{
	public partial class updateRepairedParts : Form
	{
		// Fields
		private Database.DbMySQL dataB = Database.DbMySQL.Instance;
		private Contract[] contracts;
		private int[] EventNumbers;
		private Contract carAfterFix;

		// Constructor
		public updateRepairedParts()
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

		// Loads Form entities
		private void updateRepairedParts_Load(object sender, EventArgs e)
		{
			contracts = dataB.ListOfCarsInGarage(ref EventNumbers);
			if (contracts != null)
				for (int i = 0; i < contracts.Length; i++)
					comboLicenseNumber.Items.Add(contracts[i].CosCar.LicenseNumber + " אירוע-" + EventNumbers[i]);
			else
			{
				MessageBox.Show("אין אורעוים פאילים");
				this.Close();
			}
		}

		// Changes the index in comboBox
		private void comboLicenseNumber_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboLicenseNumber.SelectedValue != "")
				LoadInfo(contracts[comboLicenseNumber.SelectedIndex]);
		}

		// Loads info into textBoxes
		private void LoadInfo(Contract contract)
		{
			carAfterFix = contract;
			textMVANumber.Text = contract.CosCar.MVANumber;
			textManufacture.Text = contract.CosCar.Brand;
			textModel.Text = contract.CosCar.Model;
		}

		// Pressing Update button
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			double price;
			if (!IsNotEmpty()) return;
			if (!double.TryParse(textRepairPrice.Text, out price))
			{
				MessageBox.Show("מחיר לא תקין");
				return;
			}
			if (comboStatus.SelectedItem == "רכב מושבת")
			{
				carAfterFix.CosCar.Status = comboStatus.SelectedItem.ToString();
				if (textStatusDescription.Text != "")
					carAfterFix.CosCar.DataOfCar = textStatusDescription.Text;
				dataB.UpdateCar(carAfterFix.CosCar);
			}
			if (comboStatus.SelectedItem == "ממתין לשטיפה")
			{
				if (textStatusDescription.Text != "")
				{
					dataB.InsertMission(null, carAfterFix.ContractNumber, comboStatus.SelectedItem.ToString(), textStatusDescription.Text);
					dataB.insertExitGarage(carAfterFix.CosCar.LicenseNumber, 0);
				}
			}
			if (comboStatus.SelectedItem == "רכב מוכן")
			{
				if (textStatusDescription.Text != "")
				{
					dataB.InsertMission(null, carAfterFix.ContractNumber, "החזרת רכב ללקוח לאחר תיקון", textStatusDescription.Text);
					//dataB.insertExitGarage(carAfterFix.CosCar.LicenseNumber, 0);
					dataB.finishCarInMissionList(EventNumbers[comboLicenseNumber.SelectedIndex], 0);
				}
			}
			dataB.InsertCarAfterFix(EventNumbers[comboLicenseNumber.SelectedIndex], comboStatus.SelectedItem.ToString(), price, comboCharge.SelectedItem.ToString(), carAfterFix.CosCar.LicenseNumber);
			MessageBox.Show("עודכן בהצלחה");
			Close();
		}

		// Checks for empty textBoxes and comboBoxes
		private bool IsNotEmpty()
		{
			return comboLicenseNumber.SelectedIndex >= 0 && textMVANumber.Text != "" && textManufacture.Text != "" && textModel.Text != "" && comboStatus.SelectedIndex >= 0
				&& textStatusDescription.Text != "" && textRepairPrice.Text != "" && comboCharge.SelectedIndex >= 0;
		}

		// Pressing Close button
		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
