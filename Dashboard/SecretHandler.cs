using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dashboard
{
    public class Secrets
    {
        public string FtpRequestUriString { get; set; }
        public string FtpUserName { get; set; }
        public string FtpPassword { get; set; }
        public string RestPassword { get; set; }
        public string SqlServer { get; set; }
        public string SqlUserName { get; set; }
        public string SqlPassword { get; set; }
    }
    public class SecretHandler
    {
        public void SaveSecrets(Secrets secrets)
        {
            var secretsAsJson = JsonSerializer.Serialize(secrets);
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            File.WriteAllText($"{path}/secretsForDashboardSystemIntegration.txt", secretsAsJson);
        }
        public Secrets GetSecrets()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/secretsForDashboardSystemIntegration.txt";
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                return JsonSerializer.Deserialize<Secrets>(json);
            }
            return new Secrets();
        }
    }
}
