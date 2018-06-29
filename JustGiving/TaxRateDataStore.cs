using System;
namespace JustGiving
{
    //public class TaxRateDataStore
    //{
    //    public TaxRateDataStore()
    //    {
    //    }
    //}

	public interface ITaxRateDataStore
	{
		double GetGiftAidRate();
        void SetGiftAidRate(double giftAidRate);
	}
}
