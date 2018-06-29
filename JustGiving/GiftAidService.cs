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

			return donation * ( giftAidTaxRate / (100 - giftAidTaxRate ));
		}
    }

	public interface IGiftAidService
	{
		double CalculateGiftAid(double donation);
	}
}
