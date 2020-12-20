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

namespace FinalProject.Secretary
{
	public partial class Payment : Form
	{
		// Fields
		private readonly ListOfCarAfterFixToPaed listCar;
		private int fixNumber;
		private double price;
		private DbMySQL dataB = DbMySQL.Instance;

		// Constructor
		public Payment(int fixNum, double _price, ListOfCarAfterFixToPaed list)
		{
			InitializeComponent();
			price = _price;
			fixNumber = fixNum;
			listCar = list;
		}

		// Pressing the pay Button
		private void BTNpay_Click(object sender, EventArgs e)
		{
			double pay = 0;
			if (ToPay.Text != "")
				if (double.TryParse(ToPay.Text, out pay) && pay > 0)
				{
					price -= pay;
					if (price < 0)
					{
						MessageBox.Show("עודף:" + (price * (-1)));
						price = 0;
					}
					dataB.paidUp(fixNumber, price);
				}
			if (pay > 0)
			{
				listCar.fillData();
				this.Close();
			}
			else
				MessageBox.Show("תשלום לא יכול להיות שלילי");
		}

		// Pressing the close Button
		private void BTNcancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
