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
	public partial class ContractDocument : Form
	{
		// Fields
		private Costumer costumer = null;
		private Car carsToBuy = null, carToReturn = null;
		private int contNum;
		private bool[] emptyParking;
		private readonly Main _main;
        private Employee worker;
		private Contract chengeCar, newContract;
		private DbMySQL dataB = DbMySQL.Instance;

		// Constructors /////////////////
		public ContractDocument(Main form, object carsBuy,object role)
		{
			InitializeComponent();
			_main = form;
            worker = (Employee)role;
			carsToBuy = (Car)carsBuy;
		}

		public ContractDocument(Main form)
		{
			InitializeComponent();
			_main = form;
		}
		/////////////////////////////////

		// Loading Form entities
		private void Contract_Load(object sender, EventArgs e)
		{
			parking.Visible = false;
			parkingNum.Visible = false;
			returnCar.Visible = false;
			emptyParking = dataB.emptyParking();
			contNum = dataB.lastContract() + 1;
			ContractNum.Text = contNum.ToString();
			if (carsToBuy != null)
				fillCarInfo();
		}

		// Pressing Close button
		private void cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		// Pressing "Enter" key calls fillInfoOfClientAndCar function
		private void ContractNum_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (ContractNum.Text != (contNum - 1).ToString() && int.TryParse(ContractNum.Text, out contNum))
				{
					chengeCar = dataB.ContractClient(contNum);
					if (chengeCar != null)
						fillInfoOfClientAndCar();
				}
			}
		}

		// Fills info of Client and car
		public void fillInfoOfClientAndCar()
		{
			ID.Text = chengeCar.Person.ID;
			FirstName.Text = chengeCar.Person.FirstName;
			LastName.Text = chengeCar.Person.LastName;
			City.Text = chengeCar.Person.City;
			Street.Text = chengeCar.Person.Street;
			phoneNumber.Text = chengeCar.Person.PhoneNumber;
			licenceNumber.Text = chengeCar.CosCar.LicenseNumber.ToString();
			Brand.Text = chengeCar.CosCar.Brand;
			Model.Text = chengeCar.CosCar.Model;
			EngeCapacity.Text = chengeCar.CosCar.Engi_capacity;
			Color.Text = chengeCar.CosCar.Color;
			Millege.Text = chengeCar.CosCar.Mileage;
			YearCar.Text = chengeCar.CosCar.YearOfCar.ToString();
			passwordCar.Text = chengeCar.CosCar.CodeInCar;
			TestDate.Text = chengeCar.CosCar.DateOfTest.ToString();
			CerDate.Text = chengeCar.CosCar.DateOfLastCarCare.ToString();
			price.Text = chengeCar.CosCar.Price.ToString();
		}

		// Pressing "Enter" key calls fillCostumerInfo function
		private void ID_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				if (ID.Text.Length == 9)
				{
					costumer = dataB.findPerson(ID.Text);
					ID.Text ="";
					if (costumer != null)
						fillCostumerInfo();
					else
						MessageBox.Show("לקוח לא קיים");
				}
		}

		// Fills costumer info
		public void fillCostumerInfo()
		{
			ID.Text = costumer.ID;
			FirstName.Text = costumer.FirstName;
			LastName.Text = costumer.LastName;
			City.Text = costumer.City;
			Street.Text = costumer.Street;
			phoneNumber.Text = costumer.PhoneNumber;
		}

		// Pressing "Enter" key calls fillCarInfo function
		private void licenceNumber_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (licenceNumber.Text != "")
					carsToBuy = dataB.CheckCarOnParking(int.Parse(licenceNumber.Text));
				licenceNumber.Text = "";
				if (carsToBuy != null)
					fillCarInfo();
				else
					MessageBox.Show("רכב כבר לא נמצא בחנייה");
			}
		}

		// Pressing Contract Cancelation button
		private void DropContract_Click(object sender, EventArgs e)
		{
			if (dataB.CheckCarOnParking(carToReturn.LicenseNumber) == null)
			{
				for (int i = 1; i < emptyParking.Length; i++)
					if (emptyParking[i])
						parkingNum.Items.Add(i);
				parking.Visible = true;
				parkingNum.Visible = true;
				returnCar.Visible = true;
			}
			else
			{
				dataB.DropContract(carToReturn.LicenseNumber, chengeCar.ContractNumber);
				dataB.UpdateCar(carToReturn);
				_main.fillInformation();
			}
		}

		// Utility function for loading the Form
		public void fillCarInfo()
		{
			licenceNumber.Text = carsToBuy.LicenseNumber.ToString();
			Brand.Text = carsToBuy.Brand;
			Model.Text = carsToBuy.Model;
			EngeCapacity.Text = carsToBuy.Engi_capacity;
			Color.Text = carsToBuy.Color;
			Millege.Text = carsToBuy.Mileage;
			YearCar.Text = carsToBuy.YearOfCar.ToString();
			passwordCar.Text = carsToBuy.CodeInCar;
			TestDate.Text = carsToBuy.DateOfTest.Date.ToString();
			CerDate.Text = carsToBuy.DateOfLastCarCare.Date.ToString();
			if (carToReturn != null)
				price.Text = (carsToBuy.Price - carToReturn.Price).ToString();
			else
				price.Text = carsToBuy.Price.ToString();
		}

		// Pressing Save new costumer info
		private void SavePerson_Click(object sender, EventArgs e)
		{
			if (ID.Text != "" && FirstName.Text != "" && LastName.Text != "" && City.Text != "" && Street.Text != "" && phoneNumber.Text != "")
				costumer = new Costumer(ID.Text, FirstName.Text, LastName.Text, phoneNumber.Text, Street.Text, City.Text);
			dataB.NewCostumer(costumer);
			MessageBox.Show("לקוח שמור");
			clearInfo();
		}

		// Fills Car info
		public void fiilCarReturnInfo()
		{
            double pr;
            if(!double.TryParse(price.Text,out pr)&&pr<=0)
            {
                MessageBox.Show("מחיר הוזן לא חוקי");
            }
			carToReturn.Mileage = Millege.Text;
            if (worker.Role.Equals("נציג מכירות"))
            {
                carToReturn.PurposeOfCar = "רכב מכירה";
                carToReturn.Status = "רכב מכירה";
            }
            else
            {
                carToReturn.PurposeOfCar = "רכב השכרה";
                carToReturn.Status = "רכב השכרה";
            }
            carToReturn.CodeInCar = passwordCar.Text;
			carToReturn.DateOfTest = DateTime.Parse(TestDate.Text).Date;
			carToReturn.DateOfLastCarCare = DateTime.Parse(CerDate.Text).Date;
			carToReturn.Price = pr;
		}

		// Pressing Return car to garage
		private void returnCar_Click(object sender, EventArgs e)
		{
			if (parkingNum.SelectedItem.Equals(""))
			{
				MessageBox.Show("נא לבחור מספר חניה");
				return;
			}
			carToReturn = chengeCar.CosCar;
			fiilCarReturnInfo();
            if (carToReturn.Price < 0)
                return;
			dataB.InsertParking(carToReturn, int.Parse(parkingNum.SelectedItem.ToString()));
			dataB.DropContract(carToReturn.LicenseNumber, chengeCar.ContractNumber);
			dataB.UpdateCar(carToReturn);
			_main.fillInformation();
		}

		// Pressing Submit button
		private void submit_Click(object sender, EventArgs e)
		{
			if (costumer == null)
			{
				if (ID.Text != "" && FirstName.Text != "" && LastName.Text != "" && City.Text != "" && Street.Text != "" && phoneNumber.Text != "")
					costumer = new Costumer(ID.Text, FirstName.Text, LastName.Text, phoneNumber.Text, Street.Text, City.Text);
				dataB.NewCostumer(costumer);
			}
			carsToBuy.Status = "נמכר";
			newContract = new Contract(carsToBuy, costumer, int.Parse(ContractNum.Text), DateTime.Now.Date);
			dataB.insertContract(newContract);
			dataB.exitCarFromParking(carsToBuy.LicenseNumber);
			_main.fillInformation();
			this.Close();
		}

		// Clears all textBoxes
		public void clearInfo()
		{
			ID.Text = "";
			FirstName.Text = "";
			LastName.Text = "";
			City.Text = "";
			Street.Text = "";
			phoneNumber.Text = "";
			licenceNumber.Text = "";
			Brand.Text = "";
			Model.Text = "";
			EngeCapacity.Text = "";
			Color.Text = "";
			Millege.Text = "";
			YearCar.Text = "";
			passwordCar.Text = "";
			TestDate.Text = "";
			CerDate.Text = "";
			price.Text = "";
		}
	}
}
