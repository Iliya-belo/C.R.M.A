using FinalProject.Classes;
using FinalProject.Shared_Forms;
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
	public partial class exceptionsList : Form
	{
		// Fields
		private Database.DbMySQL dataB = Database.DbMySQL.Instance;
		private static JobManager.exceptionsList _el;
		private Mission[] missions;
		private MissionList[] missionsList;

		// Constructor
		public exceptionsList()
		{
			InitializeComponent();
			if (_el == null)
				_el = new JobManager.exceptionsList();
		}

		// Loading Form entities
		private void exceptionsList_Load(object sender, EventArgs e)
		{
			missions = dataB.AllEvents();
			missionsList = dataB.missionEvents();
			_el.GridLoad(dataGridEvents, missionsList, missions);
		}

		// Menu Strip options
		private void mainCEO_Click(object sender, EventArgs e)
		{
			this.Hide();
			mainCEO mc = new mainCEO();
			mc.Closed += (s, args) => this.Close();
			mc.ShowDialog();
		}

		private void listOfCarsToBeApproved_Click(object sender, EventArgs e)
		{
			this.Hide();
			listOfCarsToBeApproved loctba = new listOfCarsToBeApproved();
			loctba.Closed += (s, args) => this.Close();
			loctba.ShowDialog();
		}

		private void listOfMeetings_Click(object sender, EventArgs e)
		{
			this.Hide();
			listOfMeetings lom = new listOfMeetings();
			lom.Closed += (s, args) => this.Close();
			lom.ShowDialog();
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
			if (query == "") return;

			missions = dataB.AllEvents(FindSearch(query));
			query = dataB.bildBaseQueryListOfRepairedCars("missionLists");
			if (query == "") return;

			query = FindSearch(query) + ")";
			missionsList = dataB.missionEvents(query);
			_el.GridLoad(dataGridEvents, missionsList, missions);
		}

		private void textEventNumber_TextChanged(object sender, EventArgs e)
		{
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

		private void textGaragePhoneNumber_TextChanged(object sender, EventArgs e)
		{
			if (textGaragePhoneNumber.Text.Length == 10)
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

		private void WorkCar_Click(object sender, EventArgs e)
		{
			AddCarToWorker ad = new AddCarToWorker();
			ad.ShowDialog();
		}

		// Opens the Car History after double-clicking on a cell
		private void dataGridEvents_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			CarHistory ch = new CarHistory(Convert.ToInt32(dataGridEvents[1, e.RowIndex].Value));
			ch.ShowDialog();
		}
	}
}
