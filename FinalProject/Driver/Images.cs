using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Driver
{
	public partial class Images : Form
	{
		// Field
		private Image picture;

		// Constructor
		public Images(object img)
		{
			picture = (Image)img;
			InitializeComponent();
		}

		// Pressing close Button
		private void close_Click(object sender, EventArgs e)
		{
			Close();
		}

		// Loading Form entities
		private void Image_Load(object sender, EventArgs e)
		{
			pictureBox1.Image = picture;
		}
	}
}
