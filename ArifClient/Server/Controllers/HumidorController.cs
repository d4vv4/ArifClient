using ArifClient.Shared.DataAccess;
using ArifClient.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArifClient.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HumidorController : ControllerBase
    {
        private readonly IHumidorReadingService service;
        public HumidorController(IHumidorReadingService service)
        {
            this.service = service;
        }
        [HttpGet]
        public async Task<List<HumidorReading>> Get()
        {
            var model = await service.GetReadings();
            return model.ToList();
        }
    }
}
