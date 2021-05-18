using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eportfolioWorkingSample
{
    public class ConnectionHelper
    {
        private static OleDbConnection _dbConnection;

        public static OleDbConnection GetConnectionByFilePath(string filepath)
        {
            string template = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};";
            string dbConnectionString = String.Empty;

            if (_dbConnection != null)
                return _dbConnection;

            if (!File.Exists(filepath))
                return null;
            else
                dbConnectionString = String.Format(template, filepath);

            _dbConnection = new OleDbConnection(dbConnectionString);
            return _dbConnection;
        }
    }
}
