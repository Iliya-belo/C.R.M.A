using FinalProject.Classes;
using FinalProject.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.CEO
{
	public partial class ReturnCar : Form
	{
		// Fields
		private DbMySQL dataB = DbMySQL.Instance;
		private Car carToReturn;
		private bool[] emptyParking;
		private string idWorker;

		// Constructor
		public ReturnCar(object cars, string id)
		{
			InitializeComponent();
			carToReturn = (Car)cars;
			idWorker = id;
		}

		// Loading Form entities
		private void ReturnCar_Load(object sender, EventArgs e)
		{
			emptyParking = dataB.emptyParking();
			for (int i = 1; i < emptyParking.Length; i++)
				if (emptyParking[i])
					EmptyParkngPlaces.Items.Add(i);
		}

		// Pressing Close button
		private void Exit_Click(object sender, EventArgs e)
		{
			Close();
		}

		// Pressing Save Button
		private void Save_Click(object sender, EventArgs e)
		{
			if (EmptyParkngPlaces.SelectedItem.ToString() != "")
			{
				dataB.InsertParking(carToReturn, int.Parse(EmptyParkngPlaces.SelectedItem.ToString()));
				MessageBox.Show("רכב הוחזר לחנייה");
				Close();
			}
		}
	}
}
