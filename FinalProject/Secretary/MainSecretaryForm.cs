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
	public partial class SecretaryMenu : Form
	{
		// Fields
		private DbMySQL dataB = DbMySQL.Instance;
		private Lot[] lot;
		private Contract[] contract;
		private int count;

		// Constructor
		public SecretaryMenu()
		{
			InitializeComponent();
		}

		// Loading Form entities
		private void SecretaryMenu_Load(object sender, EventArgs e)
		{
			All();
			LoadData();
		}

		// Menu Strip options
		private void addEmployee_Click(object sender, EventArgs e)
		{
			addEmployee ae = new addEmployee();
			ae.ShowDialog();
		}

		private void SecretaryMenu_Enter(object sender, EventArgs e)
		{
			Refresh();
		}

		private void addCar_Click(object sender, EventArgs e)
		{
			addCar ac = new addCar();
			ac.ShowDialog();
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

		private void exitAccount_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			ListOfCarAfterFixToPaed lc;
			this.Hide();
			lc = new ListOfCarAfterFixToPaed();
			lc.Closed += (s, args) => this.Close();
			lc.ShowDialog();
		}

		private void ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			listOfPurchasedCars lc = new listOfPurchasedCars();
			lc.Closed += (s, args) => this.Close();
			lc.ShowDialog();
		}

		private void ToolStripMenuItemMetting_Click(object sender, EventArgs e)
		{
			addMeeting ad = new addMeeting();
			ad.ShowDialog();
		}
		///////////////////////////////////

		// Pressing Find button
		private void Find_Click(object sender, EventArgs e)
		{
			ClearRow(count);
			string ch = ChooseBox.SelectedItem.ToString();
			string info = FindTable.Text;
			string quert = dataB.SecuteryMainChouseQueryParking(ch, info);
			if (quert.Equals("מספר שגוי"))
			{
				MessageBox.Show("מספר שגוי");
				return;
			}
			if (quert != "")
			{
				count = 0;
				lot = dataB.ParkingList(quert);
				if (lot == null)
				{
					dataGridGarage.RowCount = 1;
					dataGridGarage.Rows.Clear();
					MessageBox.Show("התוצאה מבוקשת לא נימצאה במערכת");
					All();
					return;
				}
				dataGridGarage.RowCount = lot.Length;
				dataGridGarage.ColumnCount = 6;
				for (int i = 0; i < lot.Length; i++, count++)
				{
					TimeSpan ts = DateTime.Now - lot[i].DaysInLot;
					dataGridGarage[0, i].Value = lot[i].LicenseNumber;
					dataGridGarage[1, i].Value = lot[i].TypeCar.Model + "/" + lot[i].TypeCar.Brand;
					dataGridGarage[2, i].Value = lot[i].TypeCar.Mileage;
					dataGridGarage[3, i].Value = (int)ts.TotalDays;
					dataGridGarage[4, i].Value = lot[i].ParkingNumber;
					dataGridGarage[5, i].Value = lot[i].Comments;
					if (lot[i].TypeCar.PurposeOfCar.Equals("רכב מכירה"))
						ColorsRow(count);
				}
			}
			else if (ChooseBox.SelectedItem.ToString() != "הכל")
				MessageBox.Show("פרמטר שגוי");
			else
				All();
			FindTable.Text = "";
		}

		// Utility function for loading the Form
		public void All()
		{
			lot = dataB.ParkingList();
			count = 0;
			if (lot == null)
			{
				dataGridGarage.RowCount = 1;
				dataGridGarage.Rows.Clear();
				return;
			}
			dataGridGarage.ColumnCount = 6;
			dataGridGarage.RowCount = lot.Length;
			for (int i = 0; i < lot.Length; i++, count++)
			{
				TimeSpan ts = DateTime.Now - lot[i].DaysInLot;
				dataGridGarage[0, i].Value = lot[i].LicenseNumber;
				dataGridGarage[1, i].Value = lot[i].TypeCar.Model + "/" + lot[i].TypeCar.Brand;
				dataGridGarage[2, i].Value = lot[i].TypeCar.Mileage;
				dataGridGarage[3, i].Value = (int)ts.TotalDays;
				dataGridGarage[4, i].Value = lot[i].ParkingNumber;
				dataGridGarage[5, i].Value = lot[i].Comments;
				if (lot[i].TypeCar.PurposeOfCar.Equals("רכב מכירה"))
					ColorsRow(count);
			}
		}

		// Utility function for loading the Form
		public void LoadData()
		{
			contract = dataB.ContractList();
			if (contract == null)
			{
				dataGridCostumer.RowCount = 1;
				dataGridCostumer.Rows.Clear();
				return;
			}
			dataGridCostumer.RowCount = contract.Length;
			dataGridCostumer.ColumnCount = 6;

			for (int i = 0; i < contract.Length; i++)
			{
				dataGridCostumer[0, i].Value = contract[i].CosCar.LicenseNumber;
				dataGridCostumer[1, i].Value = contract[i].CosCar.Model + "/" + contract[i].CosCar.Brand;
				dataGridCostumer[2, i].Value = contract[i].CosCar.Mileage;
				dataGridCostumer[3, i].Value = contract[i].Person.FirstName + " " + contract[i].Person.LastName;
				dataGridCostumer[4, i].Value = contract[i].Person.PhoneNumber;
				dataGridCostumer[5, i].Value = contract[i].CosCar.DateOfTest.ToLongDateString();
			}
			valueLable.Text = "";
		}

		// Fills what is found on query
		public void LoadAnswer(object[] contract)
		{
			dataGridCostumer.ColumnCount = 6;
			dataGridCostumer.RowCount = contract.Length;

			for (int i = 0; i < contract.Length; i++)
			{
				dataGridCostumer[0, i].Value = ((Contract)contract[i]).CosCar.LicenseNumber;
				dataGridCostumer[1, i].Value = ((Contract)contract[i]).CosCar.Model + "/" + ((Contract)contract[i]).CosCar.Brand;
				dataGridCostumer[2, i].Value = ((Contract)contract[i]).CosCar.Mileage;
				dataGridCostumer[3, i].Value = ((Contract)contract[i]).Person.FirstName + " " + ((Contract)contract[i]).Person.LastName;
				dataGridCostumer[4, i].Value = ((Contract)contract[i]).Person.PhoneNumber;
				dataGridCostumer[5, i].Value = ((Contract)contract[i]).CosCar.DateOfTest.ToLongDateString();
			}
		}

		// Opens the Fault Form after double-clicking on constumer Cell
		private void dataGridCostumer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			contract[0] = dataB.ContractCar(dataGridCostumer[0, e.RowIndex].Value.ToString());

			addFault af = new addFault(contract[0]);
			af.ShowDialog();
		}


		// Pressing the search button
		private void search_Click(object sender, EventArgs e)
		{
			int index = box.SelectedIndex;
			string info = valueLable.Text;
			string querys = dataB.SecuteryMainChouseQueryCustumers(index, info);
			if (querys.Equals("נתון שגוי"))
			{
				MessageBox.Show("נתון שגוי");
				return;
			}
			if (querys != "")
				contract = dataB.ContractListFind(querys);
			if (contract != null)
				LoadAnswer(contract);
			else
				LoadData();
		}

		// Colors the Row
		public void ColorsRow(int num)
		{
			for (int j = 0; j <= 5; j++)
				dataGridGarage[j, num].Style.BackColor = Color.Honeydew;
		}

		// Clears the Row
		public void ClearRow(int countRow)
		{
			for (int i = 0; i < countRow; i++)
				for (int j = 0; j <= 5; j++)
					dataGridGarage[j, i].Style.BackColor = Color.White;
			dataGridGarage.Refresh();
		}

		// Opens the listOfPurchasedCars Form after double-clicking on car Cell
		private void dataGridGarage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			listOfPurchasedCars lc;
			if (lot[e.RowIndex].TypeCar.PurposeOfCar.Equals("רכב מכירה"))
			{
				this.Hide();
				lc = new listOfPurchasedCars(lot[e.RowIndex]);
				lc.Closed += (s, args) => this.Close();
				lc.ShowDialog();
			}
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			ChengePurporseCar cp = new ChengePurporseCar();
			cp.ShowDialog();
		}
	}
}
