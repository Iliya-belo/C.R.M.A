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

namespace FinalProject.Shared_Forms
{
	public partial class CarHistory : Form
	{
		// Fields
		private int licenseNumber;
		private Database.DbMySQL dataB = Database.DbMySQL.Instance;
		private Mission[] missions;
		private MissionList[] missionLists;
        private Contract contract;
		private string query;

		// Constructor
		public CarHistory(int licenseNumber)
		{
			InitializeComponent();
			this.licenseNumber = licenseNumber;
		}

		// Loading Form entities
		private void CarHistory_Load(object sender, EventArgs e)
		{
			carNameLabel.Text += licenseNumber.ToString();
			query = dataB.bildQueryForCarsHistory("missions");
			query += dataB.bildQueryForExceptionList("textLicenseNumber:", licenseNumber + ":");
			missions = dataB.AllEvents(query);

			query = dataB.bildQueryForCarsHistory("missionLists");
			query += dataB.bildQueryForExceptionList("textLicenseNumber:", licenseNumber + ":") + ")";
			missionLists = dataB.missionEvents(query);
			contract = dataB.ContractToMissionListFind(missions[0].ContractNumber);

			GridLoad();
		}

		// Utility function for loading the Form
		public void GridLoad()
		{
			if (missionLists == null || missions == null)
			{
				dataGridCarHistory.RowCount = 1;
				dataGridCarHistory.Rows.Clear();
				return;
			}
			dataGridCarHistory.RowCount = missions.Length;
			dataGridCarHistory.ColumnCount = 5;
			for (int i = 0; i < missionLists.Length && i < missions.Length; i++)
			{
				dataGridCarHistory[0, i].Value = missions[i].MissionID;
				dataGridCarHistory[1, i].Value = missions[i].CarNumber;
				dataGridCarHistory[2, i].Value = contract.CosCar.Brand + "/" + contract.CosCar.Model;
				dataGridCarHistory[3, i].Value = missionLists[i].DaysOfState.ToString("dd/MM/yyyy");
				dataGridCarHistory[4, i].Value = missionLists[i].ComponentStatusToOrder;
			}
		}
	}
}
