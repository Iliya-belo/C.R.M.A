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

namespace FinalProject.SellerOrRenter
{
	public partial class PreaparationOfTheCar : Form
	{
		// Fields
		private Costumer person = null;
		private int start, limit;
		private Contract temporaryСontract;
		private Car cars = null;
		private bool[] contracts;
		private DbMySQL dataB = DbMySQL.Instance;
		private readonly Main _main;

		// Constructors /////////////////
		public PreaparationOfTheCar(bool[] empty, int Start, int Limit, Main main)
		{
			_main = main;
			contracts = empty;
			start = Start;
			limit = Limit;
			InitializeComponent();
		}

		public PreaparationOfTheCar(bool[] empty, int Start, int Limit, object cartoPrep, Main main)
		{
			_main = main;
			cars = (Car)cartoPrep;
			contracts = empty;
			start = Start;
			limit = Limit;
			InitializeComponent();
		}
		/////////////////////////////////

		// Pressing "Enter" key calls fillCostumerInfo function
		private void ID_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (ID.Text.Length == 9)
				{
					person = dataB.findPerson(ID.Text);
					ID.Text = "";
					if (person != null)
						fillCostumerInfo();
					else
						MessageBox.Show("לוח לא קיים");
				}
				else
					MessageBox.Show("לקוח לא קיים במערכת");
			}
		}

		// Fills costumer info
		public void fillCostumerInfo()
		{
			ID.Text = person.ID;
			FirstName.Text = person.FirstName;
			LastName.Text = person.LastName;
			City.Text = person.City;
			Street.Text = person.Street;
			phineNum.Text = person.PhoneNumber;
		}

		// Pressing Close button
		private void exit_Click(object sender, EventArgs e)
		{
			Close();
		}

		// Pressing Submit button
		private void submit_Click(object sender, EventArgs e)
		{
			int contractNum = int.Parse(EmptyContracts.SelectedItem.ToString());
			if (person == null)
			{
				if (SelectInfo())
					dataB.NewCostumer(person);
				else
				{
					MessageBox.Show("אחד מהנתונים שגוים");
					return;
				}
			}
			if (SelectContract() && SelectMission())
			{
				dataB.InsertMission(null, contractNum, Missions.Text, FaultDescription.Text);
				cars.PurposeOfCar = "רכב בהכנה";
				dataB.UpdateCar(cars);
				MessageBox.Show("בקשתך התקבלה");
				_main.fillInformation();
				this.Close();
			}
		}

		// Checks selected info
		public bool SelectInfo()
		{
			if (ID.Text.Length != 9 || FirstName.Text.Length <= 0 || LastName.Text.Length <= 0 || City.Text.Length <= 0 || Street.Text.Length <= 0 || phineNum.Text.Length <= 0)
				return false;
			person = new Costumer(ID.Text, FirstName.Text, LastName.Text, phineNum.Text, Street.Text, City.Text);
			return true;
		}

		// Checks selected contract
		public bool SelectContract() // TODO: can be improved
		{
			int licence = 0;
			if (licenceNum.Text.Length < 7 && !int.TryParse(licenceNum.Text, out licence))
				return false;
			if (cars == null)
				cars = dataB.CheckCarOnParking(licence);
			if (cars == null)
			{
				MessageBox.Show("הרכב הזה לא נמצא בחניה");
				return false;
			}
			temporaryСontract = new Contract(cars, person, int.Parse(EmptyContracts.SelectedItem.ToString()), DateTime.Now.Date);
			dataB.insertContract(temporaryСontract);
			return true;
		}

		// Loading Form entities
		private void PreaparationOfTheCar_Load(object sender, EventArgs e)
		{
			for (int i = start; i < limit; i++)
				if (contracts[i])
					EmptyContracts.Items.Add(i);
			if (cars != null)
				licenceNum.Text = cars.LicenseNumber.ToString();
		}

		// Checks selected mission
		public bool SelectMission() // TODO: can be simplified
		{
			if (Missions.Text.Length <= 0 || FaultDescription.Text.Length <= 0)
				return false;
			if (licenceNum.Text.Equals(""))
				return false;
			if (temporaryСontract.ContractNumber <= 0)
				return false;
			return true;
		}
	}
}
