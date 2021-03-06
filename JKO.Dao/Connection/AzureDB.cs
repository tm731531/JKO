using JKO.Dao.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace JKO.Dao.Connection
{
    class AzureDB : IDatabaseConnection
    {
        private readonly string _connectionString;

        public AzureDB()
        {
            _connectionString = ConnectString.Azure;
        }
        public IDbConnection Create()
        {
            var sqlConnection = new SqlConnection(_connectionString);
            return sqlConnection;
        }
    }
}
