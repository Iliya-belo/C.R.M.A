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
	public partial class MissionsList : Form
	{
		// Fields
		private DbMySQL dataB = DbMySQL.Instance;
		private Mission[] myMissions;
		private Mission[] otherMissions;
		private Costumer person;
		private string Workid;

		// Constructor
		public MissionsList(string myId)
		{
			InitializeComponent();
			Workid = myId;
		}

		// Loading Form entities
		private void MissionsList_Load(object sender, EventArgs e)
		{
			fillPersonalMissions();
			MissionsToEvreOne();
		}

		// Utility function for loading the Form
		private void fillPersonalMissions()
		{
			myMissions = dataB.PersonalMission(Workid);
			if (myMissions == null)
			{
				dataGridPersonalMission.RowCount = 1;
				dataGridPersonalMission.Rows.Clear();
				return;
			}
			dataGridPersonalMission.ColumnCount = 6;
			dataGridPersonalMission.RowCount = myMissions.Length;
			for (int i = 0; i < myMissions.Length; i++)
			{
				person = dataB.FindCostumer(myMissions[i].ContractNumber);

				dataGridPersonalMission[0, i].Value = myMissions[i].MissionID;
				dataGridPersonalMission[1, i].Value = myMissions[i].Time.ToShortDateString();
				dataGridPersonalMission[2, i].Value = myMissions[i].CarNumber;
				dataGridPersonalMission[3, i].Value = person.LastName + " " + person.FirstName;
				dataGridPersonalMission[4, i].Value = person.PhoneNumber;
				dataGridPersonalMission[5, i].Value = myMissions[i].Status;
			}
		}
		// Utility function for loading the Form
		private void MissionsToEvreOne()
		{
			otherMissions = dataB.MissionEveryOne();
			if (otherMissions == null)
			{
				dataGridEvreOne.RowCount = 1;
				dataGridEvreOne.Rows.Clear();
				return;
			}
			dataGridEvreOne.ColumnCount = 6;
			dataGridEvreOne.RowCount = otherMissions.Length;
			for (int i = 0; i < otherMissions.Length; i++)
			{
				person = dataB.FindCostumer(otherMissions[i].ContractNumber);

				dataGridEvreOne[0, i].Value = otherMissions[i].MissionID;
				dataGridEvreOne[1, i].Value = otherMissions[i].Time.ToShortDateString();
				dataGridEvreOne[2, i].Value = otherMissions[i].CarNumber;
				dataGridEvreOne[3, i].Value = person.LastName + " " + person.FirstName;
				dataGridEvreOne[4, i].Value = person.PhoneNumber;
				dataGridEvreOne[5, i].Value = otherMissions[i].Status;
			}
		}

		// Menu Strip options
		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.Hide();
			DriverMain dr = new DriverMain(Workid);
			dr.Closed += (s, args) => this.Close();
			dr.ShowDialog();
		}

		private void ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			updateEmployeeInfo uodate = new updateEmployeeInfo(Workid);
			uodate.ShowDialog();
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Job job = new Job(Workid);
			job.Closed += (s, args) => this.Close();
			job.ShowDialog();
		}

		private void התנתקToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void parkingDiagram_Click(object sender, EventArgs e)
		{
			PakingDiagramAndInsert pd = new PakingDiagramAndInsert();
			pd.ShowDialog();
		}
		///////////////////////////////////

		// Opens the Job Form after double-clicking on cell
		private void dataGridPersonalMission_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			myMissions[0] = dataB.ExitToMission(int.Parse(dataGridPersonalMission[0, e.RowIndex].Value.ToString()));
			this.Hide();
			Job job = new Job(Workid, myMissions[0]);
			job.Closed += (s, args) => this.Close();
			job.ShowDialog();
		}

		// Opens the Job Form after double-clicking on cell
		private void dataGridEvreOne_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			myMissions[0] = dataB.ExitToMission(int.Parse(dataGridEvreOne[0, e.RowIndex].Value.ToString()));
			this.Hide();
			Job job = new Job(Workid, myMissions[0]);
			job.Closed += (s, args) => this.Close();
			job.ShowDialog();
		}
	}
}
