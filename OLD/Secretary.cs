using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Classes
{
	class Secretary : Employee
	{
		public Secretary(string id, string firstName, string lastName, string mail, string city, string street, string houseNumber, string phoneNumber, string role, int experience)
			: base(id, firstName, lastName, mail, city, street, houseNumber, phoneNumber, role, experience)
		{
		}
	}
}
