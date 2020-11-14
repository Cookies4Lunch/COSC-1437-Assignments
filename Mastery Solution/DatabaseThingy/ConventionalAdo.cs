using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DatabaseThingy
{
    public class ConventionalAdo
    {
        public DataTable RunQueryTable(string sqlConnectionString, string dataTableQueryString)
        {
            DataTable dataTable;

            using (var sqlConnection = new SqlConnection(sqlConnectionString))
            {
                sqlConnection.Open();
                using (var sqlDataAdapter = new SqlDataAdapter (dataTableQueryString, sqlConnection))
                {
                    dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
    }
}
