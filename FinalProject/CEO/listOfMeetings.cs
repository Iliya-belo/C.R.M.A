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
	public partial class listOfMeetings : Form
	{
		// Fields
		private Database.DbMySQL dataB = Database.DbMySQL.Instance;
		private Employee[] emps;
		private Request[] requests;

		// Constructor
		public listOfMeetings()
		{
			InitializeComponent();
		}

		// Loading Form entities
		private void listOfMeetings_Load(object sender, EventArgs e)
		{
			emps = dataB.ListOfRequests(ref requests);
			GridLoad();
		}

		// Utility function for loading the Form
		private void GridLoad()
		{
			if (emps == null)
			{
				dataGridMeetings.RowCount = 1;
				dataGridMeetings.Rows.Clear();
				return;
			}
			dataGridMeetings.RowCount = emps.Length;
			dataGridMeetings.ColumnCount = 9;
			for (int i = 0; i < emps.Length; i++)
			{
				dataGridMeetings[0, i].Value = emps[i].ID;
				dataGridMeetings[1, i].Value = emps[i].FirstName;
				dataGridMeetings[2, i].Value = emps[i].LastName;
				dataGridMeetings[3, i].Value = emps[i].Role;
				dataGridMeetings[4, i].Value = requests[i].ExplanationOfRequest;
				dataGridMeetings[5, i].Value = emps[i].PhoneNumber;
				dataGridMeetings[6, i].Value = requests[i].RequestedDate.Date.ToString("yyyy-MM-dd") + "  " + requests[i].Houers;
			}
			// Originally it doesn't display the last row for buttons because
			// DataGridViewButtonColumn does not display the text in the button on the last row
			// Source: https://stackoverflow.com/questions/30256811/datagridview-button-text-not-appearing-despite-usecolumntextforbuttontext-set-to
			dataGridMeetings[7, emps.Length - 1].Value = "אישור";
			dataGridMeetings[8, emps.Length - 1].Value = "ביטול";
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

		// Entering search queries
		private string FindSearch()
		{
			string strName = "", strInfo = "";
			if (textID.Text != string.Empty)
			{
				strName += "textID:";
				strInfo += textID.Text + ":";
			}
			if (textFirstName.Text != string.Empty)
			{
				strName += "textFirstName:";
				strInfo += textFirstName.Text + ":";
			}
			if (textLastName.Text != string.Empty)
			{
				strName += "textLastName:";
				strInfo += textLastName.Text + ":";
			}
			if (textRole.Text != string.Empty)
			{
				strName += "textRole:";
				strInfo += textRole.Text + ":";
			}
			if (textInfoRequest.Text != string.Empty)
			{
				strName += "textInfoRequest:";
				strInfo += textInfoRequest.Text + ":";
			}
			if (textPhoneNumber.Text != string.Empty)
			{
				strName += "textPhoneNumber:";
				strInfo += textPhoneNumber.Text + ":";
			}

			return dataB.bildQueryFindListOfMeetings(strName, strInfo);
		}

		// Updates the DataGridView
		private void TextBoxChanged()
		{
			emps = dataB.MeetingList(FindSearch(), requests);
			GridLoad();
		}

		private void textID_TextChanged(object sender, EventArgs e)
		{
			TextBoxChanged();
		}

		private void textFirstName_TextChanged(object sender, EventArgs e)
		{
			TextBoxChanged();
		}

		private void textLastName_TextChanged(object sender, EventArgs e)
		{
			TextBoxChanged();
		}

		private void textRole_TextChanged(object sender, EventArgs e)
		{
			TextBoxChanged();
		}

		private void textInfoRequest_TextChanged(object sender, EventArgs e)
		{
			TextBoxChanged();
		}

		private void textPhoneNumber_TextChanged(object sender, EventArgs e)
		{
			TextBoxChanged();
		}

		// Executes command after clicking on Accept Button or Refuse Button
		private void dataGridMeetings_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var senderGrid = (DataGridView)sender;
			var cell = senderGrid.Columns[e.ColumnIndex];
			var id = dataGridMeetings.Rows[e.RowIndex].Cells[0].Value.ToString();
			if (cell.Name == "Accept")
			{
				bildAcceptMail(emps[e.RowIndex], requests[e.RowIndex]);
				dataB.deletMetting(requests[e.RowIndex]);
				listOfMeetings_Load(this, EventArgs.Empty);
			}

			if (cell.Name == "Refuse")
			{
				bildRefuseMail(emps[e.RowIndex], requests[e.RowIndex]);
				dataB.deletMetting(requests[e.RowIndex]);
				listOfMeetings_Load(this, EventArgs.Empty);
			}
		}

		private void bildAcceptMail(Employee emp, Request req)
		{
			email em = new email();
			hashing pasw = new hashing();
			string emailMessage = "לכבוד " + emp.FirstName + " " + emp.LastName + " " + " מנהל יוכל להיפגש איתך בתאריך :" + " " + req.RequestedDate.Date.ToString("dd-MM-yyyy") + " בשעה" + req.Houers;
			em.sendeMail(emailMessage, emp.Mail);
		}

		private void bildRefuseMail(Employee emp, Request req)
		{
			email em = new email();
			string emailMessage = "לכבוד " + emp.FirstName + " " + emp.LastName + " " + " מנהל לא יוכל להיפגש איתך בתאריך :" + " " + req.RequestedDate.Date.ToString("dd-MM-yyyy") + " בשעה" + req.Houers; ;
			em.sendeMail(emailMessage, emp.Mail);
		}

		private void WorkCar_Click(object sender, EventArgs e)
		{
			AddCarToWorker ad = new AddCarToWorker();
			ad.ShowDialog();
		}
	}
}
