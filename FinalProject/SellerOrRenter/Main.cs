using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.Classes;
using FinalProject.Database;

namespace FinalProject.SellerOrRenter
{
	public partial class Main : Form
	{
		// Fields
		private Lot[] carsFromParking;
		private int start, limit;
		private ContractDocument sc = null;
		private PreaparationOfTheCar pr = null;
		private DbMySQL dataB = DbMySQL.Instance;
		private string query, basequery;
		private Employee worker;
		private bool[] contract;

		// Constructor
		public Main(string id, string role)
		{
			InitializeComponent();
			worker = dataB.AuthenticateEmployee(id);
			if (role == "נציג מכירות")
			{
				limit = 500;
				start = 0;
			}
			else
			{
				start = 500;
				limit = 1000;
			}
			contract = dataB.EmptyContracts(start, limit);
		}

		// Loading Form entities
		private void MainSeller_Load(object sender, EventArgs e)
		{
			InsertParkList();
			fillInformation();
		}

		// Utility function for loading the Form
		public void InsertParkList()
		{
			if (worker.Role.Equals("נציג מכירות"))
			{
				carsFromParking = dataB.ParkingListSell();
				basequery = query = dataB.CheckQueryForSeller(worker.Role);
			}
			else if (worker.Role.Equals("נציג השכרה"))
			{
				carsFromParking = dataB.ParkingListRend();
				basequery = query = dataB.CheckQueryForSeller(worker.Role);
			}
			else
			{
				MessageBox.Show("שגיה");
			}
			if (query == basequery && query == "")
			{
				MessageBox.Show("שגיה");
				this.Close();
			}
		}

		// Utility function for loading the Form
		public void fillInformation()
		{
			if (carsFromParking == null)
			{
				InsertParkList();
				dataGridParklCars.RowCount = 1;
				dataGridParklCars.Rows.Clear();
				return;
			}
			dataGridParklCars.RowCount = carsFromParking.Length;
			dataGridParklCars.ColumnCount = 9;
			for (int i = 0; i < carsFromParking.Length; i++)
			{
				dataGridParklCars[0, i].Value = carsFromParking[i].TypeCar.LicenseNumber;
				dataGridParklCars[1, i].Value = carsFromParking[i].TypeCar.Model + "/" + carsFromParking[i].TypeCar.Brand;
				dataGridParklCars[2, i].Value = carsFromParking[i].TypeCar.Mileage;
				dataGridParklCars[3, i].Value = carsFromParking[i].TypeCar.CodeInCar;
				dataGridParklCars[4, i].Value = carsFromParking[i].TypeCar.Engi_capacity;
				dataGridParklCars[5, i].Value = carsFromParking[i].TypeCar.YearOfCar;
				dataGridParklCars[6, i].Value = carsFromParking[i].TypeCar.Color;
				dataGridParklCars[7, i].Value = carsFromParking[i].TypeCar.Price;
				dataGridParklCars[8, i].Value = carsFromParking[i].ParkingNumber;
			}
		}

		// Menu Strip options
		private void testToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			sc = new ContractDocument(this);
			sc.ShowDialog();
		}

		private void רשימתמשימותToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pr = new PreaparationOfTheCar(contract, start, limit, this);
			pr.ShowDialog();
		}

		private void התנתקToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void dataGridParklCars_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			Car tmp = carsFromParking[e.RowIndex].TypeCar;
			Frm fr = new Frm(tmp, contract, start, limit, this, worker);
			fr.ShowDialog();
		}
		///////////////////////////////////

		// Entering search queries
		private void Find_Click(object sender, EventArgs e)
		{
			string nameText = "", infotext = "";
			if (LicenseNum.Text.Length > 0)
			{
				nameText += "licenseNum-";
				infotext += LicenseNum.Text + "-";
			}
			if (milegeNum.Text.Length > 0)
			{
				nameText += "milegeNum-";
				infotext += milegeNum.Text + "-";
			}
			if (prices.Text.Length > 0)
			{
				nameText += "prices-";
				infotext += prices.Text + "-";
			}
			if (Brand_Model.Text.Length > 0)
			{
				nameText += "Brand_Model-";
				infotext += Brand_Model.Text + "-";
			}

			if (LicenseNum.Text.Length == 0 && milegeNum.Text.Length == 0 && prices.Text.Length == 0 && Brand_Model.Text.Length == 0)
				query = basequery;
			else
				query += dataB.bildQueryForSellerOrRenter(nameText, infotext);
			carsFromParking = dataB.ParkingList(query);
			fillInformation();
		}
	}
}
