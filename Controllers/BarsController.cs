using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarsAPI.Migrations;
using BarsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BarsAPI.Controllers
{
    [ApiController]
    public class BarsController : ControllerBase
    {

        private readonly ApplicationDbContext appDb;

        public BarsController(ApplicationDbContext _appDb)
        {
            this.appDb = _appDb;
        }

        [Route("api/[controller]")]
        [HttpGet]
        public IEnumerable<BarDetails> Get()
        {
            using(appDb)
            {
                return appDb.BarDetails.ToList();
            }
        }

        [Route("api/[controller]/GetDepositUnder/{price}")]
        [HttpGet]
        public IEnumerable<BarDetails> GetDepositUnder(decimal price)
        {
            using (appDb)
            {
                return appDb.BarDetails.Where(x => x.Deposit <= price).ToList();
            }
        }

        [Route("api/[controller]/GetLocality/{locality}")]
        [HttpGet]
        public IEnumerable<BarDetails> GetLocality(string locality)
        {
            using (appDb)
            {
                return appDb.BarDetails.Where(x => x.Address.Contains(locality)).ToList();
            }
        }

        [Route("api/[controller]/GetLocalityAndPrice/{locality}/{price}")]
        [HttpGet]
        public IEnumerable<BarDetails> GetLocalityAndPrice(string locality, decimal price)
        {
            using (appDb)
            {
                return appDb.BarDetails.Where(x => x.Address.Contains(locality) && x.Deposit <= price).ToList();
            }
        }
    }
}
