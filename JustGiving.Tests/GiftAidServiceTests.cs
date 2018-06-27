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

        [Fact]
        public void CalculateGiftAid_method_should_return_zero_when_donation_zero()
        {
            Assert.Equal(0, _giftAidService.CalculateGiftAid(0));
		}

        [Fact]
        public void CalculateGiftAid_method_should_throw_when_donation_less_than_zero()
        {
			Assert.Throws(typeof(ArgumentOutOfRangeException), () => _giftAidService.CalculateGiftAid(-10));
        }
    }
}
