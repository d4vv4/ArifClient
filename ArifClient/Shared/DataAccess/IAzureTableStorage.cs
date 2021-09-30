using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArifClient.Shared.DataAccess
{
    public interface IAzureTableStorage <T> where T: TableEntity, new()
    {
        Task<List<T>> GetItems();
    }
}
