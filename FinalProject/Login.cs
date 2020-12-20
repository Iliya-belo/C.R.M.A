using FinalProject.CEO;
using FinalProject.Classes;
using FinalProject.Database;
using FinalProject.Driver;
using FinalProject.JobManager;
using FinalProject.SellerOrRenter;
using FinalProject.Tester_SafetyManager;
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
	public partial class Login : Form
	{
		// Fields
		private DbMySQL dataB;
		private LogIn person;
		private int loginCount;

		// Constructor
		public Login()
		{
			InitializeComponent();
			loginCount = 0;
		}

		// Loading Form entities
		private void Login_Load(object sender, EventArgs e)
		{
			string path = "avic";
			DbMySQL.ConnectionString = path;
			dataB = DbMySQL.Instance;
		}

		// Pressing "Escape" button to close the Form
		protected override bool ProcessDialogKey(Keys keyData)
		{
			if (ModifierKeys == Keys.None && keyData == Keys.Enter)
			{
				btnLogin.PerformClick();
				return true;
			}
			return base.ProcessDialogKey(keyData);
		}

		// Pressing login button
		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (loginCount == 2)
			{
				MessageBox.Show("גאש למזכירות על מנת לאפס סיסמה");
				btnLogin.Enabled = false;
				textID.Text = "";
				textPassword.Text = "";
				return;
			}

			if (CheckID(textID.Text) && textPassword.Text != "")
			{
				string l = string.Empty;
				person = new LogIn(textID.Text, textPassword.Text);
				l = dataB.AuthenticatePassword(person);
				if (l == "")
				{
					MessageBox.Show("Invalid user credentials");
					loginCount++;
					ClearText();
					return;
				}
				l = CheckPassword(l);
				if (l != "wrong password")
				{
					Employee emp = dataB.AuthenticateEmployee(person.ID);
					if (emp != null)
						ApplicationEmp(emp.Role);
					ClearText();
				}
				else
				{
					ClearText();
					loginCount++;
				}
			}
			else if (textPassword.Text == "" && textID.Text.Length == 9)
				MessageBox.Show("סיסמה או תז לא יכולים להיות ראקים");
		}

		// Returns true if ID isn't empty and exactly 9 digits
		public bool CheckID(string str)
		{
			if (str == "")
			{
				MessageBox.Show("תז לא יכול להיות רק");
				return false;
			}
			if (str.Length < 9)
			{
				MessageBox.Show("תז חייב להחיל 9 ספרות בדיוק");
				return false;
			}
			return true;
		}

		// Switches menus to specific role
		public void ApplicationEmp(string s)
		{
			this.Hide();
			switch (s)
			{
				case "מזכיר":
					SecretaryMenu sm = new SecretaryMenu();
					sm.ShowDialog();
					break;
				case "מנהל":
					mainCEO ceo = new mainCEO();
					ceo.ShowDialog();
					break;
				case "נהג":
					DriverMain driver = new DriverMain(person.ID);
					driver.ShowDialog();
					break;
				case "מנהל משימות":
					JobManager.monthlyExecptionsHours jmm = new JobManager.monthlyExecptionsHours();
					jmm.ShowDialog();
					break;
				case "טסטר":
					TSMMain tm = new TSMMain();
					tm.ShowDialog();
					break;
				case "נציג מכירות":
					Main sl = new Main(person.ID, "נציג מכירות");
					sl.ShowDialog();
					break;
				case "נציג השכרה":
					Main rl = new Main(person.ID, "נציג השכרה");
					rl.ShowDialog();
					break;
				default:
					MessageBox.Show("לא קיים עובד");
					Close();
					break;
			}
			this.Show();
		}

		// Pressing help button
		private void btnHelp_Click(object sender, EventArgs e)
		{
			MessageBox.Show("בבקשה גש למזכירה");
			Close();
		}

		// Checks if encrypted password is the same as it decrypted
		private string CheckPassword(string l)
		{
			hashing password = new hashing();
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

		// Clears textBoxes
		private void ClearText()
		{
			textID.Text = "";
			textPassword.Text = "";
		}
	}
}
