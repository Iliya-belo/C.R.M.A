using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Classes
{
	class Request
	{
		// Fields
		private int numberRequest;
		private string id;
		private DateTime requestedDate;
		private string explanationOfRequest;
        private string houers;

		// Constructor
		public Request(int numberRequest, string id, DateTime requestedDate, string explanationOfRequest,string houersRequest)
		{
			NumberRequest = numberRequest;
			ID = id;
			RequestedDate = requestedDate;
			ExplanationOfRequest = explanationOfRequest;
            Houers = houersRequest;

        }

		// Getters/Setters //////////////
		public int NumberRequest
		{
			get { return numberRequest; }
			set { numberRequest = value; }
		}
        public string Houers
        {
            get { return houers; }
            set { houers = value; }
        }
		public string ID
		{
			get { return id; }
			set { id = value; }
		}

		public DateTime RequestedDate
		{
			get { return requestedDate; }
			set { requestedDate = value; }
		}

		public string ExplanationOfRequest
		{
			get { return explanationOfRequest; }
			set { explanationOfRequest = value; }
		}
		/////////////////////////////////
	}
}
