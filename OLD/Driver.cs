using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Classes
{
	class Driver : Employee
	{
		private string driverCard;
		private DateTime licenseValidity;
		private string licenseType;

		public Driver(string id, string firstName, string lastName, string mail, string city, string street, string houseNumber, string phoneNumber, string role, string driverCard, DateTime licenseValidity, string licenseType, int experience) 
			: base(id, firstName, mail, lastName, city, street, houseNumber, phoneNumber, role, experience)
		{
			DriverCard = driverCard;
			LicenseValidity = licenseValidity;
			LicenseType = licenseType;
		}

		public string DriverCard
		{
			get; set;
		}

		public DateTime LicenseValidity
		{
			get; set;
		}

		public string LicenseType
		{
			get; set;
		}
	}
}
