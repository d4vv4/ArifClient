using ArifClient.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArifClient.Shared.DataAccess
{
    public class HumidorReadingService : IHumidorReadingService
    {
        private readonly IAzureTableStorage<HumidorReading> repo;
        public HumidorReadingService(IAzureTableStorage<HumidorReading> repo)
        {
            this.repo = repo;
        }
        public async Task<List<HumidorReading>> GetReadings()
        {
            return await repo.GetItems();
        }
    }
}
