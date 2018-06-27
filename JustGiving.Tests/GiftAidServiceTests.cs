using System;
using Xunit;
using JustGiving;

namespace JustGiving.Tests
{
	public class GiftAidServiceTests
    {
		private readonly IGiftAidService _giftAidService;

        public GiftAidServiceTests()
		{
			_giftAidService = new GiftAidService();
		}

        [Fact]
		public void CalculateGiftAid_method_should_return_correct_amount()
        {
			Assert.Equal(20, _giftAidService.CalculateGiftAid(100));
        }
    }
}
