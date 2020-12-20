using FinalProject.Classes;
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

namespace FinalProject.CEO
{
	public partial class mainCEO : Form
	{
		// Fields
		private Database.DbMySQL dataB = Database.DbMySQL.Instance;
		private Candidate[] candidate;
		private ManagerSettings[] managerSettings;

		// Constructor
		public mainCEO()
		{
			InitializeComponent();
		}

		// Loading Form entities
		private void mainCEO_Load(object sender, EventArgs e)
		{
			GridLoadJobs();
			GridLoadOptions();
		}

		// Utility function for loading the Form
		private void GridLoadJobs()
		{
			candidate = dataB.ListOfCandidateEmployees();
			if (candidate == null)
			{
				dataGridJobs.RowCount = 1;
				dataGridJobs.Rows.Clear();
				return;
			}
			dataGridJobs.RowCount = candidate.Length;
			dataGridJobs.ColumnCount = 8;

			for (int i = 0; i < candidate.Length; i++)
			{
				dataGridJobs[0, i].Value = candidate[i].ID;
				dataGridJobs[1, i].Value = candidate[i].FirstName;
				dataGridJobs[2, i].Value = candidate[i].LastName;
				dataGridJobs[3, i].Value = candidate[i].Role;
				dataGridJobs[4, i].Value = candidate[i].PhoneNumber;
				dataGridJobs[5, i].Value = candidate[i].Mail;
			}
			// Originally it doesn't display the last row for buttons because
			// DataGridViewButtonColumn does not display the text in the button on the last row
			// Source: https://stackoverflow.com/questions/30256811/datagridview-button-text-not-appearing-despite-usecolumntextforbuttontext-set-to
			dataGridJobs[6, candidate.Length - 1].Value = "התקבל";
			dataGridJobs[7, candidate.Length - 1].Value = "לא התקבל";
		}

		// Utility function for loading the Form
		private void GridLoadOptions()
		{
			managerSettings = dataB.InsertOptions();
			if (managerSettings == null)
			{
				dataGridOptions.RowCount = 1;
				dataGridOptions.Rows.Clear();
				return;
			}
			dataGridOptions.RowCount = managerSettings.Length;
			dataGridOptions.ColumnCount = 4;

			for (int i = 0; i < managerSettings.Length; i++)
			{
				int totalHours = 0, totalMinutes = managerSettings[i].Limitation;
				dataGridOptions[0, i].Value = managerSettings[i].GuideLineNumber;
				dataGridOptions[1, i].Value = managerSettings[i].Name;
				dataGridOptions[2, i].Value = managerSettings[i].Description;
				while (totalMinutes >= 60)
				{
					totalHours++;
					totalMinutes -= 60;
				}
				dataGridOptions[3, i].Value = totalHours + ":" + totalMinutes;
			}
		}

		// Menu Strip options
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
		private void dataGridJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var senderGrid = (DataGridView)sender;
			var cell = senderGrid.Columns[e.ColumnIndex];

			if (IsButton(cell) && e.RowIndex >= 0)
			{
				var id = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
				if (cell.Name == "Accept")
				{
					bildAcceptMail(candidate[e.RowIndex]);
					dataB.InsertEmployeeFromCandidate(candidate[e.RowIndex]);
					dataB.InsertEmployeeLogin(id, candidate[e.RowIndex].Password);
					dataB.DeleteCandidateEmployeeAfterAcceptOrReject(id);
					MessageBox.Show("הועבר בהצלחה");
					GridLoadJobs();
				}

				if (cell.Name == "Reject")
				{
					bildRefuseMail(candidate[e.RowIndex]);
					dataB.DeleteCandidateEmployeeAfterAcceptOrReject(id);
					GridLoadJobs();
				}
			}
		}

		private void bildAcceptMail(Candidate candidate)
		{
			email em = new email();
			hashing pasw = new hashing();
			string emailMessage = "לכבוד " + candidate.FirstName + " " + candidate.LastName + " " + "אנו שמחים לומר על זה שהתקבלת לתפקיד " + candidate.Role + "שם משתמש זה תז וסיסמה  " + pasw.decryptPassword(candidate.Password);
			em.sendeMail(emailMessage, candidate.Mail);
		}

		private void bildRefuseMail(Candidate candidate)
		{
			email em = new email();
			string emailMessage = "לכבוד " + candidate.FirstName + " " + candidate.LastName + " " + "אנו מצטערים לומר על זה שלא התקבלת לתפקיד המבוקש ";
			em.sendeMail(emailMessage, candidate.Mail);
		}

        // Pressing the update button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int num, limit = 0;

            if ((int.TryParse(textGuideLine.Text, out num) && int.TryParse(textLimitation.Text, out limit)) == false)
            {
                MessageBox.Show("נדרש להכניס רק את שעות ");
                return;
             }
			if ((textGuideLine.Text == "" || textLimitation.Text == "") || textLimitation.Text.Equals(((managerSettings[num - 1].Limitation - 30) / 60).ToString()))
			{
				MessageBox.Show("נתונים שגויים");
				return;
			}
			managerSettings[num - 1].Limitation = limit;
			dataB.UpdateOptions(managerSettings[num - 1]);
			GridLoadOptions();
		}

		// Double-Clicking the cell sets the values of 2 textBoxes
		private void dataGridOptions_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			string[] splitter = dataGridOptions[3, e.RowIndex].Value.ToString().Split(':');
			textGuideLine.Text = dataGridOptions[0, e.RowIndex].Value.ToString();
			textLimitation.Text = splitter[0];
		}

		// Opens Form after clicking the button
		private void WorkCar_Click(object sender, EventArgs e)
		{
			AddCarToWorker carW = new AddCarToWorker();
			carW.ShowDialog();
		}
	}
}
