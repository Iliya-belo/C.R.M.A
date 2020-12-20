using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Classes
{
	class Costumer
	{
		// Fields
		private string id;
		private string firstName;
		private string lastName;
		private string phoneNumber;
		private string street;
		private string city;

		// Constructor
		public Costumer(string id, string firstName, string lastName, string phoneNumber, string street, string city)
		{
			ID = id;
			FirstName = firstName;
			LastName = lastName;
			PhoneNumber = phoneNumber;
			Street = street;
			City = city;
		}

		// Getters/Setters //////////////
		public string ID
		{
			get
			{
				return id;
			}
			set
			{
				if (value != string.Empty)
					if (value.Length == 9)
						id = value;
					else
						System.Windows.Forms.MessageBox.Show("Invalid ID");
			}
		}

		public string FirstName
		{
			get
			{
				return firstName;
			}
			set
			{
				if (value != string.Empty)
					if (value.All(char.IsDigit))
						System.Windows.Forms.MessageBox.Show("Invalid Name");
					else
						firstName = value;
			}
		}

		public string LastName
		{
			get
			{
				return lastName;
			}
			set
			{
				if (value != string.Empty)
					if (value.All(char.IsDigit))
						System.Windows.Forms.MessageBox.Show("Invalid Last Name");
					else
						lastName = value;
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
		/////////////////////////////////
	}
}
