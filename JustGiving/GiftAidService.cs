using System;

namespace JustGiving
{
	public class GiftAidService : IGiftAidService
    {
		private readonly ITaxRateDataStore _taxRateDataStore;

		public GiftAidService(ITaxRateDataStore taxRateDataStore)
		{
			_taxRateDataStore = taxRateDataStore;
		}

		public double CalculateGiftAid(double donation)
		{
            if (donation < 0)
			{
				throw new ArgumentOutOfRangeException("donation", "the donation must be a positive number");
			}

			var giftAidTaxRate = _taxRateDataStore.GetGiftAidRate();

			var giftAid = donation * ( giftAidTaxRate / (100 - giftAidTaxRate ));

			return Math.Round(giftAid, 2);
		}

		public void SetGiftAidTaxRate(double rate)
		{
			_taxRateDataStore.SetGiftAidRate(rate);
		}
    }

	public interface IGiftAidService
	{
		double CalculateGiftAid(double donation);
		void SetGiftAidTaxRate(double rate);
	}
}
