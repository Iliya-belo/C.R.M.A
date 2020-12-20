using FinalProject.Classes;
using FinalProject.Database;
using FinalProject.Secretary;
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
	public partial class listOfPurchasedCars : Form
	{
		// Fields
		private DbMySQL dataB = DbMySQL.Instance;
		private Lot[] lotSell = null;
		private Contract[] contractSell = null;

		// Constructors /////////////////
		public listOfPurchasedCars()
		{
			InitializeComponent();
		}

		public listOfPurchasedCars(object sellCar)
		{
			InitializeComponent();
			lotSell = dataB.ParkingList(((Lot)sellCar).LicenseNumber);
		}
		/////////////////////////////////

		// Menu Strip options
		private void addEmployee_Click(object sender, EventArgs e)
		{
			addEmployee ae = new addEmployee();
			ae.ShowDialog();
		}

		private void exitAccount_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void addCar_Click(object sender, EventArgs e)
		{
			addCar ac = new addCar();
			ac.ShowDialog();
		}

		private void returnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			SecretaryMenu sm = new SecretaryMenu();
			sm.Closed += (s, args) => this.Close();
			sm.ShowDialog();
		}

		private void addFault_Click(object sender, EventArgs e)
		{
			addFault af = new addFault();
			af.ShowDialog();
		}

		private void updateEmployee_Click(object sender, EventArgs e)
		{
			updateEmployeeInfo uei = new updateEmployeeInfo();
			uei.ShowDialog();
		}
		private void קביעתפגישותToolStripMenuItem_Click(object sender, EventArgs e)
		{
			addMeeting ad = new addMeeting();
			ad.ShowDialog();
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			ListOfCarAfterFixToPaed lc;
			this.Hide();
			lc = new ListOfCarAfterFixToPaed();
			lc.Closed += (s, args) => this.Close();
			lc.ShowDialog();
		}
		//////////////////////////////////////////////////

		// Loading Form entities
		private void listOfPurchasedCars_Load(object sender, EventArgs e)
		{
			if (lotSell == null)
				lotSell = dataB.ParkingListSell();
			fillSellList(lotSell);
			FillCarSell();
		}

		// Fills the DataGridView with car info
		public void fillSellList(object[] carsLot)
		{
			if (carsLot == null)
			{
				dataGridGarage.RowCount = 1;
				dataGridGarage.Rows.Clear();
				return;
			}
			dataGridGarage.ColumnCount = 8;
			dataGridGarage.RowCount = carsLot.Length;
			for (int i = 0; i < carsLot.Length; i++)
			{
				dataGridGarage[0, i].Value = ((Lot)carsLot[i]).LicenseNumber;
				dataGridGarage[1, i].Value = ((Lot)carsLot[i]).TypeCar.Brand + "/" + ((Lot)carsLot[i]).TypeCar.Model;
				dataGridGarage[2, i].Value = ((Lot)carsLot[i]).TypeCar.Mileage;
				dataGridGarage[3, i].Value = ((Lot)carsLot[i]).Comments;
				dataGridGarage[4, i].Value = ((Lot)carsLot[i]).TypeCar.Price;
                dataGridGarage[5, i].Value = ((Lot)(carsLot[i])).TypeCar.Color;
				dataGridGarage[6, i].Value = "מנוע,גיר";
				dataGridGarage[7, i].Value = ((Lot)carsLot[i]).ParkingNumber;
			}
		}

		// Pressing the Find button in car view
		private void Find_Click(object sender, EventArgs e)
		{
			double num;
			string names = "", info = "", query;
			if (LicenseNum.Text != string.Empty)
			{
				names += "licenseNum-";
				info += LicenseNum.Text + "-";
			}
			if (milegeNum.Text != string.Empty && double.TryParse(milegeNum.Text, out num))
			{
				names += "milegeNum-";
				info += milegeNum.Text + "-";
			}
			if (Brand_Model.Text != string.Empty)
			{
				names += "Brand_Model-";
				info += Brand_Model.Text + "-";
			}
			if (prices.Text != string.Empty && double.TryParse(prices.Text, out num))
			{
				names += "prices-";
				info += prices.Text + "-";
			}
			query = dataB.bildQueryForCarsToSell(names, info);
			lotSell = dataB.ParkingList(query);
			Cleartext();
			if (lotSell != null)
				fillSellList(lotSell);
			else
			{
				MessageBox.Show("נתון שגוי");
				FillCarSell();
			}
		}

		// Fills the DataGridView with costumer info
		public void FillCarSell()
		{
			contractSell = dataB.ContractListSell();
			if (contractSell == null)
			{
				dataGridCostumer.RowCount = 1;
				dataGridCostumer.Rows.Clear();
				return;
			}
			dataGridCostumer.ColumnCount = 8;
			dataGridCostumer.RowCount = contractSell.Length;
			for (int i = 0; i < contractSell.Length; i++)
			{
				dataGridCostumer[0, i].Value = contractSell[i].CosCar.LicenseNumber;
				dataGridCostumer[1, i].Value = contractSell[i].CosCar.Model + "/" + contractSell[i].CosCar.Brand;
				dataGridCostumer[2, i].Value = contractSell[i].Person.ID;
				dataGridCostumer[3, i].Value = contractSell[i].Person.FirstName + " " + contractSell[i].Person.LastName;
				dataGridCostumer[4, i].Value = contractSell[i].ContractNumber;
				dataGridCostumer[5, i].Value = contractSell[i].Person.PhoneNumber;
				dataGridCostumer[6, i].Value = "מנוע,גיר";
				dataGridCostumer[7, i].Value = contractSell[i].ContractTime.ToLongDateString();
			}
		}

		// Pressing the Find button in constumer view
		private void Findbut_Click(object sender, EventArgs e)
		{
			fillAnswer(dataB.ContractListFind(FindQuery()));
		}

		// Finds the data from Database
		public string FindQuery()
		{
			string name = "", info = "";
			if (lIesenceN.Text != string.Empty)
			{
				name += "licenseNum-";
				info += lIesenceN.Text + "-";
			}
			if (IDCust.Text != string.Empty)
			{
				name += "ID-";
				info += IDCust.Text + "-";
			}
			if (phoneNum.Text != string.Empty)
			{
				name += "PhoneNumber-";
				info += phoneNum.Text + "-";
			}
			if (ContractNum.Text != string.Empty)
			{
				name += "ContractNum-";
				info += ContractNum.Text + "-";
			}
			return dataB.bildQueryTofindContractSecutery(name, info);
		}

		// Fills what is found on query
		public void fillAnswer(object[] contract)
		{
			if (contract == null)
			{
				dataGridCostumer.RowCount = 1;
				dataGridCostumer.Rows.Clear();
				MessageBox.Show("לקוח לא קיים");
				Clear();
				return;
			}
			dataGridCostumer.RowCount = contract.Length;
			dataGridCostumer.ColumnCount = 8;
			for (int i = 0; i < contract.Length; i++)
			{
				dataGridCostumer[0, i].Value = ((Contract)contract[i]).CosCar.LicenseNumber;
				dataGridCostumer[1, i].Value = ((Contract)contract[i]).CosCar.Model + "/" + ((Contract)contract[i]).CosCar.Brand;
				dataGridCostumer[2, i].Value = ((Contract)contract[i]).Person.ID;
				dataGridCostumer[3, i].Value = ((Contract)contract[i]).Person.FirstName + " " + ((Contract)contract[i]).Person.LastName;
				dataGridCostumer[4, i].Value = ((Contract)contract[i]).ContractNumber;
				dataGridCostumer[5, i].Value = ((Contract)contract[i]).Person.PhoneNumber;
				dataGridCostumer[6, i].Value = "מנוע,גיר";
				dataGridCostumer[7, i].Value = ((Contract)contract[i]).ContractTime.ToLongDateString();
			}
		}

		// Clears the those parameters
		public void Clear()
		{
			lIesenceN.Text = "";
			IDCust.Text = "";
			phoneNum.Text = "";
			ContractNum.Text = "";
		}

		// Clears the those parameters
		public void Cleartext()
		{
			LicenseNum.Text = "";
			milegeNum.Text = "";
			Brand_Model.Text = "";
			prices.Text = "";
		}

		// Opens the Fault Form after double-clicking on constumer Cell
		private void dataGridCostumer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			contractSell[0] = dataB.ContractCar(dataGridCostumer[0, e.RowIndex].Value.ToString());
			addFault af = new addFault(contractSell[0]);
			af.ShowDialog();
		}

		private void שינוימטרתהרכבToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ChengePurporseCar cp = new ChengePurporseCar();
			cp.ShowDialog();
		}
	}
}
