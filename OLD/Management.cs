using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Classes
{
	class Management : Employee
	{
		private int receptionHours;
		private string workPhoneNumber;
		private Car workCar;

		public Management(string id, string firstName, string lastName, string mail, string city, string street, string houseNumber, string phoneNumber, string role, int experience, int receptionHours, string workPhoneNumber, Car workCar)
			: base(id, firstName, lastName, mail, city, street, houseNumber, phoneNumber, role, experience)
		{
			ReceptionHours = receptionHours;
			WorkPhoneNumber = workPhoneNumber;
			WorkCar = workCar;
		}

		public int ReceptionHours
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
