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
    public class GiftAidController : Controller
	{
        private readonly IGiftAidService _giftAidService;

		public GiftAidController(IGiftAidService giftAidService)
        {
			_giftAidService = giftAidService;
        }

        // GET: api/values
        [HttpGet]
		public GiftAidDonation Get([FromQuery]double donation)
        {
			var giftAid = _giftAidService.CalculateGiftAid(donation);
			return new GiftAidDonation()
			{
				Donation = donation,
				GiftAidClaimable = giftAid
			};
        }
    }
}
