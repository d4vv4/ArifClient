using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;

namespace ArifClient.Shared.DataAccess
{
    public class AzureTableStorage<T> : IAzureTableStorage<T> where T : TableEntity, new()
    {
        private readonly AzureTableSettings settings;
        public AzureTableStorage(AzureTableSettings settings)
        {
            this.settings = settings;
        }
        public async Task<List<T>> GetItems()
        {
            CloudTable table = await GetTableAsync();
            TableQuery<T> query = new TableQuery<T>();
            List<T> results = new List<T>();
            TableContinuationToken continuationToken = null;
            do
            {
                TableQuerySegment<T> queryResults = await table.ExecuteQuerySegmentedAsync(query, continuationToken);
                continuationToken = queryResults.ContinuationToken;
                results.AddRange(queryResults.Results);
            } while (continuationToken != null);

            return results;
        }
        private async Task<CloudTable> GetTableAsync()
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(settings.ConnectionString);
            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();
            CloudTable table = tableClient.GetTableReference(this.settings.TableName);
            await table.CreateIfNotExistsAsync();
            return table;
        }
    }
}
