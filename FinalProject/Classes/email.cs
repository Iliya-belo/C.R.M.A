using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net.Mail;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using FinalProject.Classes;

namespace FinalProject.Driver
{
	class email
	{
		// Field
		private Employee worker;

		// Constructor
		public email()
		{

		}

		// Getter/Setter
		/*	public Employee Epmper
			{
				get { return worker; }
				set
				{
					if (value != null)
						worker = value;
				}
			}
			*/
		// Sends email
		public void sendeMail(string emailString, string destination)
		{
			try
			{
				MailMessage mail = new MailMessage();

				SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

				SmtpServer.UseDefaultCredentials = false;
				SmtpServer.Credentials = new NetworkCredential("projectavic2020@gmail.com", "mama1702");
				SmtpServer.Port = 587;
				SmtpServer.EnableSsl = true;
				//string mailstring = emailString;
				//mailstring += "נמצה בחריגת שעות ביצוע משימה לטובת יצירת קשר עם עובד פנה למספר טפון הזה ";
				// mailstring += ":" + worker.PhoneNumber.ToString();

				mail.From = new MailAddress("projectavic2020@gmail.com");
				mail.Subject = "Mail from Avic Company ";
				mail.Body = emailString; // mailstring
				mail.To.Add(destination);
				// mail.To.Add("iliyabelo1995@gmail.com");

				SmtpServer.Send(mail);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}
