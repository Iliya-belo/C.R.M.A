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

namespace FinalProject
{
	public partial class addCar : Form
	{
		// Fields
		private Car new_car;
		private Car[] changeStatus;
        DateTime dt = DateTime.Now;
        //	private string translate;
        private int i = 0;
		private bool[] emptyParking;
		private Database.DbMySQL dataB = Database.DbMySQL.Instance;

		// Constructor
		public addCar()
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

		// Loading Form entities
		private void addCar_Load(object sender, EventArgs e)
		{
            DateTime dlc = DateTime.Now;
            dlc=dlc.AddYears(-1);
            dt = dt.AddYears(1);
            DateTest.CustomFormat = "dd/MM/yyyy";
            DateTest.MaxDate =dt;
            DateLastCarCare.MaxDate = DateTime.Now;
            DateLastCarCare.MinDate = dlc;
            changeStatus = dataB.CarToChange();
			if (changeStatus != null)
				ChangeStatus();
			emptyParking = dataB.emptyParking();
			for (int i = 1; i < emptyParking.Length; i++)
				if (emptyParking[i])
					EmptyParkngPlaces.Items.Add(i);
		}

		// Pressing Add button
		private void btnAddCar_Click(object sender, EventArgs e)
		{
            bool flag = true;
			if (CarCheck())
			{
				if (comboPurpose.SelectedItem.Equals("רכב עבודה"))
				{
					SaveCar();
                    for (int i = 0; i < changeStatus.Length; i++)
                        if (new_car.LicenseNumber == changeStatus[i].LicenseNumber)
                            flag = false;
					new_car.Status = "Wait";
					if (flag)
						dataB.InsertCandidateCar(new_car);
					else
						dataB.ChengeCandidateCar(new_car);
					MessageBox.Show("נא להמתין לתשובה של מנהל הארגון");
				}
				else
				{
					SaveCar();
					dataB.InsertCar(new_car);
					dataB.InsertParking(new_car, int.Parse(EmptyParkngPlaces.SelectedItem.ToString()));
					MessageBox.Show("רכב הוסף בהצלחה");
				}
				if (i + 1 >= changeStatus.Length)
					Close();
				else
				{
					dataB.deleteCandidateCar(changeStatus[i].LicenseNumber);
					Empty();
					i++;
					ChangeStatus();
				}
			}
			else
				MessageBox.Show("אחד מהנתונים שגויים. נסה שוב");
		}

		// Pressing Close button
		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		// Returns true if the textBoxes are not empty
		public bool CarCheck()
		{
			double num;
			if (changeStatus == null)
			{
				if (textCarNo.Text.Length != 0)
					if (textMVANo.Text.Length != 0)
						if (!Car_name.SelectedItem.Equals(""))
							if (textModel.Text.Length != 0)
								if (!Eng_cap.Items.Equals(null))
									if (textCarYear.Text.Length != 0)
										if (textCarPassword.Text.Length != 0)
											if (textCarInfo.Text.Length != 0)
												if (!comboPurpose.Items.Equals(null))
													if (double.TryParse(textPrice.Text, out num))
														if (!Car_color.SelectedItem.Equals(""))
															if (!EmptyParkngPlaces.SelectedItem.Equals(""))
																if (num > 0)
																	return true;
			}
			else
				 if (double.TryParse(textPrice.Text, out num))
				if (num > 0)
					if (!comboPurpose.Items.Equals(null))
						if (!EmptyParkngPlaces.SelectedItem.Equals(""))
							return true;
			return false;
		}

		// Saves Car properties
		public void SaveCar()
		{
			new_car = new Car(textMVANo.Text, int.Parse(textCarNo.Text), Car_name.SelectedText.ToString(),
				textModel.Text, Eng_cap.SelectedText.ToString(), Car_color.SelectedText.ToString(), int.Parse(textCarYear.Text), textMilege.Text, textCarPassword.Text, "Ready", DateTest.Value, textCarInfo.Text,
				comboPurpose.SelectedText.ToString(), "Avic", DateLastCarCare.Value, double.Parse(textPrice.Text));
		}

		// Changes Status of a car
		public void ChangeStatus()
		{
			textMVANo.Text = changeStatus[i].MVANumber;
			textCarNo.Text = changeStatus[i].LicenseNumber.ToString();
			Car_name.SelectedText = changeStatus[i].Brand;
			textModel.Text = changeStatus[i].Model;
			Eng_cap.SelectedText = changeStatus[i].Engi_capacity;
			Car_color.SelectedText = changeStatus[i].Color;
			textCarYear.Text = changeStatus[i].YearOfCar.ToString();
			textMilege.Text = changeStatus[i].Mileage;
			textCarPassword.Text = changeStatus[i].CodeInCar;
			DateTest.Value = changeStatus[i].DateOfTest;
			textCarInfo.Text = changeStatus[i].DataOfCar;
			DateLastCarCare.Value = changeStatus[i].DateOfLastCarCare;
		}

		// Empties 1 textBox
		public void Empty()
		{
			textPrice.Text = "";
		}

        private void textCarYear_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (textCarYear.Text.Length == 4)
                if (int.TryParse(textCarYear.Text, out num))
                    if (num == DateTime.Now.Year)
                    {
                        DateTest.MinDate = DateTime.Now;
                        dt =dt.AddYears(1);
                        DateTest.MaxDate = dt;
                    }

        }
    }
}
