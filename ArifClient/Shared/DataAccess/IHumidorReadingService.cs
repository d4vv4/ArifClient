using ArifClient.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArifClient.Shared.DataAccess
{
    public interface IHumidorReadingService
    {
        Task<List<HumidorReading>> GetReadings();
    }
}
