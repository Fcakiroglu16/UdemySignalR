using CovidChart.API.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidChart.API.Hubs
{
    public class CovidHub : Hub
    {
        private readonly CovidService _service;

        public CovidHub(CovidService service)
        {
            _service = service;
        }

        public async Task GetCovidList()
        {
            await Clients.All.SendAsync("ReceiveCovidList", _service.GetCovidChartList());
        }
    }
}