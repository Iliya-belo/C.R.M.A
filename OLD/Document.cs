using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Classes
{
	class Document
	{
		private int documentId;
		private string info;
		private DateTime dateToAdd;
		private DateTime dateToUpdate;

		public Document(int documentId, string info, DateTime dateToAdd, DateTime dateToUpdate)
		{
			DocumentId = documentId;
			Info = info;
			DateToAdd = dateToAdd;
			DateToUpdate = dateToUpdate;
		}

		public int DocumentId
		{
			get;
		}

		public string Info
		{
			get; set;
		}
		public DateTime DateToAdd
		{
			get; set;
		}
		public DateTime DateToUpdate
		{
			get; set;
		}
	}
}
