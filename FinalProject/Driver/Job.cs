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

namespace FinalProject.Driver
{
	public partial class Job : Form
	{
		// Fields
		private int mscWork, secWork, minWork, houWork, mscPau, secPau, minPau, sumOfTime,maxHouers;
		private bool isActive, pausActive;
        private ManagerSettings[] managerSettings;
        private DbMySQL dataB = DbMySQL.Instance;
		private Mission oldMission;
		private Mission exitMission;
		private string workID;
		private Car[] rendsCar = null;
		private Employee worker;
		private bool mailsend;
		private Car chengeCar;

		// Constructors /////////////////
		public Job(string myID)
		{
			InitializeComponent();
			workID = myID;
		}

		public Job(string myID, object exmission)
		{
			InitializeComponent();
			exitMission = (Mission)exmission;
			workID = myID;
			fillMissionInfo();
		}
		/////////////////////////////////

		// Loading Form entities
		private void Job_Load(object sender, EventArgs e)
		{
            managerSettings=dataB.InsertOptions();
            maxHouers = managerSettings[1].Limitation / 60;
            dataCars.Visible = false;
			mscWork = secWork = minWork = houWork = 0;
			isActive = false;
			pausActive = false;
			mailsend = true;
			worker = dataB.AuthenticateEmployee(workID);
		}

		// Timer for breaktime
		private void pauseTime_Tick(object sender, EventArgs e)
		{
			if (pausActive)
			{
				mscPau++;
				if (mscPau >= 100)
				{
					secPau++;
					mscPau = 0;
					if (secPau >= 60)
					{
						minPau++;
						secPau = 0;
						if (minPau >= 30)
						{
							MessageBox.Show("הפסקה נגמרה");
							pausActive = false;
							pauseTime.Stop();
						}
					}
				}
			}
			DrawPauseTime();
		}

		// Pressing "Enter" key on Event Number textBox
		private void textBox2_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				int evNum = 0;
				if (EventNum.Text != "" && int.TryParse(EventNum.Text, out evNum))
				{
					if (exitMission != null)
						oldMission = exitMission;
					exitMission = dataB.ExitToMission(evNum);
					if (exitMission == null && oldMission != null)
					{
						MessageBox.Show("אין משימה מבוקשת");
						exitMission = oldMission;
						fillMissionInfo();
					}
					else
					{
						MessageBox.Show("אין משימה מבוקשת");
						EventNum.Text = "";
					}
				}
			}
		}

		// Menu Strip options
		private void testToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			MissionsList ml = new MissionsList(workID);
			ml.Closed += (s, args) => this.Close();
			ml.ShowDialog();
		}

		private void רשימתמשימותToolStripMenuItem_Click(object sender, EventArgs e)
		{
			updateEmployeeInfo uodate = new updateEmployeeInfo(workID);
			uodate.ShowDialog();
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.Hide();
			DriverMain dr = new DriverMain(workID);
			dr.Closed += (s, args) => this.Close();
			dr.ShowDialog();
		}

		private void parkingDiagram_Click(object sender, EventArgs e)
		{
			PakingDiagramAndInsert pd = new PakingDiagramAndInsert();
			pd.ShowDialog();
		}
		///////////////////////////////////

		// Searches Car number after the text changed
		private void CarToChenge_TextChanged(object sender, EventArgs e)
		{
			dataCars.Visible = true;
			dataCars.ColumnCount = 1;
			rendsCar = null;
			if (CarToChenge.Text != "")
				rendsCar = dataB.CheckCarOnParkingToRend(int.Parse(CarToChenge.Text));
			if (rendsCar == null)
			{
				dataCars.RowCount = 1;
				dataCars.Rows.Clear();
				dataCars.Visible = false;
				return;
			}
			dataCars.RowCount = rendsCar.Length;
			for (int i = 0; i < rendsCar.Length; i++)
			{
				dataCars[0, i].Value = rendsCar[i].LicenseNumber;
			}
		}

		// Double-Clicking the cell gets the info and closes the search
		private void dataCars_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			CarToChenge.Text = rendsCar[e.RowIndex].LicenseNumber.ToString();
			dataCars.Visible = false;
		}

		// Pressing Pause button
		private void Pause_Click(object sender, EventArgs e)
		{
			pausActive = true;
			mscPau = secPau = minPau = 0;
			pauseTime.Start();
		}

		// Timer for worktime
		private void workTime_Tick(object sender, EventArgs e)
		{
			if (isActive)
			{
				mscWork++;
				if (mscWork >= 100)
				{
					secWork++;
					mscWork = 0;
					if (secWork >= 60)
					{
						minWork++;
						secWork = 0;
						if (minWork >= 60)
						{
							minWork = 0;
							houWork++;
							if (houWork >= 23 && minWork >= 59 && secWork >= 59)
							{
								isActive = false;
							}
						}
						if (houWork == maxHouers && minWork > 30 && mailsend == true)
						{
							exceptionHouers();
							mailsend = false;
						}
					}
				}
			}
			DrawTime();
		}
		public void exceptionHouers()
		{
			string[] emails = dataB.findMail();
			if (emails == null)
			{
				MessageBox.Show("Error");
				return;
			}
			email em = new email();
			string mailString = worker.FirstName + " " + worker.LastName + " ";
			mailString += "נמצה בחריגת שעות ביצוע משימה לטובת יצירת קשר עם עובד פנה למספר טפון הזה ";
			mailString += ": " + worker.PhoneNumber;
			for (int i = 0; i < emails.Length; i++)
				em.sendeMail(mailString, emails[i]);

		}
		// Utility functions for timer
		public void DrawTime()
		{
			timeWork.Text = string.Format("{0:00}:{1:00}:{2:00}", houWork, minWork, secWork);
		}

		public void DrawPauseTime()
		{
			timerPause.Text = string.Format("{0:00}:{1:00}:{2:00}", 0, minPau, secPau);
		}
		///////////////////////////

		// Pressing start button
		private void Start_Click(object sender, EventArgs e)
		{
			if (!isActive)
			{
				isActive = true;
				EventNum.ReadOnly = true;
				workTime.Start();
			}
			else
			{
				isActive = false;
				EventNum.ReadOnly = false;
				workTime.Stop();
				finshWork();
			}
		}

		// Fills mission info
		public void fillMissionInfo()
		{
			if (exitMission != null)
			{
				EventNum.Text = exitMission.MissionID.ToString();
				InfoOfMission.Text = exitMission.Description;
				licenceNum.Text = exitMission.CarNumber.ToString();
				Start.Enabled = true;
			}
			else
				MessageBox.Show("משימה מבוקשת לא קיים");
		}

		// Finished work
		public void finshWork()
		{
			int licenceNum;
			if (CarToChenge.Text != "" && int.TryParse(CarToChenge.Text, out licenceNum))
			{
				chengeCar = dataB.CheckCarOnParking(licenceNum);
				if (chengeCar != null)
				{
					sumOfTime = houWork * 60 + minWork;
					if (WorkerInfo.Text != null)
						exitMission.Description += WorkerInfo.Text;
					dataB.finishMissionWhisChengeCar(exitMission, workID, sumOfTime, licenceNum);
					dataB.exitCarFromParking(licenceNum);
					ClearInfo();
				}
			}
			else if (CarToChenge.Text == "")
			{
				sumOfTime = houWork * 60 + minWork;
				if (WorkerInfo.Text != "")
					exitMission.Description += WorkerInfo.Text;
				dataB.finishMission(exitMission, workID, sumOfTime);
				ClearInfo();
			}
			else
				MessageBox.Show("לא קיים רכב כזה תנסה עוד פעם");
		}

		// Clears info
		public void ClearInfo()
		{
			EventNum.Text = "";
			WorkerInfo.Text = "";
			InfoOfMission.Text = "";
			licenceNum.Text = "";
			Start.Enabled = false;
			mscWork = secWork = minWork = houWork = 0;
		}
	}
}
