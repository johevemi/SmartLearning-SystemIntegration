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

        private async void buttonGet_Click(object sender, EventArgs e)
        {
            var forecastServiceCall = new ForecastServiceCall();
            List<WeatherForecast> result = await forecastServiceCall.GetAsync(textBoxPath.Text, textBoxRestPassword.Text);
            dataGridView1.Columns.Add("Time", "Time");
            dataGridView1.Columns.Add("Temp", "Temp");
            dataGridView1.Columns.Add("CloudCover", "CloudCover");
            dataGridView1.Columns.Add("Condition", "Condition");
            dataGridView1.Columns.Add("Sunrise", "Sunrise");
            dataGridView1.Columns.Add("Sunset", "Sunset");
            dataGridView1.Columns.Add("Visibility", "Visibility");
            if (result != null)
            {
                foreach (var item in result) 
                {
                    dataGridView1.Rows.Add(item.Date.Hour, item.TemperatureC, item.CloudCover, item.Condition, item.Sunrise, item.Sunset, item.Visibility);
                }
            }
        }
    }
}
