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
	public partial class monthlyExecptionsHours : Form
	{
		// Fields
		private Database.DbMySQL dataB = Database.DbMySQL.Instance;
		private static JobManager.monthlyExecptionsHours _meh;
        private ManagerSettings[] managerSettings;
        private ExceptionHours[] listOfExceptionHours;
		private DateTime ts;

		// Constructor
		public monthlyExecptionsHours()
		{
			InitializeComponent();
			if (_meh == null)
				_meh = new JobManager.monthlyExecptionsHours();
		}

		// Loading Form entities
		private void monthlyExecptionsHours_Load(object sender, EventArgs e)
		{
            managerSettings = dataB.InsertOptions();
            for (int i = 1; i <= DateTime.Now.Month; i++)
				comboMonths.Items.Add(i);
			ts = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
			listOfExceptionHours = dataB.ListOfWorkingHours(ts, managerSettings[1].Limitation);
			_meh.GridLoad(dataGridExceptionsHours, listOfExceptionHours);
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
			if (comboMonths.SelectedIndex >= 0&& comboMonths.SelectedItem.ToString()!="")
			{
				strName += "comboMonths:";
				strInfo += new DateTime(DateTime.Now.Year, int.Parse(comboMonths.Text), 1).ToString("yyyy-MM-dd") + ":" + new DateTime(DateTime.Now.Year, int.Parse(comboMonths.Text), DateTime.DaysInMonth(DateTime.Now.Year, int.Parse(comboMonths.Text))).ToString("yyyy-MM-dd") + ":";
			}
			return dataB.bildQueryToFindEmployee(strName, strInfo, managerSettings[1].Limitation);
		}

		// Pressing the search button
		private void btnSearch_Click(object sender, EventArgs e)
		{
			listOfExceptionHours = dataB.ExceptionHoursList(FindSearch());
			_meh.GridLoad(dataGridExceptionsHours, listOfExceptionHours);
		}

		private void WorkCar_Click(object sender, EventArgs e)
		{
			AddCarToWorker ad = new AddCarToWorker();
			ad.ShowDialog();
		}
	}
}
