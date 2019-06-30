using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Dapper;

namespace Project.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class IssueModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateCreated { get; set; }

        private static readonly string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Test123;Integrated Security=True";

        public static IEnumerable<IssueModel> GetStuff()
        {
            var connection = new SqlConnection(connectionString);

            string sql = @"select top(10) * from tblState;";
            var issues = connection.Query<IssueModel>(sql);
            return issues;

        }
    }
}
