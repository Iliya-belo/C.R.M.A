using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Classes
{
	class Garage
	{
		// Fields
		private int id;
		private string garageName;
		private string phoneNumber;
		private string street;
		private string city;
		private string houseNumber;

		// Constructor
		public Garage(int id, string garageName, string phoneNumber, string street, string city, string houseNumber)
		{
			ID = id;
			GarageName = garageName;
			PhoneNumber = phoneNumber;
			Street = street;
			City = city;
			HouseNumber = houseNumber;
		}

		// Getters/Setters //////////////
		public int ID
		{
			get
			{
				return id;
			}
			set
			{
				if (value > 0)
					id = value;
				else
					System.Windows.Forms.MessageBox.Show("Invalid ID");
			}
		}

		public string GarageName
		{
			get
			{
				return garageName;
			}
			set
			{
				if (value != string.Empty)
					if (value.All(char.IsDigit))
						System.Windows.Forms.MessageBox.Show("Invalid Garage name");
					else
						garageName = value;
			}
		}

		public string PhoneNumber
		{
			get
			{
				return phoneNumber;
			}
			set
			{
				if (value != string.Empty)
					if (value.Length != 10 && !value.All(char.IsDigit))
						//if (value.Length != 14 && !value.Contains("+") && value.All) if number is international
						System.Windows.Forms.MessageBox.Show("Invalid Phone Number");
					else
						phoneNumber = value;
			}
		}

		public string Street
		{
			get
			{
				return street;
			}
			set
			{
				if (value != string.Empty)
					if (value.All(char.IsDigit))
						System.Windows.Forms.MessageBox.Show("Invalid Street");
					else
						street = value;
			}
		}

		public string City
		{
			get
			{
				return city;
			}
			set
			{
				if (value != string.Empty)
					if (value.All(char.IsDigit))
						System.Windows.Forms.MessageBox.Show("Invalid City");
					else
						city = value;
			}
		}
		public string HouseNumber
		{
			get { return houseNumber; }
			set
			{
				if (value != string.Empty)
						houseNumber = value;
			}
		}
		/////////////////////////////////
	}
}
