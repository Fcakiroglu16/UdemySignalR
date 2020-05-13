using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CovidChart.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CovidChart.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CovidsController : ControllerBase
    {
        private readonly CovidService _service;

        public CovidsController(CovidService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> SaveCovid(Covid covid)
        {
            await _service.SaveCovid(covid);

            //   IQueryable<Covid> covidList = _service.GetList();

            return Ok(_service.GetCovidChartList());
        }

        [HttpGet]
        public IActionResult InitializeCovid()
        {
            Random rnd = new Random();

            Enumerable.Range(1, 10).ToList().ForEach(x =>
            {
                foreach (ECity item in Enum.GetValues(typeof(ECity)))
                {
                    var newcovid = new Covid { City = item, Count = rnd.Next(100, 1000), CovidDate = DateTime.Now.AddDays(x) };
                    _service.SaveCovid(newcovid).Wait();
                    System.Threading.Thread.Sleep(1000);
                }
            });

            return Ok("Covid19 dataları veritabanına kaydedildi");
        }
    }
}