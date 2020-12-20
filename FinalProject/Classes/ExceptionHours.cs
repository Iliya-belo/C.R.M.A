using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Classes
{
	public class ExceptionHours
	{
		// Fields
		private Mission mission;
		private Employee employee;

		// Constructor
		public ExceptionHours(Mission mission, Employee employee)
		{
			Mission = mission;
			Employee = employee;
		}

		// Getters/Setters //////////////
		public Mission Mission
		{
			get { return mission; }
			set { mission = value; }
		}

		public Employee Employee
		{
			get { return employee; }
			set { employee = value; }
		}
		/////////////////////////////////
	}
}
