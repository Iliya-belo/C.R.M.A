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
	public partial class insertCarToGarage : Form
	{
		// Fields
		private Database.DbMySQL dataB = Database.DbMySQL.Instance;
		private Mission[] missions;
		private Costumer person;

		// Constructor
		public insertCarToGarage()
		{
			InitializeComponent();
		}

		// Loading Form entities
		public void insertCarToGarage_Load(object sender, EventArgs e)
		{
			missions = dataB.MissionFinish();
			GridLoad();
		}

		// Utility function for loading the Form
		private void GridLoad()
		{
			if (missions == null)
			{
				dataGridPersonalMission.RowCount = 1;
				dataGridPersonalMission.Rows.Clear();
				return;
			}
			dataGridPersonalMission.ColumnCount = 6;
			dataGridPersonalMission.RowCount = missions.Length;
			for (int i = 0; i < missions.Length; i++)
			{
				person = dataB.FindCostumer(missions[i].ContractNumber);

				dataGridPersonalMission[0, i].Value = missions[i].MissionID;
				dataGridPersonalMission[1, i].Value = missions[i].Time.ToShortDateString();
				dataGridPersonalMission[2, i].Value = missions[i].CarNumber;
				dataGridPersonalMission[3, i].Value = person.LastName + " " + person.FirstName;
				dataGridPersonalMission[4, i].Value = person.PhoneNumber;
				dataGridPersonalMission[5, i].Value = missions[i].Status;
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

		private void listOfRepairedCars_Click(object sender, EventArgs e)
		{
			this.Hide();
			listOfRepairedCars lorc = new listOfRepairedCars();
			lorc.Closed += (s, args) => this.Close();
			lorc.ShowDialog();
		}

		private void updateRepairedParts_Click(object sender, EventArgs e)
		{
			updateRepairedParts urp = new updateRepairedParts();
			urp.ShowDialog();
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

		// Pressing the search button
		private void btnSearch_Click(object sender, EventArgs e)
		{
			string query = FindSearch();
			if (query == "")
				return;
			missions = dataB.MissionFinishQ(query);
			GridLoad();
		}

		// Entering search queries
		private string FindSearch()
		{
			string strName = "", strinfo = "";
			if (textEventNumber.Text != string.Empty)
			{
				if (!checkNumbers(textEventNumber.Text))
					return "";
				strName += "textEventNumber-";
				strinfo += textEventNumber.Text + "-";
			}
			if (textLicenseNumber.Text != string.Empty)
			{

				if (!checkNumbers(textEventNumber.Text))
					return "";
				strName += "textLicenseNumber-";
				strinfo += textLicenseNumber.Text + "-";
			}
			return dataB.bildQuetFindCarToGarage(strName, strinfo);
		}

		// Opens the InsertForm Form after double-clicking on cell
		private void dataGridPersonalMission_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			InsertForm fi = new InsertForm((object)missions[e.RowIndex], dataGridPersonalMission[2, e.RowIndex].Value.ToString(), this);
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
