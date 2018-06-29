using System;
using Xunit;
using JustGiving;
using Moq;

namespace JustGiving.Tests
{
	public class StoryOneTests
    {
		private readonly IGiftAidService _giftAidService;

		public StoryOneTests()
		{
			var mock = new Mock<ITaxRateDataStore>();

			mock.Setup(framework => framework.GetGiftAidRate()).Returns(20);

			_giftAidService = new GiftAidService(mock.Object);
		}

        [Fact]
		public void CalculateGiftAid_method_should_return_correct_amount()
        {
			Assert.Equal(25, _giftAidService.CalculateGiftAid(100));
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

    public class StoryTwoTests
	{
        private readonly IGiftAidService _giftAidService;

        public StoryTwoTests()
		{
			_giftAidService = new GiftAidService(new TaxRateDataStoreStub());
		}

        [Fact]
		public void SetGiftAidTaxRate_should_change_rate()
		{
			Assert.Equal(0, _giftAidService.CalculateGiftAid(60));

			_giftAidService.SetGiftAidTaxRate(25);

			Assert.Equal(20, _giftAidService.CalculateGiftAid(60));
		}
	}

    public class StoryThreeTests
	{
        private readonly IGiftAidService _giftAidService;

		public StoryThreeTests()
        {
            var mock = new Mock<ITaxRateDataStore>();

            mock.Setup(framework => framework.GetGiftAidRate()).Returns(19);

            _giftAidService = new GiftAidService(mock.Object);
        }
      
        [Fact]
        public void CalculateGiftAid_method_should_return_amount_rounded()
        {
            Assert.Equal(23.46, _giftAidService.CalculateGiftAid(100));
        }
	}
}
