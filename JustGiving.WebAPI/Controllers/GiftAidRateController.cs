using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JustGiving.WebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JustGiving.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class GiftAidRateController : Controller
	{      
        private readonly IGiftAidService _giftAidService;

		public GiftAidRateController(IGiftAidService giftAidService)
        {
            _giftAidService = giftAidService;
        }

        // POST api/values
        [HttpPost]
		public void Post([FromBody]GiftAidRateUpdate value)
        {
			_giftAidService.SetGiftAidTaxRate(value.NewRate);
        }
    }
}
