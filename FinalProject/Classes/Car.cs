using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Classes
{
	class Car
	{
		// Fields
		private string mvaNumber;
		private int licenseNumber;
		private string brand;
		private string model;
		private int yearOfCar;
		private string color;
		private string mileage;
		private string codeInCar;
		private string status;
		private DateTime dateOfTest;
		private string engi_capacity;
		private string purposeOfCar;
		private string dataOfCar;
		private string nameOfCompany;
		private DateTime dateOfLastCarCare;
		private double price;

		// Constructor
		public Car(string mvaNumber, int licenseNumber, string brand, string model, string engi_capacity, string colorCar, int yearOfCar, string mileage, string codeInCar, string status, DateTime dateOfTest, string purposeOfCar, string dataOfCar, string nameOfCompany, DateTime dateOfLastCarCare, double price)
		{
			this.mvaNumber = mvaNumber;
			LicenseNumber = licenseNumber;
			Brand = brand;
			Model = model;
			Engi_capacity = engi_capacity;
			YearOfCar = yearOfCar;
			Color = colorCar;
			Mileage = mileage;
			CodeInCar = codeInCar;
			Status = status;
			DateOfTest = dateOfTest;
			PurposeOfCar = purposeOfCar;
			DataOfCar = dataOfCar;
			NameOfCompany = nameOfCompany;
			DateOfLastCarCare = dateOfLastCarCare;
			Price = price;
		}

		// Getters/Setters //////////////
		public string MVANumber
		{
            get { return mvaNumber; }
		}

		public int LicenseNumber
		{
			get { return licenseNumber; }
			set { licenseNumber = value; }
		}

		public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		public string Engi_capacity
		{
			get { return engi_capacity; }
			set { engi_capacity = value; }
		}

		public int YearOfCar
		{
			get { return yearOfCar; }
			set { yearOfCar = value; }
		}

		public string Color
		{
			get { return color; }
			set { color = value; }
		}

		public string Mileage
		{
			get { return mileage; }
			set { mileage = value; }
		}

		public string CodeInCar
		{
			get { return codeInCar; }
			set { codeInCar = value; }
		}

		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		public DateTime DateOfTest
		{
			get { return dateOfTest; }
			set { dateOfTest = value; }
		}

		public string PurposeOfCar
		{
			get { return purposeOfCar; }
			set { purposeOfCar = value; }
		}

		public string DataOfCar
		{
			get { return dataOfCar; }
			set { dataOfCar = value; }
		}

		public string NameOfCompany
		{
			get { return nameOfCompany; }
			set { nameOfCompany = value; }
		}

		public DateTime DateOfLastCarCare
		{
			get { return dateOfLastCarCare; }
			set { dateOfLastCarCare = value; }
		}

		public double Price
		{
			get { return price; }
			set { price = value; }
		}
		/////////////////////////////////
	}
}
