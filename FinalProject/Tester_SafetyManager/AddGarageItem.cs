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

namespace FinalProject.Tester_SafetyManager
{
    public partial class AddGarageItem : Form
    {
        private Garage garage;
        private Database.DbMySQL dataB = Database.DbMySQL.Instance;
        public AddGarageItem()
        {
            InitializeComponent();
        }
        //function to close window 
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //function to check input 
        private bool CheckInfo()
        {
            int num;
            if (!int.TryParse(IDtext.Text, out num) || NameText.Text.Length < 1 || (phoneText.Text.Length != 12 && !int.TryParse(phoneText.Text, out num)) || StreetText.Text.Length < 1 || CityText.Text.Length < 1 || HouseNumText.Text.Length < 1&&num<=0)
                return false;
            garage = new Garage(int.Parse(IDtext.Text), NameText.Text, phoneText.Text, StreetText.Text, CityText.Text, HouseNumText.Text);
            return true;
        }
        //function to add garage to data base
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!CheckInfo())
            {
                MessageBox.Show("אחד מהנתונים שגוים");
                return;
            }
            dataB.insertGarage(garage);
            MessageBox.Show("מוסך נשמר בהצלחה");
            clearInfo();
        }
        //function to clear all items in window 
        private void clearInfo()
        {
            IDtext.Text = NameText.Text = phoneText.Text = StreetText.Text = CityText.Text = HouseNumText.Text = "";
        }
    }
}
