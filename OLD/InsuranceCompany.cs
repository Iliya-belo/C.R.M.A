using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Classes
{
	class InsuranceCompany
	{
		private int companyId;
		private string nameOfCompany;
		private string phoneNumber;
		private string mail;
		private string typeOfInsurance;

		public InsuranceCompany(int companyId, string nameOfCompany, string phoneNumber, string mail, string typeOfInsurance)
		{
			CompanyID = companyId;
			NameOfCompany = nameOfCompany;
			PhoneNumber = phoneNumber;
			Mail = mail;
			TypeOfInsurance = typeOfInsurance;
		}

		public int CompanyID
		{
			get;
		}

		public string NameOfCompany
		{
			get
			{
				return nameOfCompany;
			}
			set
			{
				if (value != string.Empty)
					if (value.All(char.IsDigit))
						System.Windows.Forms.MessageBox.Show("Invalid Company name");
					else
						nameOfCompany = value;
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

		public string Mail
		{
			get
			{
				return mail;
			}
			set
			{
				if (value != string.Empty)
					if (value.Contains("@gmail.com"))
						mail = value;
					else
						System.Windows.Forms.MessageBox.Show("Invalid syntax for Mail");
			}
		}

		public string TypeOfInsurance
		{
			get; set;
		}
	}
}
