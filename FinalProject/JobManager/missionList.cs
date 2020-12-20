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

namespace FinalProject.JobManager
{
	public partial class missionList : Form
	{
		// Fields
		private Database.DbMySQL dataB = Database.DbMySQL.Instance;
		private Mission[] missions;
		private Contract[] contract;
		private MissionList[] missionLists;

		// Constructor
		public missionList()
		{
			InitializeComponent();
		}

		// Loading Form entities
		private void missionList_Load(object sender, EventArgs e)
		{
			missions = dataB.AllEvents();
			missionLists = dataB.missionEvents();
			GridLoadEvents(missions, missionLists);
			missions = dataB.AllMissions();
			GridLoadMissions(missions);
		}

		// Utility function for loading the Form
		private void GridLoadEvents(Mission[] missions, MissionList[] missionLists)
		{
			if (missionLists == null || missions == null)
			{
				dataGridEvents.RowCount = 1;
				dataGridEvents.Rows.Clear();
				return;
			}
			dataGridEvents.ColumnCount = 9;
			dataGridEvents.RowCount = missionLists.Length;
			for (int i = 0; i < missionLists.Length && i < missions.Length; i++)
			{
				TimeSpan ts = DateTime.Now - missionLists[i].DaysOfState;
				contract = dataB.ContractListFind(missions[i].CarNumber);
				dataGridEvents[0, i].Value = missionLists[i].EventNumber;
				dataGridEvents[1, i].Value = contract[0].CosCar.LicenseNumber;
				dataGridEvents[2, i].Value = contract[0].CosCar.Brand + "/" + contract[0].CosCar.Model;
				dataGridEvents[3, i].Value = contract[0].Person.FirstName + " " + contract[0].Person.LastName;
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

		// Utility function for loading the Form
		private void GridLoadMissions(Mission[] missions)
		{
			if (missions == null)
			{
				dataGridMissions.RowCount = 1;
				dataGridMissions.Rows.Clear();
				return;
			}
			dataGridMissions.RowCount = missions.Length;
			dataGridMissions.ColumnCount = 8;
			for (int i = 0; i < missions.Length; i++)
			{
				DateTime ts = DateTime.Now;
				contract = dataB.ContractListFind(missions[i].CarNumber);
				dataGridMissions[0, i].Value = missions[i].MissionID;
				dataGridMissions[1, i].Value = missions[i].CarNumber;
				dataGridMissions[2, i].Value = contract[0].CosCar.Brand + "/" + contract[0].CosCar.Model;
				dataGridMissions[3, i].Value = contract[0].Person.FirstName + " " + contract[0].Person.LastName;
				dataGridMissions[4, i].Value = contract[0].ContractNumber;
				dataGridMissions[5, i].Value = contract[0].Person.PhoneNumber;
				dataGridMissions[6, i].Value = missions[i].Description;
				if (((ts.Date - contract[0].CosCar.DateOfLastCarCare.Date).TotalDays / 365.2425) == 1 && contract[0].CosCar.PurposeOfCar.Equals("רכב השכרה"))
					dataGridMissions[7, i].Value = "טיפול שנתי";
				else
					dataGridMissions[7, i].Value = "טיפול מיוחד";
			}
		}

		#region MenuStrip options

		private void addmission_Click(object sender, EventArgs e)
		{
			addMission am = new addMission();
			am.ShowDialog();
		}

		private void exceptionsList_Click(object sender, EventArgs e)
		{
			this.Hide();
			exceptionsList el = new exceptionsList();
			el.Closed += (s, args) => this.Close();
			el.ShowDialog();
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

		#endregion

		// Entering search queries
		private string FindSearchEvents(string query)
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

		// Entering search queries
		private string FindSearchMissions()
		{
			string strName = "", strInfo = "";
			if (textLicenseNumberM.Text != string.Empty)
			{
				strName += "textLicenseNumberM:";
				strInfo += textLicenseNumberM.Text + ":";
			}
			if (textEventNumberM.Text != string.Empty)
			{
				strName += "textEventNumberM:";
				strInfo += textEventNumberM.Text + ":";
			}
			if (textPhoneNumber.Text != string.Empty)
			{
				strName += "textPhoneNumber:";
				strInfo += textPhoneNumber.Text + ":";
			}
			if (textContractNumber.Text != string.Empty)
			{
				strName += "textContractNumber:";
				strInfo += textContractNumber.Text + ":";
			}
			return dataB.bildQuerySearchMissions(strName, strInfo);
		}

		#region SearchEvents

		private void TextBoxChanged()
		{
			string query = dataB.bildBaseQueryListOfRepairedCars("missions");
			missions = dataB.AllEvents(FindSearchEvents(query));
			query = dataB.bildBaseQueryListOfRepairedCars("missionLists");
			query = FindSearchEvents(query) + ")";
			missionLists = dataB.missionEvents(query);
			GridLoadEvents(missions, missionLists);
		}

		private void textEventNumber_TextChanged(object sender, EventArgs e)
		{
			//if (textEventNumber.Text != string.Empty)
				TextBoxChanged();
		}

		private void textLicenseNumber_TextChanged(object sender, EventArgs e)
		{
			TextBoxChanged();
		}

		private void textBrandAndModel_TextChanged(object sender, EventArgs e)
		{
			TextBoxChanged();
		}

		private void textName_TextChanged(object sender, EventArgs e)
		{
			TextBoxChanged();
		}

		private void textCurrentActivity_TextChanged(object sender, EventArgs e)
		{
			TextBoxChanged();
		}

		private void textDaysOfState_TextChanged(object sender, EventArgs e)
		{
			TextBoxChanged();
		}

		private void textReadyDays_TextChanged(object sender, EventArgs e)
		{
			TextBoxChanged();
		}

		private void textComponentStatusToOrder_TextChanged(object sender, EventArgs e)
		{
			TextBoxChanged();
		}

		private void textComponentStatusReady_TextChanged(object sender, EventArgs e)
		{
			TextBoxChanged();
		}


		#endregion

		// Pressing the search button
		private void btnSearch_Click(object sender, EventArgs e)
		{
			missions = dataB.AllMissions(FindSearchMissions());
			GridLoadMissions(missions);
		}
	}
}
