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
	public partial class monthlyExecptionsHours : Form
	{
		// Fields
		private Database.DbMySQL dataB = Database.DbMySQL.Instance;
		private ExceptionHours[] listOfExceptionHours;
        private ManagerSettings[] managerSettings;
        private DateTime ts;

		// Constructor
		public monthlyExecptionsHours()
		{
			InitializeComponent();
		}

		// Loading Form entities
		private void monthlyExecptionsHours_Load(object sender, EventArgs e)
		{
             managerSettings=dataB.InsertOptions();
			for (int i = 1; i <= DateTime.Now.Month; i++)
				comboMonths.Items.Add(i);
			ts = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
			listOfExceptionHours = dataB.ListOfWorkingHours(ts,managerSettings[1].Limitation);
			GridLoad(dataGridExceptionsHours, listOfExceptionHours);
		}

		// Utility function for loading the Form
		public void GridLoad(DataGridView dgw, ExceptionHours[] exceptionHours)
		{
             managerSettings=dataB.InsertOptions();
			if (exceptionHours == null)
			{
				dgw.RowCount = 1;
				dgw.Rows.Clear();
				return;
			}
			dgw.RowCount = exceptionHours.Length;
			dgw.ColumnCount = 7;
			for (int i = 0; i < exceptionHours.Length; i++)
			{
				int houers = 0;
				int totalsum = exceptionHours[i].Mission.Houers;
				int exceptionTime = totalsum - 510;
				while (totalsum >= 60)
				{
					houers++;
					totalsum -= 60;
				}
				dgw[0, i].Value = exceptionHours[i].Employee.ID;
				dgw[1, i].Value = exceptionHours[i].Employee.FirstName;
				dgw[2, i].Value = exceptionHours[i].Employee.LastName;
				dgw[3, i].Value = exceptionHours[i].Mission.MissionID;
				dgw[4, i].Value = exceptionHours[i].Employee.PhoneNumber;
				dgw[5, i].Value = houers.ToString("0") + ":" + totalsum.ToString("00");
				houers = 0;
				while (exceptionTime >= 60)
				{
					houers++;
					exceptionTime -= 60;
				}
				dgw[6, i].Value = houers.ToString("0") + ":" + exceptionTime.ToString("00");
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

		private void exceptionsList_Click(object sender, EventArgs e)
		{
			this.Hide();
			exceptionsList el = new exceptionsList();
			el.Closed += (s, args) => this.Close();
			el.ShowDialog();
		}

		private void btnExitAccount_Click(object sender, EventArgs e)
		{
			Close();
		}
		///////////////////////////////////

		// Pressing the search button
		private void btnSearch_Click(object sender, EventArgs e)
		{
			listOfExceptionHours = dataB.ExceptionHoursList(FindSearch());
			GridLoad(dataGridExceptionsHours, listOfExceptionHours);
		}

		// Entering search queries
		private string FindSearch()
		{
			string strName = "", strInfo = "";
			if (textID.Text != string.Empty)
			{
				strName += "textID:";
				strInfo += textID.Text + ":";
			}
			if (textRole.Text != string.Empty)
			{
				strName += "textRole:";
				strInfo += textRole.Text + ":";
			}
			if (textPhoneNumber.Text != string.Empty)
			{
				strName += "textPhoneNumber:";
				strInfo += textRole.Text + ":";
			}
			if (comboMonths.SelectedIndex >= 0)
			{
				strName += "comboMonths:";
				strInfo += new DateTime(DateTime.Now.Year, int.Parse(comboMonths.Text), 1).ToString("yyyy-MM-dd") + ":" + new DateTime(DateTime.Now.Year, int.Parse(comboMonths.Text), DateTime.DaysInMonth(DateTime.Now.Year, int.Parse(comboMonths.Text))).ToString("yyyy-MM-dd") + ":";
			}
			return dataB.bildQueryToFindEmployee(strName, strInfo,managerSettings[1].Limitation);
		}
	}
}
