using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArifClient.Shared.DataAccess
{
    public class AzureTableSettings
    {
        public AzureTableSettings(string connectionString, string tableName)
        {
            ConnectionString = connectionString;
            TableName = tableName;
        }
        public string ConnectionString { get; set; }
        public string TableName { get; set; }
    }
}
