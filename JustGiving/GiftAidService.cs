using System;

namespace JustGiving
{
	public class GiftAidService : IGiftAidService
    {
		public double CalculateGiftAid(double donation)
		{
			return donation * 0.2;
		}
    }

	public interface IGiftAidService
	{
		double CalculateGiftAid(double donation);
	}
}
