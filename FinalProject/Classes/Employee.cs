using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Classes
{
	public class Employee
	{
		// Fields
		protected string id;
		protected string firstName;
		protected string lastName;
		protected string mail;
		protected string city;
		protected string street;
		protected string houseNumber;
		protected string phoneNumber;
		protected string role;
		protected double experience;

		// Constructors /////////////////
		public Employee()
		{

		}

		public Employee(string id, string firstName, string lastName, string mail, string city, string street, string houseNumber, string phoneNumber, string role, double experience)
		{
			ID = id;
			FirstName = firstName;
			LastName = lastName;
			Mail = mail;
			City = city;
			Street = street;
			HouseNumber = houseNumber;
			PhoneNumber = phoneNumber;
			Role = role;
			Experience = experience;
		}
		/////////////////////////////////

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

		public string Mail
		{
			get
			{
				return mail;
			}
			set
			{
				if (value != string.Empty)
					if (value.Contains("@"))
						mail = value;
					else
						System.Windows.Forms.MessageBox.Show("Invalid syntax for Mail");
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

		public string HouseNumber
		{
			get
			{
				return houseNumber;
			}
			set
			{
				if (value != string.Empty)
					if (value.Length > 4)
						System.Windows.Forms.MessageBox.Show("Invalid House Number");
					else
						houseNumber = value;
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

		public string Role
		{
			get
			{
				return role;
			}
			set
			{
				if (value != string.Empty)
					if (value.All(char.IsDigit))
						System.Windows.Forms.MessageBox.Show("Invalid Role");
					else
						role = value;
			}
		}

		public double Experience
		{
			get
			{
				return experience;
			}
			set
			{
				if (value > 0)
					experience = value;
				else
					System.Windows.Forms.MessageBox.Show("Invalid Experience");
			}
		}
		/////////////////////////////////
	}
}
