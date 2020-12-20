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

namespace FinalProject.CEO
{
	public partial class listOfCarsToBeApproved : Form
	{
		// Fields
		private Database.DbMySQL dataB = Database.DbMySQL.Instance;
		private Car[] listOfCars;

		// Constructor
		public listOfCarsToBeApproved()
		{
			InitializeComponent();
		}

		// Loading Form entities
		private void listOfCarsToBeApproved_Load(object sender, EventArgs e)
		{
			listOfCars = dataB.ListOfCandidateCars();
			GridLoad();
		}

		// Utility function for loading the Form
		private void GridLoad()
		{
			if (listOfCars == null)
			{
				dataGridCars.RowCount = 1;
				dataGridCars.Rows.Clear();
				return;
			}
			dataGridCars.RowCount = listOfCars.Length;
			dataGridCars.ColumnCount = 8;

			for (int i = 0; i < listOfCars.Length; i++)
			{
				dataGridCars[0, i].Value = listOfCars[i].LicenseNumber;
				dataGridCars[1, i].Value = listOfCars[i].Brand + "/" + listOfCars[i].Model;
				dataGridCars[2, i].Value = listOfCars[i].Mileage;
				dataGridCars[3, i].Value = "רכב ממתין לאישור";
				dataGridCars[4, i].Value = listOfCars[i].Price;
				dataGridCars[5, i].Value = listOfCars[i].Color;
			}
			// Originally it doesn't display the last row for buttons because
			// DataGridViewButtonColumn does not display the text in the button on the last row
			// Source: https://stackoverflow.com/questions/30256811/datagridview-button-text-not-appearing-despite-usecolumntextforbuttontext-set-to
			dataGridCars[6, listOfCars.Length - 1].Value = "אושר";
			dataGridCars[7, listOfCars.Length - 1].Value = "לא אושר";
		}

		// Menu Strip options
		private void mainCEO_Click(object sender, EventArgs e)
		{
			this.Hide();
			mainCEO mc = new mainCEO();
			mc.Closed += (s, args) => this.Close();
			mc.ShowDialog();
		}

		private void listOfMeetings_Click(object sender, EventArgs e)
		{
			this.Hide();
			listOfMeetings lom = new listOfMeetings();
			lom.Closed += (s, args) => this.Close();
			lom.ShowDialog();
		}

		private void exceptionList_Click(object sender, EventArgs e)
		{
			this.Hide();
			exceptionsList el = new exceptionsList();
			el.Closed += (s, args) => this.Close();
			el.ShowDialog();
		}

		private void monthlyExceptionsHours_Click(object sender, EventArgs e)
		{
			this.Hide();
			monthlyExecptionsHours meh = new monthlyExecptionsHours();
			meh.Closed += (s, args) => this.Close();
			meh.ShowDialog();
		}

		private void btnExitAccount_Click(object sender, EventArgs e)
		{
			Close();
		}
		///////////////////////////////////

		// Checks if the cell is a button
		private bool IsButton(DataGridViewColumn cell)
		{
			return cell is DataGridViewButtonColumn;
		}

		// Executes command after clicking on Accept Button or Refuse Button
		private void dataGridCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var senderGrid = (DataGridView)sender;
			var cell = senderGrid.Columns[e.ColumnIndex];
			if (IsButton(cell) && e.RowIndex >= 0)
			{
				var licenseNumber = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;
				if (cell.Name == "Accept")
				{
					dataB.InsertCar(listOfCars[e.RowIndex]);
					dataB.DeleteCandidateCarAfterAccept(licenseNumber);
					dataB.ChangeCandidateCarInfoAfterAccept(licenseNumber);
					MessageBox.Show("אושר בהצלחה");
					listOfCarsToBeApproved_Load(null, EventArgs.Empty);
				}

				if (cell.Name == "Refuse")
				{
					SendPurporseOfCar sn = new SendPurporseOfCar(listOfCars[e.RowIndex], this);
					sn.ShowDialog();
					listOfCarsToBeApproved_Load(null, EventArgs.Empty);
				}
			}
		}

		// Pressing the search button
		private void btnSearch_Click(object sender, EventArgs e)
		{
			listOfCars = dataB.CandidateCarList(FindSearch());
			GridLoad();
		}

		// Entering search queries
		private string FindSearch()
		{
			string strName = "", strInfo = "";
			if (textLicenseNumber.Text != string.Empty)
			{
				strName += "textLicenseNumber:";
				strInfo += textLicenseNumber.Text + ":";
			}
			if (textMilege.Text != string.Empty)
			{
				strName += "textMilege:";
				strInfo += textMilege.Text + ":";
			}
			if (textBrandAndModel.Text != string.Empty)
			{
				strName += "textBrandAndModel:";
				strInfo += textBrandAndModel.Text + ":";
			}
			if (textPrice.Text != string.Empty)
			{
				strName += "textPrice:";
				strInfo += textPrice.Text + ":";
			}
			return dataB.bildQueryFindCartoApproved(strName, strInfo);
		}

		private void WorkCar_Click(object sender, EventArgs e)
		{
			AddCarToWorker ad = new AddCarToWorker();
			ad.ShowDialog();
		}
	}
}
