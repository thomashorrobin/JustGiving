using System;

namespace JustGiving
{
	public class GiftAidService : IGiftAidService
    {
		public double CalculateGiftAid(double donation)
		{
            if (donation < 0)
			{
				throw new ArgumentOutOfRangeException("donation", "the donation must be a positive number");
			}

			return donation * 0.2;
		}
    }

	public interface IGiftAidService
	{
		double CalculateGiftAid(double donation);
	}
}
