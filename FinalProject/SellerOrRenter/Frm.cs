using FinalProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.SellerOrRenter
{
	public partial class Frm : Form
	{
		// Fields
		private Car cars;
		private bool[] empty;
		private readonly Main _main;
        private Employee emp;
		private int start, limit;

		// Constructor
		public Frm(object tempcar, bool[] Empty, int Start, int Limit, Main form,object role)
		{
			cars = (Car)tempcar;
			empty = Empty;
            emp = (Employee)role;
			start = Start;
			limit = Limit;
			_main = form;
			InitializeComponent();
		}

		// Buttons ////////////////
		private void Exit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void preaparation_Click(object sender, EventArgs e)
		{
			this.Hide();
			PreaparationOfTheCar pr = new PreaparationOfTheCar(empty, start, limit, cars, _main);
			pr.Closed += (s, args) => this.Close();
			pr.ShowDialog();
		}

		private void contract_Click(object sender, EventArgs e)
		{
			this.Hide();
			ContractDocument sc = new ContractDocument(_main, cars,emp);
			sc.Closed += (s, args) => this.Close();
			sc.ShowDialog();
		}
		///////////////////////////
	}
}
