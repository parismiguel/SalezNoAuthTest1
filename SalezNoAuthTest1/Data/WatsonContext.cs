using MySql.Data.MySqlClient;
using SalezNoAuthTest1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalezNoAuthTest1.Data
{
    public class WatsonContext
    {
        public string ConnectionString { get; set; }

        public WatsonContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Workspace> GetAllWorkspaces()
        {
            List<Workspace> list = new List<Workspace>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Workspace", conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Workspace()
                        {
                            IdWorkspace = reader.GetInt32("idWorkspace"),
                            Workspace_id = reader.GetString("workspace_id"),
                            Name = reader.GetString("name"),
                            Created = reader.GetString("created"),
                            Updated = reader.GetString("updated"),
                            Language = reader.GetString("language"),
                            Description = reader.GetString("description"),
                            Metadata = reader.GetString("metadata")
                        });
                    }
                }

            }

            return list;
        }

     
    }
}
