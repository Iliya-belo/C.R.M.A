using FinalProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FinalProject.Driver
{
	public partial class PakingDiagramAndInsert : Form
	{
		// Fields
		private bool[] emptyParking;
		private Car carToInsert;
		private Car[] OptionsCar;
		private string[] path;
		private Image[] img;
		private Database.DbMySQL dataB = Database.DbMySQL.Instance;

		// Constructor
		public PakingDiagramAndInsert()
		{
			InitializeComponent();
		}

		// Pressing the Close Button
		private void close_Click(object sender, EventArgs e)
		{
			Close();
		}

		// Loading Form entities
		private void PakingDiagramAndInsert_Load(object sender, EventArgs e)
		{
			dataGridCars.Visible = false;
			path = dataB.ParkingDiagram();
			img = new Image[path.Length];
			for (int i = 0; i < path.Length; i++)
				if (File.Exists(path[i]))
					img[i] = Image.FromFile(path[i]);
			if (img != null)
				parking.Image = img[0];
			fillParking();
		}

		// Utility function for loading the Form
		private void fillParking()
		{
			emptyParking = dataB.emptyParking();
			for (int i = 1; i < emptyParking.Length; i++)
				if (emptyParking[i])
					empParking.Items.Add(i);
		}

		// Chooses image for Floor
		private void floor_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (floor.SelectedItem.ToString() != "0")
				parking.Image = img[int.Parse(floor.SelectedItem.ToString())];
		}

		// Double-Clicking the image opens a bigger version of the image
		private void parking_DoubleClick(object sender, EventArgs e)
		{
			if (floor.SelectedItem.ToString() != "0")
			{
				Images im = new Images(img[int.Parse(floor.SelectedItem.ToString())]);
				im.ShowDialog();
			}
		}

		// Search for license number
		private void textLicensNum_TextChanged(object sender, EventArgs e)
		{
			dataGridCars.Visible = true;
			dataGridCars.ColumnCount = 1;
			OptionsCar = null;
			if (textLicensNum.Text != "")
				OptionsCar = dataB.CheckCar(int.Parse(textLicensNum.Text));
			if (OptionsCar == null)
			{
				dataGridCars.RowCount = 1;
				dataGridCars.Rows.Clear();
				dataGridCars.Visible = false;
				return;
			}
			dataGridCars.RowCount = OptionsCar.Length;
			for (int i = 0; i < OptionsCar.Length; i++)
			{
				dataGridCars[0, i].Value = OptionsCar[i].LicenseNumber;
			}
		}

		// Pressing the insert Button
		private void insertCar_Click(object sender, EventArgs e)
		{
			if (carToInsert == null || empParking.SelectedItem.Equals("0"))
			{
				MessageBox.Show("נדרש לבוחר רכב ומספר חניה לפני הביצוע");
				return;
			}
			dataB.insertExitGarage(carToInsert.LicenseNumber, 0);
			dataB.InsertParking(carToInsert, int.Parse(empParking.SelectedItem.ToString()));
			MessageBox.Show("הנתונים נשמרו בהצלחה");
		}

		// Choosing the Car's license number
		private void dataGridCars_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			carToInsert = OptionsCar[e.RowIndex];
			textLicensNum.Text = carToInsert.LicenseNumber.ToString();
			dataGridCars.Visible = false;
		}
	}
}
