using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    public class IndoorTemp
    {
        public string? Dato { get; set; }
        public string? Tidspunkt { get; set; }
        public string? Grader { get; set; }
    }
    public class IndoorTempSqlConnection
    {
        private readonly string _sqlServer;
        private readonly string _sqlUserName;
        private readonly string _sqlPassword;
        public IndoorTempSqlConnection(string sqlServer, string sqlUserName, string sqlPassword)
        {
            _sqlServer = sqlServer;
            _sqlUserName = sqlUserName;
            _sqlPassword = sqlPassword;
        }

        public List<IndoorTemp> GetSqlData()
        {
            string connectionString = $"Server=tcp:{_sqlServer},1433;Initial Catalog=indeklima;Persist Security Info=False;User ID={_sqlUserName};Password={_sqlPassword};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            var sql = "select top(10) dato, tidspunkt, grader from Temperatur order by dato desc";
            var command = new SqlCommand(sql, connection);
            var dataReader = command.ExecuteReader();
            List<IndoorTemp> list = new List<IndoorTemp>();
            while (dataReader.Read())
            {
                var dato = dataReader.GetValue(0);
                var tidspunkt = dataReader.GetValue(1);
                var grader = dataReader.GetValue(2);
                list.Add(new IndoorTemp
                {
                    Dato = dato.ToString(),
                    Tidspunkt = tidspunkt.ToString(),
                    Grader = grader.ToString(),
                });
            }
            return list;
        }
    }
}
