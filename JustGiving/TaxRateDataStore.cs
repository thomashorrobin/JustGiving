using System;
namespace JustGiving
{
	public class TaxRateDataStoreStub : ITaxRateDataStore
	{
		private double giftAidTaxRate = 0;

		public double GetGiftAidRate()
		{
			return giftAidTaxRate;
		}

		public void SetGiftAidRate(double giftAidRate)
		{
			giftAidTaxRate = giftAidRate;
		}
	}

	public interface ITaxRateDataStore
	{
		double GetGiftAidRate();
        void SetGiftAidRate(double giftAidRate);
	}
}
