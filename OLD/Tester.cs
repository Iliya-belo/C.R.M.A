using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Classes
{
	class Tester : Employee
	{
		private string driverCard;
		private string workPhoneNumber;
		private Car workCar;

		public Tester(string id, string firstName, string mail, string lastName, string city, string street, string houseNumber, string phoneNumber, string role, int experience, string driverCard, string workPhoneNumber, Car workCar)
			: base(id, firstName, mail, lastName, city, street, houseNumber, phoneNumber, role, experience)
		{
			DriverCard = driverCard;
			Mail = mail;
			WorkPhoneNumber = workPhoneNumber;
			WorkCar = workCar;
		}

		public string DriverCard
		{
			get; set;
		}

		public string WorkPhoneNumber
		{
			get; set;
		}

		public Car WorkCar
		{
			get; set;
		}
	}
}
