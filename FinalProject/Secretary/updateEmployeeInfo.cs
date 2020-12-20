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

namespace FinalProject
{
	public partial class updateEmployeeInfo : Form
	{
		// Fields
		private DbMySQL dataB = DbMySQL.Instance;
		private Employee emp;
		private string myID;
		private hashing password = new hashing();

		// Constructors /////////////////
		public updateEmployeeInfo()
		{
			InitializeComponent();
			myID = "";
		}

		public updateEmployeeInfo(string id)
		{
			InitializeComponent();
			myID = id;
			emp = dataB.AuthenticateEmployee(myID);
			textID.Text = myID;
			FillEmployeeInfo(emp);
		}
		/////////////////////////////////

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

		// Pressing the update button
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			bool flag = false;
			int num;
			if (myID == "" || updateWhatIcan())
				if ((textID.Text.Length == 9) && int.TryParse(textID.Text, out num))
				{
					emp = dataB.AuthenticateEmployee(textID.Text);
					if (Change(emp))
					{
						dataB.UpdateEmployee(emp);
						MessageBox.Show("נתונים נשמרו בהצלחה");
						flag = true;
					}
					if (textOldPassword.Text != "")
						PasswordUpdate();
					if (flag)
						Close();
					else
						MessageBox.Show("נתונים לא השתנו");
				}
				else
				{
					MessageBox.Show("תז לא תקינה");
					textID.Text = "";
				}
			else
				updateWhatIcan();
		}

		// Pressing "Enter" key while on textID textField
		private void textID_KeyDown(object sender, KeyEventArgs e)
		{
			int num;
			emp = new Employee();
			if (e.KeyCode == Keys.Enter)
			{
				if ((textID.Text.Length == 9) && int.TryParse(textID.Text, out num))
					emp = dataB.AuthenticateEmployee(textID.Text);
				else
				{
					MessageBox.Show("תז לא תקינה");
					textID.Text = "";
				}
				if (myID == "" || updateWhatIcan())
					if (emp == null)
					{
						MessageBox.Show("תז לא תקינה");
						textID.Text = "";
						return;
					}
				FillEmployeeInfo(emp);
			}

		}

		// Fills employee info
		private void FillEmployeeInfo(Employee emp)
		{
			textFirstName.Text = emp.FirstName;
			textLastName.Text = emp.LastName;
			textEmail.Text = emp.Mail;
			textCity.Text = emp.City;
			textStreet.Text = emp.Street;
			textHouseNumber.Text = emp.HouseNumber;
			textPhoneNumber.Text = emp.PhoneNumber;
			textRole.Text = emp.Role;
		}

		private void FillEmployeeInfo()
		{
			emp.FirstName = textFirstName.Text;
			emp.LastName = textLastName.Text;
			emp.Mail = textEmail.Text;
			emp.City = textCity.Text;
			emp.Street = textStreet.Text;
			emp.HouseNumber = textHouseNumber.Text;
			emp.PhoneNumber = textPhoneNumber.Text;
			emp.Role = textRole.Text;
		}
		////////////////////////////////////////

		// Returns true if all parameter fields aren't empty
		private bool Change(Employee emp)
		{
			if (emp != null)
				if ((textFirstName.Text != emp.FirstName) || (textLastName.Text != emp.LastName) || (textEmail.Text != emp.Mail)
					|| (textCity.Text != emp.City) || (textStreet.Text != emp.Street) || (textHouseNumber.Text != emp.HouseNumber)
					|| (textPhoneNumber.Text != emp.PhoneNumber) || (textRole.Text != emp.Role))
				{
					FillEmployeeInfo();
					return true;
				}
			return false;
		}

		// Utility function for pressing the update button - Updating Password
		private void PasswordUpdate()
		{
			if (textOldPassword.Text.Equals("Admin123") || CheckPassword().Equals("the password is correct"))
			{
				if (textNewPassword.Text.Equals(textNewPassAuth.Text))
				{
					string newPassword = password.encryptPassword(textNewPassword.Text);
					dataB.UpdatePassword(emp.ID, newPassword);
					MessageBox.Show("סיסמה נשמרה בהצלחה");
					Close();
				}
				else
				{
					MessageBox.Show("הסיסמה לא נשמרה");
					return;
				}
			}
			else
			{
				MessageBox.Show("סיסמה שגויה");
				return;
			}
		}

		// Checks for legitimacy of employee id and role
		public bool updateWhatIcan()
		{
			if (emp.ID != myID)
			{
				MessageBox.Show("אין לך הרשאות לעשות את זה");
				emp = dataB.AuthenticateEmployee(myID);
				textID.Text = myID;
				return false;
			}
			if (textRole.Text != emp.Role)
			{
				MessageBox.Show("אין לך הרשאות לעשות את זה");
				textRole.Text = emp.Role;
				return false;
			}
			return true;
		}

		// Pressing Close button
		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		// Checks if encrypted password is the same as it decrypted
		private string CheckPassword()
		{
			LogIn person = new LogIn(emp.ID, textOldPassword.Text);
			string l = dataB.AuthenticatePassword(person);
			string answer = password.decryptPassword(l);
			if (person.Password.Equals(answer))
			{
				return "the password is correct";
			}
			else
			{
				return "wrong password";
			}
		}
	}
}
