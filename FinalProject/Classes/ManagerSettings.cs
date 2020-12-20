using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Classes
{
	class ManagerSettings
	{
		// Fields
		private int guideLineNumber;
		private string name;
		private string description;
		private int limitation;

		// Constructor
		public ManagerSettings(int guideLineNumber, string name, string description, int limitation)
		{
			GuideLineNumber = guideLineNumber;
			Name = name;
			Description = description;
			Limitation = limitation;
		}

		// Getters/Setters //////////////
		public int GuideLineNumber
		{
			get { return guideLineNumber; }
			set { guideLineNumber = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		public int Limitation
		{
			get { return limitation; }
			set { limitation = value; }
		}
		/////////////////////////////////
	}
}
