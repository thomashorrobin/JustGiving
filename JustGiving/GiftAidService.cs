using System;

namespace JustGiving
{
	public class GiftAidService : IGiftAidService
    {
		public double CalculateGiftAid(double donation)
		{
			return 0;
		}
    }

	public interface IGiftAidService
	{
		double CalculateGiftAid(double donation);
	}
}
