using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var secretHandler = new SecretHandler();
            var s = secretHandler.GetSecrets();
            textBoxRequestUriString.Text = s.FtpRequestUriString;
            textBoxUserName.Text = s.FtpUserName;
            textBoxPassword.Text = s.FtpPassword;
            textBoxRestPassword.Text = s.RestPassword;
            textBoxSqlServer.Text = s.SqlServer;
            textBoxSqlUserName.Text = s.SqlUserName;
            textBoxSqlPassword.Text = s.SqlPassword;
        }

        public class TestModel
        {
            public string Test { get; set; }
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

        private void GetSqlData_Click(object sender, EventArgs e)
        {
            var indoorTemp = new IndoorTempSqlConnection(textBoxSqlServer.Text, textBoxSqlUserName.Text, textBoxSqlPassword.Text);
            var list = indoorTemp.GetSqlData();
            dataGridViewSqlData.Columns.Add("Dato", "Dato");
            dataGridViewSqlData.Columns.Add("Tidspunkt", "Tidspunkt");
            dataGridViewSqlData.Columns.Add("Grader", "Grader");
            
            if (list != null)
            {
                foreach (var item in list)
                {
                    dataGridViewSqlData.Rows.Add(item.Dato, item.Tidspunkt, item.Grader);
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            var secretHandler = new SecretHandler();
            secretHandler.SaveSecrets(new Secrets
            {
                FtpRequestUriString = textBoxRequestUriString.Text,
                FtpUserName = textBoxUserName.Text,
                FtpPassword = textBoxPassword.Text,
                RestPassword = textBoxRestPassword.Text,
                SqlServer = textBoxSqlServer.Text,
                SqlUserName = textBoxSqlUserName.Text,
                SqlPassword = textBoxSqlPassword.Text
            });
        }
    }
}
