using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Classes
{
	public class MissionList
	{
		// Fields
		private int eventNumber;
		private string currentActivity;
		private DateTime daysOfState;
		private DateTime readyDays;
		private int componentStatusToOrder;
		private int componentStatusReady;
		private int garageID;

		// Constructor
		public MissionList(int eventNumber, string currentActivity, DateTime daysOfState, DateTime readyDays, int componentStatusToOrder, int componentStatusReady, int garageID)
		{
			this.eventNumber = eventNumber;
			CurrentActivity = currentActivity;
			DaysOfState = daysOfState;
			ReadyDays = readyDays;
			ComponentStatusToOrder = componentStatusToOrder;
			ComponentStatusReady = componentStatusReady;
			GarageID = garageID;
		}

		// Getters/Setters //////////////
		public int EventNumber
		{
			get { return eventNumber; }
		}

		public string CurrentActivity
		{
			get { return currentActivity; }
			set { currentActivity = value; }
		}

		public DateTime DaysOfState
		{
			get { return daysOfState; }
			set { daysOfState = value; }
		}

		public DateTime ReadyDays
		{
			get { return readyDays; }
			set { readyDays = value; }
		}

		public int ComponentStatusToOrder
		{
			get { return componentStatusToOrder; }
			set { componentStatusToOrder = value; }
		}

		public int ComponentStatusReady
		{
			get { return componentStatusReady; }
			set { componentStatusReady = value; }
		}

		public int GarageID
		{
			get { return garageID; }
			set { garageID = value; }
		}
		/////////////////////////////////
	}
}
