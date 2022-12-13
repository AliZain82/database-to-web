using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Configuration;
using   database.Models;


namespace database.Models
{
    public class data
    {
        public List<MyTable> GetAll()
        {
            List<MyTable> Users = new List<MyTable>();
            string Connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection Conn = new SqlConnection(Connstring))
            {
                string cmdline = "SELECT * FROM MyTable";
                using (SqlCommand Cmd = new SqlCommand(cmdline))
                {
                    Conn.Open();
                    SqlDataReader reader = Cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        MyTable Rec = new MyTable();
                        Rec.UserId = Convert.ToInt16(reader[0]);
                        Rec.Name = reader[1].ToString();
                        Rec.City = reader[2].ToString();
                        Users.Add(Rec);
                    }
                }

            }



            return Users;
        }
    }
}
