using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_ApplicationV2
{
    public partial class mainF : Form
    {
        public mainF()
        { 
            InitializeComponent();
        }
        private void mainF_Load(object sender, EventArgs e)
        {
        }

        private void weatherBtn_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Opening weather...");
            WeatherForm f2 = new WeatherForm();
            f2.ShowDialog();
        }

    }
}
