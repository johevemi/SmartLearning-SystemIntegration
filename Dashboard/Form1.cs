using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string requestUriString = textBoxRequestUriString.Text;
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            var solarPanels = new SolarPanels(requestUriString, userName, password);
            var energyForTheHour = solarPanels.Inverter();
            textBoxEnergyForTheHour.Text = energyForTheHour.ToString();
        }
    }
}
