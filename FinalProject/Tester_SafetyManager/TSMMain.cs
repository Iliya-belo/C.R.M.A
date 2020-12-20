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

namespace FinalProject.Tester_SafetyManager
{
	public partial class TSMMain : Form
	{
		// Fields
		private Database.DbMySQL dataB = Database.DbMySQL.Instance;
		private Garage[] garages;

		// Constructor
		public TSMMain()
		{
			InitializeComponent();
		}

		// Loading Form entities
		private void TSMMain_Load(object sender, EventArgs e)
		{
			garages = dataB.ListOfGarages();
			GridLoad();
		}

		// Utility function for loading the Form
		private void GridLoad()
		{
			if (garages == null)
			{
				dataGridGarages.RowCount = 1;
				dataGridGarages.Rows.Clear();
				return;
			}
			dataGridGarages.RowCount = garages.Length;
			dataGridGarages.ColumnCount = 4;

			for (int i = 0; i < garages.Length; i++)
			{
				dataGridGarages[0, i].Value = garages[i].GarageName;
				dataGridGarages[1, i].Value = garages[i].City;
				dataGridGarages[2, i].Value = garages[i].Street + " " + garages[i].HouseNumber;
				dataGridGarages[3, i].Value = garages[i].PhoneNumber;
			}
		}

		// Menu Strip options
		private void listOfRepairedCars_Click(object sender, EventArgs e)
		{
			this.Hide();
			listOfRepairedCars lorc = new listOfRepairedCars();
			lorc.Closed += (s, args) => this.Close();
			lorc.ShowDialog();
		}

		private void updateRepairedParts_Click(object sender, EventArgs e)
		{
			updateRepairedParts urp = new updateRepairedParts();
			urp.ShowDialog();
		}

		private void carToGarage_Click(object sender, EventArgs e)
		{
			this.Hide();
			insertCarToGarage ictg = new insertCarToGarage();
			ictg.Closed += (s, args) => this.Close();
			ictg.ShowDialog();
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

		// Pressing the search button
		private void btnSearch_Click(object sender, EventArgs e)
		{
			garages = dataB.FilteredListOfGarages(FindSearch());
			GridLoad();
		}

		// Entering search queries
		private string FindSearch()
		{
			string strName = "", strInfo = "";
			if (textGarageName.Text != string.Empty)
			{
				strName += "textGarageName-";
				strInfo += textGarageName.Text + "-";
			}
			if (textCity.Text != string.Empty)
			{
				strName += "textCity-";
				strInfo += textCity.Text + "-";
			}
			if (textAddress.Text != string.Empty)
			{
				strName += "textAddress-";
				strInfo += textAddress.Text + "-";
			}
			return dataB.bildQueryToFindGarage(strName, strInfo);
		}

		private void AddGarage_Click(object sender, EventArgs e)
		{
			AddGarageItem ag = new AddGarageItem();
			ag.ShowDialog();
		}
	}
}
