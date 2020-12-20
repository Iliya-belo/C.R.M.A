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
	public partial class AddCarToWorker : Form
	{
		// Fields
		private Employee worker;
		private Employee[] optionsOfWorkers;
		private Car workCar, carToBack;
		private Car[] worksCar;
		private Database.DbMySQL dataB = Database.DbMySQL.Instance;

		// Constructor
		public AddCarToWorker()
		{
			InitializeComponent();
		}

		// Fills employee info
		public void fillEmpInfo()
		{
			textID.Text = worker.ID;
			textFirstName.Text = worker.FirstName;
			textLastName.Text = worker.LastName;
			textCity.Text = worker.City;
			textStreet.Text = worker.Street;
			textPhoneNumber.Text = worker.PhoneNumber;
			textRole.Text = worker.Role;
			dataWorkers.Visible = false;
		}

		// Fills car info
		public void fillCarInfo()
		{
			textLicensNum.Text = workCar.LicenseNumber.ToString();
			textMVANo.Text = workCar.MVANumber;
			textManufacture.Text = workCar.Brand;
			textModel.Text = workCar.Model;
			Eng_cap.Text = workCar.Engi_capacity;
			textCarYear.Text = workCar.YearOfCar.ToString();
			textMilege.Text = workCar.Mileage;
			DateTest.Value = workCar.DateOfTest;
			DateLastCarCare.Value = workCar.DateOfLastCarCare;
			dataGridCars.Visible = false;
		}

		// Changes the textBox's text
		private void textID_TextChanged(object sender, EventArgs e)
		{
			if (textID.Text != "")
				optionsOfWorkers = dataB.findEmployee(textID.Text);
			if (optionsOfWorkers != null)
				fillAllOptions();
		}

		// Utility function after changing text in ID
		public void fillAllOptions()
		{
			dataWorkers.Visible = true;
			dataWorkers.ColumnCount = 2;
			if (optionsOfWorkers == null)
			{
				dataWorkers.RowCount = 1;
				dataWorkers.Rows.Clear();
				dataWorkers.Visible = false;
				return;
			}
			dataWorkers.RowCount = optionsOfWorkers.Length;
			for (int i = 0; i < optionsOfWorkers.Length; i++)
			{
				dataWorkers[0, i].Value = optionsOfWorkers[i].ID;
				dataWorkers[1, i].Value = optionsOfWorkers[i].FirstName + " " + optionsOfWorkers[i].LastName;
			}
		}

		// Changes the textBox's text
		private void textLicensNum_TextChanged(object sender, EventArgs e)
		{
			dataGridCars.Visible = true;
			dataGridCars.ColumnCount = 1;
			worksCar = null;
			if (textLicensNum.Text != "")
				worksCar = dataB.CheckCarOnParkingToWork(int.Parse(textLicensNum.Text));
			if (worksCar == null)
			{
				dataGridCars.RowCount = 1;
				dataGridCars.Rows.Clear();
				dataGridCars.Visible = false;
				return;
			}
			dataGridCars.RowCount = worksCar.Length;
			for (int i = 0; i < worksCar.Length; i++)
			{
				dataGridCars[0, i].Value = worksCar[i].LicenseNumber;
			}
		}

		// Double-Clicking the cell searches the worker id
		private void dataWorkers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			worker = optionsOfWorkers[e.RowIndex];
			carToBack = workCar = dataB.FindWorkerCar(worker.ID);
			if (workCar != null)
			{
				ReturnCar.Enabled = true;
				ChengeCar.Enabled = true;
				fillCarInfo();
                GiveCar.Enabled = false;
                ChengeCar.Enabled = true;
                ReturnCar.Enabled = true;

            }
			fillEmpInfo();
		}

		// Double-Clicking the cell searches the car MVA number
		private void dataGridCars_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			workCar = worksCar[e.RowIndex];
			fillCarInfo();
		}

		// Pressing close button
		private void exit_Click(object sender, EventArgs e)
		{
			Close();
		}

		// Buttons ////////////////
		private void ChengeCar_Click(object sender, EventArgs e)
		{
			ReturnCar rc = new ReturnCar(carToBack, worker.ID);
			rc.ShowDialog();
			dataB.exitCarFromParking(workCar.LicenseNumber);
			dataB.ChengeCar(workCar.LicenseNumber, worker.ID);
			MessageBox.Show("נשמר בהצלחה");
			Close();
		}

		private void ReturnCar_Click(object sender, EventArgs e)
		{
			ReturnCar rc = new ReturnCar(carToBack, worker.ID);
			rc.ShowDialog();
			dataB.returnCar(worker.ID);
			Close();
		}

        private void AddCarToWorker_Load(object sender, EventArgs e)
        {
            ChengeCar.Enabled = false;
            ReturnCar.Enabled = false;
        }

        private void GiveCar_Click(object sender, EventArgs e)
		{
			if (workCar == null || worker == null)
			{
				MessageBox.Show("עובד או רכב לא נבחרו");
				return;
			}
			dataB.exitCarFromParking(workCar.LicenseNumber);
			dataB.carLinkage(workCar.LicenseNumber, worker.ID);
			MessageBox.Show("נשמר בהצלחה");
			Close();
		}
		///////////////////////////
	}
}
