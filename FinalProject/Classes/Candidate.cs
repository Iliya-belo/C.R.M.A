using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Classes
{
	class Candidate : Employee
	{
		// Fields
		private string password;

		// Constructor
		public Candidate(string id, string firstName, string lastName, string mail, string city, string street, string houseNumber, string phoneNumber, string role, double experience, string password)
			: base(id, firstName, lastName, mail, city, street, houseNumber, phoneNumber, role, experience)
		{
			this.password = password;
		}

		// Getter/Setter
		public string Password
		{
			get { return password; }
		}
	}
}
