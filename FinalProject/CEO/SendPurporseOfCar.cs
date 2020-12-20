using FinalProject.Classes;
using FinalProject.Driver;
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
	public partial class SendPurporseOfCar : Form
	{
		private Employee[] secutery;
		private Employee thisSecutery;
		private Car car;
		private Database.DbMySQL dataB = Database.DbMySQL.Instance;
		private readonly listOfCarsToBeApproved _listCar;
		public SendPurporseOfCar(object candidateCar, listOfCarsToBeApproved form)
		{
			InitializeComponent();
			car = (Car)candidateCar;
			_listCar = form;
		}

		private void SendPurporseOfCar_Load(object sender, EventArgs e)
		{
			secutery = dataB.findSecutery();
			if (secutery != null)
				fillChoses();
		}
		private void fillChoses()
		{
			dataWorkers.RowCount = secutery.Length;
			for (int i = 0; i < secutery.Length; i++)
			{
				dataWorkers[0, i].Value = secutery[i].ID;
				dataWorkers[1, i].Value = secutery[i].FirstName + " " + secutery[i].LastName;
			}
		}
		private void dataWorkers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			dataWorkers.Visible = false;
			nameWorker.Text = secutery[e.RowIndex].FirstName + " " + secutery[e.RowIndex].LastName;
			thisSecutery = secutery[e.RowIndex];
		}

		private void exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void send_Click(object sender, EventArgs e)
		{
			if (CheckInfo())
			{
				sendMailText();
				dataB.ChangeCandidateCarStatusAfterRefuse(car.LicenseNumber);
				MessageBox.Show("העובד הודכן בהצלחה");
				_listCar.Refresh();
				this.Close();
			}
			else
				MessageBox.Show("אחד מהנתונים לא הושלם");
		}
		private bool CheckInfo()
		{
			if (nameWorker.Text != "" && thisSecutery != null && purporseOfCar.SelectedItem.ToString() != "" && MailText.Text != "")
				return true;
			return false;
		}
		private void sendMailText()
		{
			email em = new email();
			string mailString = "  לכבוד";
			mailString += " " + thisSecutery.FirstName + " " + thisSecutery.LastName + "  " + " נדרדש לשנות רכב ל" + " " + purporseOfCar.SelectedItem.ToString() + " " + MailText.Text;
			em.sendeMail(mailString, thisSecutery.Mail);
		}
	}
}
