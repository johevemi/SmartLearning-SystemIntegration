using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public class SolarPanels
    {
        public string RequestUriString { get; }
        public string UserName { get; }
        public string Password { get; }

        public SolarPanels(string requestUriString, string userName, string password)
        {
            RequestUriString = requestUriString;
            UserName = userName;
            Password = password;
        }
        public int Inverter()
        {
            var fileToGet = GetFileNameOfCurrentHour();
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{RequestUriString}/{fileToGet}");
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential(UserName, Password);

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            var u = reader.ReadLine();
            var ad = reader.ReadLine();
            var f = reader.ReadLine();
            var k = reader.ReadLine();
            var d = reader.ReadLine();
            var header = reader.ReadLine();
            var headers = header.Split(';');
            var csvFile = reader.ReadToEnd();
            var lines = csvFile.Split('\n');
            var list = new List<Dictionary<string, string>>();
            foreach (var line in lines)
            {
                int i = 0;
                var dd = line.Split(';');
                var dictionary = new Dictionary<string, string>();
                foreach (var item in dd)
                {
                    dictionary.Add(headers[i], item);
                    ++i;
                }
                if (dictionary.Count == 40)
                {
                    list.Add(dictionary);
                }
            }
            string first = "";
            string last = "";
            list.First().TryGetValue("Current_Day_Energy", out first);
            list.Last().TryGetValue("Current_Day_Energy", out last);
            var energyForTheHour = Int32.Parse(last) - Int32.Parse(first);
            Console.WriteLine(csvFile);
            
            Console.WriteLine($"Directory List Complete, status {response.StatusDescription}");
            //Console.WriteLine($"Download Complete, status {response.StatusDescription}");

            reader.Close();
            response.Close();
            return energyForTheHour;
        }

        public string GetFileNameOfCurrentHour()
        {
            var curtentDateTime = DateTime.Now;
            var hour = curtentDateTime.ToString("HH");
            var day = curtentDateTime.ToString("dd");
            var month = curtentDateTime.ToString("MM");
            string current = $"danfoss-21{month}{day}{hour}";

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{RequestUriString}");
            request.Method = WebRequestMethods.Ftp.ListDirectory;

            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential(UserName, Password);

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string line = reader.ReadLine();
            var list = new List<string>();
            while (!string.IsNullOrEmpty(line))
            {
                list.Add(line);
                line = reader.ReadLine();
            }

            return list.Find(x => x.StartsWith(current, StringComparison.OrdinalIgnoreCase));
        }
    }
}
