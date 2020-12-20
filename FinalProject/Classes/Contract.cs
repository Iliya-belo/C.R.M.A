using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Classes
{
	class Contract
	{
		// Fields
		private Car cosCar;
		private Costumer person;
		private int contractNumber;
		private DateTime contractTime;

		// Constructor
		public Contract(Car cosCar, Costumer person, int contractNumber, DateTime contractTime)
		{
			CosCar = cosCar;
			Person = person;
			this.contractNumber = contractNumber;
			this.contractTime = contractTime;
		}

		// Getters/Setters //////////////
		public Car CosCar
		{
			get { return cosCar; }
			set { cosCar = value; }
		}

		public Costumer Person
		{
			get { return person; }
			set { person = value; }
		}

		public int ContractNumber
		{
			get { return contractNumber; }
		}

		public DateTime ContractTime
		{
			get { return contractTime; }
		}
		/////////////////////////////////
	}
}
