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

namespace FinalProject.Secretary
{
	public partial class ChengePurporseCar : Form
	{
		private Car carToChenge = null;
		private Car[] CarList;
		private int i = 0;
		private Database.DbMySQL dataB = Database.DbMySQL.Instance;

		public ChengePurporseCar()
		{
			InitializeComponent();
		}

		// Pressing "Escape" key to close the Form
		protected override bool ProcessDialogKey(Keys keyData)
		{
			if (ModifierKeys == Keys.None && keyData == Keys.Escape)
			{
				Close();
				return true;
			}
			return base.ProcessDialogKey(keyData);
		}

		//function to find list of cars to the chose 
		private void textCarNo_TextChanged(object sender, EventArgs e)
		{
			int carNum;
			if (textCarNo.Text != "" && int.TryParse(textCarNo.Text, out carNum) && carToChenge == null)
			{
				dataCars.Visible = true;
				CarList = dataB.FindCarToChengePur(carNum);
				if (CarList == null)
				{
					MessageBox.Show("הרכב מבוקש לא נמצא ברשימה נבדה שהרכב לא נמצא אצל לקוח");
					dataCars.Visible = false;
					dataCars.RowCount = 1;
					dataCars.Rows.Clear();
				}
				else
					fillTebleFindCar();
			}
		}

		//function to fill table of options the cars
		private void fillTebleFindCar()
		{
			dataCars.ColumnCount = 1;
			dataCars.RowCount = CarList.Length;
			for (i = 0; i < CarList.Length; i++)
				dataCars[0, i].Value = CarList[i].LicenseNumber;
		}

		//function to fill information of car 
		private void fillCarInfo(Car options)
		{
			textMVANo.Text = options.MVANumber;
			textCarNo.Text = options.LicenseNumber.ToString();
			Car_name.SelectedText = options.Brand;
			textModel.Text = options.Model;
			Eng_cap.SelectedText = options.Engi_capacity;
			Car_color.SelectedText = options.Color;
			textCarYear.Text = options.YearOfCar.ToString();
			textMilege.Text = options.Mileage;
			textCarPassword.Text = options.CodeInCar;
			DateTest.Value = options.DateOfTest;
			textCarInfo.Text = options.DataOfCar;
			DateLastCarCare.Value = options.DateOfLastCarCare;
		}

		//function to pick the car from car list 
		private void dataCars_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			dataCars.Visible = false;
			carToChenge = CarList[e.RowIndex];
			fillCarInfo(carToChenge);
		}

		// Returns true if the textBoxes are not empty
		public bool CarCheck()
		{
			double price;
			if ((textCarNo.Text.Length != 0) && (!comboPurpose.Items.Equals(null)) && (textPrice.Text.Length != 0) && (double.TryParse(textPrice.Text, out price) && price > 0))
				return true;
			return false;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (CarCheck() && comboPurpose.SelectedItem.ToString() != carToChenge.PurposeOfCar)
			{
				updateInfo();
				if (carToChenge.PurposeOfCar.Equals("רכב עבודה"))
				{
                    carToChenge.Status = "Wait";
                    dataB.exitCarFromParking(carToChenge.LicenseNumber);
					dataB.DropCar(carToChenge.LicenseNumber);
					dataB.InsertCandidateCar(carToChenge);
				}
				else
					dataB.UpdateCar(carToChenge);
				MessageBox.Show("מטרה של הרכב השתנה בהצלחה");
				this.Close();
			}
		}

		private void updateInfo()
		{
			carToChenge.PurposeOfCar = comboPurpose.Text;
			carToChenge.Mileage = textMilege.Text;
			carToChenge.Price = double.Parse(textPrice.Text);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
