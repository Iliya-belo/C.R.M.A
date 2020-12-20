using FinalProject.Classes;
using FinalProject.Database;
using FinalProject.Driver;
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
	public partial class jobManagerMain : Form
	{
		// Fields
		private DbMySQL dataB = DbMySQL.Instance;
		private DateTime ts;
		private ExceptionHours[] listOfExceptionHours;

		// Constructor
		public jobManagerMain()
		{
			InitializeComponent();
		}

		// Loading Form entities
		private void Form1_Load(object sender, EventArgs e)
		{
			ts = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
			listOfExceptionHours = dataB.ListOfWorkingHours(ts);
			GridLoad();
		}

		// Utility function for loading the Form
		private void GridLoad()
		{
			if (listOfExceptionHours == null)
			{
				dataGridJob.RowCount = 1;
				dataGridJob.Rows.Clear();
				return;
			}
			dataGridJob.RowCount = listOfExceptionHours.Length;
			dataGridJob.ColumnCount = 6;

			for (int i = 0; i < listOfExceptionHours.Length; i++)
			{
				int houers = 0;
				int totalsum = listOfExceptionHours[i].Mission.Houers;
				int exceptionTime = totalsum - 510;
				while (totalsum >= 60)
				{
					houers++;
					totalsum -= 60;
				}
				dataGridJob[0, i].Value = listOfExceptionHours[i].Employee.ID;
				dataGridJob[1, i].Value = listOfExceptionHours[i].Employee.FirstName;
				dataGridJob[2, i].Value = listOfExceptionHours[i].Employee.LastName;
				dataGridJob[3, i].Value = listOfExceptionHours[i].Employee.PhoneNumber;
				dataGridJob[4, i].Value = houers.ToString("0") + ":" + totalsum.ToString("00");
				houers = 0;
				while (exceptionTime >= 60)
				{
					houers++;
					exceptionTime -= 60;
				}
				dataGridJob[5, i].Value = houers.ToString("0") + ":" + exceptionTime.ToString("00");
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

		// Pressing the search button
		private void buttonSearch_Click(object sender, EventArgs e)
		{
			listOfExceptionHours = dataB.ExceptionHoursList(FindSearch());
			GridLoad();
		}

		// Entering search queries
		private string FindSearch()
		{
			string names = "", info = "";
			if (textID.Text != string.Empty)
			{
				names += "textID:";
				info += textID.Text + ":";
			}
			if (textFirstName.Text != string.Empty)
			{
				names += "textFirstName:";
				info += textFirstName.Text + ":";
			}
			if (textLastName.Text != string.Empty)
			{
				names += "textLastName:";
				info += textLastName.Text + ":";
			}
			return dataB.JobManagerMain(names, info);
		}
	}
}
