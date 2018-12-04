using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DatabaseAndTimer.Models
{
    public class PersonModel
    {
        public string Name { get; set; }

        public static string ConString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static void SetName(string name)
        {
            using (IDbConnection connection = new SqlConnection(ConString("Persons")))
            {
                connection.Execute("insert into Person (Name) values (@Name)", new { @Name = name });
            }
        }

        public static string GetName()
        {
            List<PersonModel> list = new List<PersonModel>();
            using (IDbConnection connection = new SqlConnection(ConString("Persons")))
            {
                list = connection.Query<PersonModel>("select * from Person").ToList();
            }
            return list[0].Name;
        }
    }
}