using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Classes
{
	public class Mission
	{
		// Fields
		private string workerID;
		private int missionId;
		private string status;
		private string description;
		private int contractNumber;
		private DateTime time;
		private int houers;
		private int carNumber;
		private int carChenge;

		// Constructor
		public Mission(string workerID, int missionId, string description, string status, int contractNum, DateTime time, int houers, int car_number)
		{
			Worker = workerID;
			MissionID = missionId;
			Description = description;
			Status = status;
			ContractNumber = contractNum;
			Time = time;
			Houers = houers;
			CarNumber = car_number;
		}

		// Getters/Setters //////////////
		public string Worker
		{
			get { return workerID; }
			set { workerID = value; }
		}

		public int MissionID
		{
			get { return missionId; }
			set { missionId = value; }
		}

		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		public int ContractNumber
		{
			get { return contractNumber; }
			set { contractNumber = value; }
		}

		public DateTime Time
		{
			get { return time; }
			set { time = value; }
		}

		public int Houers
		{
			get { return houers; }
			set { houers = value; }
		}

		public int CarNumber
		{
			get { return carNumber; }
			set { carNumber = value; }
		}

		public int CarChenge
		{
			get { return carChenge; }
			set { carChenge = value; }
		}

		//public Car MissionCar
		//{
		//	get; set;
		//}
		/////////////////////////////////
	}
}
