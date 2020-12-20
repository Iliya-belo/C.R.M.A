using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Database
{
	class LogIn
	{
		// Fields
		private string id;
		private string password;

		// Constructor
		public LogIn(string Id, string Password)
		{
			id = Id;
			password = Password;
		}

		// Getters ////
		public string ID
		{
			get
			{
				return id;
			}
		}

		public string Password
		{
			get
			{
				return password;
			}
		}
		///////////////
	}
}
