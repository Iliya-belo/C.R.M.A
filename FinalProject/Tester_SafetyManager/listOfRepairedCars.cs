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
	public partial class listOfRepairedCars : Form
	{
		// Fields
		private Database.DbMySQL dataB = Database.DbMySQL.Instance;
		private Mission[] missions;
		private Contract contract;
        private Contract[] contracts;
        private MissionList[] missionLists;
		private Garage garage;
		private Garage[] garageList;

		// Constructor
		public listOfRepairedCars()
		{
			InitializeComponent();
		}

		// Loading Form entities
		private void listOfRepairedCars_Load(object sender, EventArgs e)
		{
			missions = dataB.AllEvents();
			missionLists = dataB.missionEvents();
			garageList = dataB.ListOfGarage();
			for (int i = 0; i < garageList.Length; i++)
				comboGarageID.Items.Add(garageList[i].GarageName + "-" + garageList[i].ID);
			GridLoad();
		}

		// Utility function for loading the Form
		private void GridLoad()
		{
			if (missionLists == null || missions == null)
			{
				dataGridEvents.RowCount = 1;
				dataGridEvents.Rows.Clear();
				return;
			}
			dataGridEvents.ColumnCount = 9;
            contracts = new Contract[missionLists.Length];
			dataGridEvents.RowCount = missionLists.Length;
			for (int i = 0; i < missionLists.Length; i++)
			{
				TimeSpan ts = DateTime.Now - missionLists[i].DaysOfState;
                {
                    contract = dataB.ContractToMissionListFind(missions[i].ContractNumber);
                    contracts[i] = contract;
                }
				garage = dataB.ListOfCarsInGarage(contract.CosCar.LicenseNumber);
				dataGridEvents[0, i].Value = missionLists[i].EventNumber;
				dataGridEvents[1, i].Value = contract.CosCar.LicenseNumber;
				dataGridEvents[2, i].Value = contract.CosCar.Brand + "/" + contract.CosCar.Model;
				dataGridEvents[3, i].Value = garage.GarageName + "-" + garage.ID;
				dataGridEvents[4, i].Value = missionLists[i].CurrentActivity;
				dataGridEvents[5, i].Value = (int)ts.TotalDays;
				if (missionLists[i].ReadyDays > missionLists[i].DaysOfState)
				{
					TimeSpan tr = DateTime.Now - missionLists[i].ReadyDays;
					dataGridEvents[6, i].Value = (int)tr.TotalDays;
				}
				else
					dataGridEvents[6, i].Value = 0;
				dataGridEvents[7, i].Value = missionLists[i].ComponentStatusReady + "/" + missionLists[i].ComponentStatusToOrder;
				dataGridEvents[8, i].Value = missionLists[i].ComponentStatusToOrder - missionLists[i].ComponentStatusReady;
			}
		}

		// Menu Strip options
		private void TSMMain_Click(object sender, EventArgs e)
		{
			this.Hide();
			TSMMain tm = new TSMMain();
			tm.Closed += (s, args) => this.Close();
			tm.ShowDialog();
		}

		private void updateRepairedParts_Click(object sender, EventArgs e)
		{
			updateRepairedParts urp = new updateRepairedParts();
			urp.ShowDialog();
		}

		private void carToGarage_Click(object sender, EventArgs e)
		{
			this.Hide();
			insertCarToGarage ictg = new insertCarToGarage();
			ictg.Closed += (s, args) => this.Close();
			ictg.ShowDialog();
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

		// Entering search queries
		private string FindSearch(string query)
		{
			string strName = "", strInfo = "";
			if (textEventNumber.Text != string.Empty)
			{
				if (!checkNumbers(textEventNumber.Text))
					return "";
				strName = "textEventNumber:";
				strInfo = textEventNumber.Text + ":";
			}
			if (textLicenseNumber.Text != string.Empty)
			{
				if (!checkNumbers(textLicenseNumber.Text))
					return "";
				strName += "textLicenseNumber:";
				strInfo += textLicenseNumber.Text + ":";
			}
			if (textBrandAndModel.Text != string.Empty)
			{
				strName += "textBrandAndModel:";
				strInfo += textLicenseNumber.Text + ":";
			}
			if (comboGarageID.Text.Length > 0 && comboGarageID.SelectedValue.ToString() != "")
			{
				strName += "comboGarageID:";
				strInfo += textLicenseNumber.Text + ":";
			}
			if (textDaysOfState.Text != string.Empty)
			{
				if (!checkNumbers(textDaysOfState.Text))
					return "";
				int days = int.Parse(textDaysOfState.Text);
				DateTime date = DateTime.Now - TimeSpan.FromDays(days);
				strName += "textDaysOfState:";
				strInfo += new DateTime(date.Year, date.Month, date.Day).ToString("yyyy-MM-dd") + ":";
			}
			if (textReadyDays.Text != string.Empty)
			{
				if (!checkNumbers(textReadyDays.Text))
					return "";
				DateTime date = DateTime.Now;
				int days = int.Parse(textReadyDays.Text);
				date.AddDays(days * -1);
				strName += "textReadyDays:";
				strInfo += new DateTime(date.Year, date.Month, date.Day).ToString("yyyy-MM-dd") + ":";
			}
			if (checkReadyDays.CheckState != CheckState.Unchecked)
				strName += "Ready:";

			return query + dataB.bildqueryListOfRepairedCars(strName, strInfo);
		}

		// Pressing the search button
		private void btnSearch_Click(object sender, EventArgs e)
		{
			string query = dataB.bildBaseQueryListOfRepairedCars("missions");
			if (query == "") return;
			missions = dataB.AllEvents(FindSearch(query));
			query = dataB.bildBaseQueryListOfRepairedCars("missionLists");
			if (query == "") return;
			query = FindSearch(query) + ")";
			if (query == "")
				return;
			missionLists = dataB.missionEvents(query);
			EmptySearchValues();
			GridLoad();
		}

		// Empties search values
		private void EmptySearchValues()
		{
			textEventNumber.Text = "";
			textLicenseNumber.Text = "";
			textBrandAndModel.Text = "";
			comboGarageID.Text = "";
			textDaysOfState.Text = "";
			textReadyDays.Text = "";
			checkReadyDays.CheckState = CheckState.Unchecked;
		}

		// Opens the InsertForm Form after double-clicking on cell
		private void dataGridEvents_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
           MessageBox.Show(missions[e.RowIndex].CarNumber.ToString(), contracts[e.RowIndex].CosCar.LicenseNumber.ToString());
          InsertForm fi = new InsertForm(missions[e.RowIndex], contracts[e.RowIndex].CosCar.LicenseNumber.ToString(), missionLists[e.RowIndex]);
           fi.ShowDialog();
        }

		private bool checkNumbers(string number)
		{
			int num;
			if (int.TryParse(number, out num) && num > 0)
				return true;
			return false;
		}
	}
}
