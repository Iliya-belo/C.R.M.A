using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Classes
{
	class Lot
	{
		// Fields
		private int parkingNumber;
		private Car typeCar;
		private DateTime daysInLot;
		private int licenseNumber;
		private string comments;

		// Constructor
		public Lot(int parkingNumber, Car typeCar, DateTime daysInLot, int licenseNumber, string comments)
		{
			ParkingNumber = parkingNumber;
			TypeCar = typeCar;
			DaysInLot = daysInLot;
			LicenseNumber = licenseNumber;
			Comments = comments;
		}

		// Getters/Setters //////////////
		public int ParkingNumber
		{
			get { return parkingNumber; }
			set { parkingNumber = value; }
		}

		public Car TypeCar
		{
			get { return typeCar; }
			set { typeCar = value; }
		}

		public DateTime DaysInLot
		{
			get { return daysInLot; }
			set { daysInLot = value; }
		}

		public int LicenseNumber
		{
			get { return licenseNumber; }
			set { licenseNumber = value; }
		}

		public string Comments
		{
			get { return comments; }
			set { comments = value; }
		}
		/////////////////////////////////
	}
}
