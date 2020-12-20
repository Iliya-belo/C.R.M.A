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
	public partial class DriverMain : Form
	{
		// Fields
		private DbMySQL dataB = DbMySQL.Instance;
		private string Workid;
		private Mission[] myMissionsFinish;
        private ManagerSettings[] managerSettings;
        private int houers;
		private int totalsum;

		// Constructor
		public DriverMain(string id)
		{
			totalsum = 0;
			Workid = id;
			InitializeComponent();
		
		}
        private void DriverMain_Load(object sender, EventArgs e)
        {
            managerSettings = dataB.InsertOptions();
            fillInformation();
        }
        // Fills the info to DataGridView
        public void fillInformation()
		{
          
            myMissionsFinish = dataB.MissionFinish(Workid);
			if (myMissionsFinish == null)
			{
				dataGridMissionFinish.RowCount = 1;
				dataGridMissionFinish.Rows.Clear();
				return;
			}
			dataGridMissionFinish.ColumnCount = 6;
			dataGridMissionFinish.RowCount = myMissionsFinish.Length;
			for (int i = 0; i < myMissionsFinish.Length; i++)
			{
				houers = 0;
				totalsum += myMissionsFinish[i].Houers;
                if (managerSettings[1].Limitation<= myMissionsFinish[i].Houers)
                        ColorsRow(i);
                while (myMissionsFinish[i].Houers >= 60)
				{
					houers++;
					myMissionsFinish[i].Houers -= 60;
				}

				dataGridMissionFinish[0, i].Value = myMissionsFinish[i].MissionID;
				dataGridMissionFinish[1, i].Value = myMissionsFinish[i].Time.ToShortDateString();
				dataGridMissionFinish[2, i].Value = myMissionsFinish[i].CarNumber;
				dataGridMissionFinish[3, i].Value = myMissionsFinish[i].Description;
				dataGridMissionFinish[4, i].Value = myMissionsFinish[i].Status;
				dataGridMissionFinish[5, i].Value = houers + ":" + myMissionsFinish[i].Houers;
				
			}
			houers = 0;
			if (totalsum>managerSettings[0].Limitation)
				totalHour.BackColor = Color.Coral;
			else
				totalHour.BackColor = Color.LightGreen;
			while (totalsum >= 60)
			{
				houers++;
				totalsum -= 60;
			}
			totalHour.Text = houers + "." + totalsum;
		}

		// Colors the row
		public void ColorsRow(int num)
		{
			for (int j = 0; j <= 5; j++)
				dataGridMissionFinish[j, num].Style.BackColor = Color.Coral;
		}

		// Menu Strip options
		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Job jb = new Job(Workid);
			jb.Closed += (s, args) => this.Close();
			jb.ShowDialog();
		}

		private void testToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			MissionsList ml = new MissionsList(Workid);
			ml.Closed += (s, args) => this.Close();
			ml.ShowDialog();
		}

		private void parkingDiagram_Click(object sender, EventArgs e)
		{
			PakingDiagramAndInsert pd = new PakingDiagramAndInsert();
			pd.ShowDialog();
		}

		private void ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			updateEmployeeInfo uodate = new updateEmployeeInfo(Workid);
			uodate.ShowDialog();
		}

 
    }
}
