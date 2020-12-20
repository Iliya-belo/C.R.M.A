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
	public partial class InsertForm : Form
	{
		// Fields
		private Database.DbMySQL dataB = Database.DbMySQL.Instance;
		private Contract cars;
		private Mission mission;
		private MissionList missionList;
		private Garage[] allGarage;
		private readonly insertCarToGarage _insert;

		// Constructor
		public InsertForm(object missions, string licenceNum, insertCarToGarage insert)
		{
			_insert = insert;
			int[] daysInMounth = { 30, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
			int days = 0, month = DateTime.Today.Month, year = DateTime.Today.Year;
			days = DateTime.Today.Day - 14;
			if (days <= 0)
			{
				month--;
				days = daysInMounth[month - 1]; // TODO: major problem.. there is DateTime.DaysInMonth
				if (month < 0)
				{
					month = 1;
					year--;
				}
			} // TODO: can be put on a function
			InitializeComponent();
			DateTime temp = new DateTime(year, month, days);
			dateTimeInsertGarage.MinDate = temp.Date;
			dateTimeInsertGarage.MaxDate = DateTime.Now.Date;
			mission = (Mission)missions;
			cars = dataB.ContractCar(licenceNum);
			if (cars != null && mission != null)
				fillInfo();
			else
			{
				MessageBox.Show("לא קיים אירוע משבוקש");
				this.Close();
			}
		}

		public InsertForm(object missions, string licenceNum, object missionLists)
		{
			InitializeComponent();
			mission = (Mission)missions;
			missionList = (MissionList)missionLists;
			cars = dataB.ContractCar("" + licenceNum);
			if (cars != null && missionList != null && mission != null)
				fillUpdateInfo();
			else
			{
				MessageBox.Show("לא קיים אירוע משבוקש");
				this.Close();

			}
		}
		/////////////////////////////////

		// Pressing Close button
		private void Exit_Click(object sender, EventArgs e)
		{
			Close();
		}

		// Loading Form entities
		private void InsertForm_Load(object sender, EventArgs e)
		{
			allGarage = dataB.ListOfGarage();
			if (allGarage != null)
				for (int i = 0; i < allGarage.Length; i++)
					GarageNum.Items.Add(allGarage[i].ID + "-" + allGarage[i].GarageName);
		}

		// Fills info
		private void fillInfo()
		{
			licensNum.Text = cars.CosCar.LicenseNumber.ToString();
			textMVANo.Text = cars.CosCar.MVANumber;
			textManufacture.Text = cars.CosCar.Brand;
			textModel.Text = cars.CosCar.Model;
			Eng_cap.Text = cars.CosCar.Engi_capacity;
			textCarYear.Text = cars.CosCar.YearOfCar.ToString();
			textMilege.Text = cars.CosCar.Mileage;
			DateTest.Value = cars.CosCar.DateOfTest;
			DateLastCarCare.Value = cars.CosCar.DateOfLastCarCare;
			EventNum.Text = mission.MissionID.ToString();
			InfoOfMission.Text = mission.Description;
		}

		// Fills updated info
		private void fillUpdateInfo()
		{
			licensNum.Text = cars.CosCar.LicenseNumber.ToString();
			textMVANo.Text = cars.CosCar.MVANumber;
			textManufacture.Text = cars.CosCar.Brand;
			textModel.Text = cars.CosCar.Model;
			Eng_cap.Text = cars.CosCar.Engi_capacity;
			textCarYear.Text = cars.CosCar.YearOfCar.ToString();
			textMilege.Text = cars.CosCar.Mileage;
			DateTest.Value = cars.CosCar.DateOfTest;
			DateLastCarCare.Value = cars.CosCar.DateOfLastCarCare;
			EventNum.Text = mission.MissionID.ToString();
			InfoOfMission.Text = mission.Description;
			GarageNum.Text = missionList.GarageID.ToString();
			GarageNum.Enabled = false;
			CurrantActivity.Text = missionList.CurrentActivity;
			TextComponent.Text = missionList.ComponentStatusToOrder.ToString();
			ComponentsReady.Text = missionList.ComponentStatusReady.ToString();
			dateTimeInsertGarage.Value = missionList.DaysOfState;
			dateTimeInsertGarage.Enabled = false;
		}

		// Pressing Update button
		private void UpdateCar_Click(object sender, EventArgs e)
		{
			if (!checkInform())
			{
				MessageBox.Show("אחד מהנתונים שגוים תבדוק שוב");
				return;
			}
			if (missionList == null)
			{
				MessageBox.Show("לא ניתנן לעדכן רכב שלא נמצא במוסך");
				return;
			}
			missionList.ComponentStatusReady = int.Parse(ComponentsReady.Text);
			missionList.ComponentStatusToOrder = int.Parse(TextComponent.Text);
			missionList.CurrentActivity = CurrantActivity.Text;
			if (missionList.ComponentStatusToOrder == missionList.ComponentStatusReady)
				missionList.ReadyDays = DateTime.Now.Date;
			dataB.UpdateMissionList(missionList);
			MessageBox.Show("אירוע עודכן בהצלחה");
			this.Close();
		}

		// Checks filled info
		private bool fillAllInfo() // TODO: can be improved
		{
			int num = 0;
			string[] spliter;
			if (GarageNum.Text == "")
				return false;
			spliter = GarageNum.Text.Split('-');
			if (int.TryParse(spliter[0], out num) == false)
				return false;
			if (checkInform() == false)
				return false;
			missionList = new MissionList(mission.MissionID, CurrantActivity.Text, dateTimeInsertGarage.Value, dateTimeInsertGarage.Value, int.Parse(TextComponent.Text), int.Parse(ComponentsReady.Text), num);
			return true;
		}

		// Checks Current activity textBoxes
		private bool checkInform()
		{
			int num1, num2;
			if (CurrantActivity.Text != "" && int.TryParse(TextComponent.Text, out num1) && int.TryParse(ComponentsReady.Text, out num2))
				if (num1 > 0 && num2 > 0)
					return true;
			return false;
		}

		// Pressing Add button
		private void insertCar_Click(object sender, EventArgs e)
		{
			int garageId;
			if (fillAllInfo() == false)
			{
				MessageBox.Show("נתונים שגוים");
				return;
			}
			string[] spliter;
			spliter = GarageNum.Text.Split('-');
			garageId = int.Parse(spliter[0]);
			dataB.insertMissionList(missionList);
			dataB.insertExitGarage(cars.CosCar.LicenseNumber, garageId);
			MessageBox.Show("רכב הוסף בהצלחה");
			_insert.insertCarToGarage_Load(null, EventArgs.Empty);
			Close();
		}

		// Pressing Costumer info button
		private void CostumerInfo_Click(object sender, EventArgs e)
		{
			MessageBox.Show(cars.Person.FirstName + "" + cars.Person.LastName + "" + cars.Person.PhoneNumber);
		}
	}
}
