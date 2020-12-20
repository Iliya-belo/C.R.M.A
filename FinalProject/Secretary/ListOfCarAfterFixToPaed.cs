using FinalProject.Classes;
using FinalProject.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Secretary
{
	public partial class ListOfCarAfterFixToPaed : Form
	{
		// Fields
		private Costumer[] listCarToPay, findCar;
		private double[] price, findPrice;
		private int[] FIXNumbers, FindFixNum;
		private DbMySQL dataB = DbMySQL.Instance;

		// Constructor
		public ListOfCarAfterFixToPaed()
		{
			InitializeComponent();
		}

		// Loading Form entities
		private void ListOfCarAfterFixToPaed_Load(object sender, EventArgs e)
		{
			fillData();
		}

		// Utility function for loading the Form
		public void fillData()
		{
			listCarToPay = dataB.FindCustumersToBuy(ref price, ref FIXNumbers);
			if ((listCarToPay != null) && (price != null))
				fillInfo();
			return;
		}

		// Utility function for loading the Form
		private void fillInfo()
		{
			if (listCarToPay == null)
			{
				dataGridCostumers.RowCount = 1;
				dataGridCostumers.Rows.Clear();
				return;
			}
			dataGridCostumers.ColumnCount = 7;
			dataGridCostumers.RowCount = listCarToPay.Length;
			for (int i = 0; i < listCarToPay.Length; i++)
			{
				dataGridCostumers[0, i].Value = listCarToPay[i].ID;
				dataGridCostumers[1, i].Value = listCarToPay[i].FirstName;
				dataGridCostumers[2, i].Value = listCarToPay[i].LastName;
				dataGridCostumers[3, i].Value = listCarToPay[i].City + "/" + listCarToPay[i].Street;
				dataGridCostumers[4, i].Value = listCarToPay[i].PhoneNumber;
				dataGridCostumers[5, i].Value = price[i];
			}
			dataGridCostumers[6, listCarToPay.Length - 1].Value = "תשלום";
		}

		// Menu Strip options
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
			this.Hide();
			SecretaryMenu lc = new SecretaryMenu();
			lc.Closed += (s, args) => this.Close();
			lc.ShowDialog();
		}

		private void addEmployee_Click(object sender, EventArgs e)
		{
			addEmployee ae = new addEmployee();
			ae.ShowDialog();
		}

		private void קביעתפגישותToolStripMenuItem_Click(object sender, EventArgs e)
		{
			addMeeting ad = new addMeeting();
			ad.ShowDialog();
		}

		private void רשימתרכבימכירהToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			listOfPurchasedCars lc = new listOfPurchasedCars();
			lc.Closed += (s, args) => this.Close();
			lc.ShowDialog();
		}
		///////////////////////////////////

		// Opens the Payment Form after clicking on Accept Button
		private void dataGridCostumers_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var senderGrid = (DataGridView)sender;
			var cell = senderGrid.Columns[e.ColumnIndex];
			if (IsButton(cell) && e.RowIndex >= 0)
			{
				if (cell.Name == "Accept")
				{
					Payment p = new Payment(FIXNumbers[e.RowIndex], price[e.RowIndex], this);
					p.ShowDialog();
				}
			}
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			ChengePurporseCar cp = new ChengePurporseCar();
			cp.ShowDialog();
		}

		// Checks if the cell is a button
		private bool IsButton(DataGridViewColumn cell)
		{
			return cell is DataGridViewButtonColumn;
		}

		// Pressing the search button
		private void btnSearch_Click(object sender, EventArgs e)
		{
			string name = "", info = "", query;
			if (priceToByed.Text != "")
			{
				name += "priceToByed:";
				info += priceToByed.Text + ":";
			}
			if (IDCostumer.Text != "")
			{
				name += "IDCostumer:";
				info += IDCostumer.Text + ":";
			}
			query = dataB.BildQueryTofindCostumer(name, info);
			findCar = dataB.FindCustumers(ref findPrice, ref FindFixNum, query);
			ClearInfo();
			if (findPrice != null && FindFixNum != null && findCar != null)
			{
				listCarToPay = findCar;
				FIXNumbers = FindFixNum;
				price = findPrice;
				fillData();
			}
			else
				MessageBox.Show("החיפוש מבוקש לא קיים נא לנשות שוב");
		}

		// Clears info
		private void ClearInfo()
		{
			IDCostumer.Text = "";
			priceToByed.Text = "";
		}
	}
}