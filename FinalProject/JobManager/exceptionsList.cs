using FinalProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.JobManager
{
	public partial class exceptionsList : Form
	{
		// Fields
		private Database.DbMySQL dataB = Database.DbMySQL.Instance;
		private Mission[] missions;
		private Contract contract;
        private Contract[] contracts;
        private MissionList[] missionsList;

		// Constructor
		public exceptionsList()
		{
			InitializeComponent();
		}

		// Loading Form entities
		private void exceptionsList_Load(object sender, EventArgs e)
		{
			missions = dataB.AllEvents();
			missionsList = dataB.missionEvents();
			GridLoad(dataGridEvents, missionsList, missions);
		}

		// Utility function for loading the Form
		public void GridLoad(DataGridView dgw, MissionList[] missionLists, Mission[] missions)
		{
			if (missionLists == null || missions == null)
			{
				dgw.RowCount = 1;
				dgw.Rows.Clear();
				return;
			}
			dgw.RowCount = missionLists.Length;
            contracts = new Contract[missionLists.Length];
			dgw.ColumnCount = 9;
			for (int i = 0; i < missionLists.Length; i++)
			{
				TimeSpan ts = DateTime.Now - missionLists[i].DaysOfState;
				string phoneNumber;
				contract = dataB.ContractToMissionListFind(missions[i].ContractNumber);
                contracts[i] = contract;
                phoneNumber = dataB.SelectGaragePhone(missionLists[i].GarageID);

				dgw[0, i].Value = missionLists[i].EventNumber;
				dgw[1, i].Value = contract.CosCar.LicenseNumber;
				dgw[2, i].Value = contract.CosCar.Brand + "/" + contract.CosCar.Model;
				dgw[3, i].Value = contract.Person.FirstName + " " + contract.Person.LastName;
				dgw[4, i].Value = missionLists[i].CurrentActivity;
				dgw[5, i].Value = (int)ts.TotalDays;
				dgw[6, i].Value = phoneNumber;
				dgw[7, i].Value = missionLists[i].ComponentStatusToOrder;
				dgw[8, i].Value = missionLists[i].ComponentStatusReady;
			}
		}

		// Menu Strip options
		private void addMission_Click(object sender, EventArgs e)
		{
			addMission am = new addMission();
			am.ShowDialog();
		}

		private void missionList_Click(object sender, EventArgs e)
		{
			this.Hide();
			missionList ml = new missionList();
			ml.Closed += (s, args) => this.Close();
			ml.ShowDialog();
		}

		private void monthlyExecptionsHours_Click(object sender, EventArgs e)
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
				strName += "textEventNumber:";
				strInfo += textEventNumber.Text + ":";
			}
			if (textLicenseNumber.Text != string.Empty)
			{
				strName += "textLicenseNumber:";
				strInfo += textLicenseNumber.Text + ":";
			}
			if (textBrandAndModel.Text != string.Empty)
			{
				strName += "textBrandAndModel:";
				strInfo += textBrandAndModel.Text + ":";
			}
			if (textName.Text != string.Empty)
			{
				strName += "textName:";
				strInfo += textName.Text + ":";
			}
			if (textCurrentActivity.Text != string.Empty)
			{
				strName += "textEventNumber:";
				strInfo += textEventNumber.Text + ":";
			}
			if (textDaysOfState.Text != string.Empty)
			{
				strName += "textDaysOfState:";
				strInfo += textDaysOfState.Text + ":";
			}
			if (textGaragePhoneNumber.Text != string.Empty)
			{
				strName += "textGaragePhoneNumber:";
				strInfo += textGaragePhoneNumber.Text + ":";
			}
			if (textComponentStatusToOrder.Text != string.Empty)
			{
				strName += "textComponentStatusToOrder:";
				strInfo += textComponentStatusToOrder.Text + ":";
			}
			if (textComponentStatusReady.Text != string.Empty)
			{
				strName += "textComponentStatusReady:";
				strInfo += textComponentStatusReady.Text + ":";
			}
			return query + dataB.bildQueryForExceptionList(strName, strInfo);
		}

		// Updates the DataGridView
		public void TextBoxChanged()
		{
			string query = dataB.bildBaseQueryListOfRepairedCars("missions");
			if (query == "")
				return;
			missions = dataB.AllEvents(FindSearch(query));
			query = dataB.bildBaseQueryListOfRepairedCars("missionLists");
			if (query == "")
				return;
			query = FindSearch(query) + ")";
			missionsList = dataB.missionEvents(query);
			GridLoad(dataGridEvents, missionsList, missions);
		}

		public void textEventNumber_TextChanged(object sender, EventArgs e)
		{
			TextBoxChanged();
		}

		public void textLicenseNumber_TextChanged(object sender, EventArgs e)
		{
			TextBoxChanged();
		}

		public void textBrandAndModel_TextChanged(object sender, EventArgs e)
		{
			TextBoxChanged();
		}

		public void textName_TextChanged(object sender, EventArgs e)
		{
			TextBoxChanged();
		}

		public void textCurrentActivity_TextChanged(object sender, EventArgs e)
		{
			TextBoxChanged();
		}

		public void textDaysOfState_TextChanged(object sender, EventArgs e)
		{
			TextBoxChanged();
		}

		public void textGaragePhoneNumber_TextChanged(object sender, EventArgs e)
		{
			if (textGaragePhoneNumber.Text.Length == 10)
				TextBoxChanged();
		}

		public void textComponentStatusToOrder_TextChanged(object sender, EventArgs e)
		{
			TextBoxChanged();
		}

		public void textComponentStatusReady_TextChanged(object sender, EventArgs e)
		{
			TextBoxChanged();
		}
	}
}
