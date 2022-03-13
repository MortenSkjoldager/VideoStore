using VideoStore.Model;

namespace VideoStore.RentalPricing
{
    public class RentalPriceService : IRentalPriceService
    {
        public decimal GetRentalPrice(Movie movie, int rentalDays)
        {
			//TODO: Maybe use a strategy pattern / resolve specific component supported by the IOC that encapuslates this behavior instead of switch
			//could just return directly inside switch
			var rentalAmount = 0m;
			switch (movie.MovieType)
			{
				case MovieType.Regular:
					rentalAmount += 2;
					if (rentalDays > 2)
						rentalAmount += (rentalDays - 2) * 1.5m;
					break;
				case MovieType.NewRelease:
					rentalAmount += rentalDays * 3;
					break;
				case MovieType.Childrens:
					rentalAmount += 1.5m;
					if (rentalDays > 3)
						rentalAmount += (rentalDays - 3) * 1.5m;
					break;
			}

			return rentalAmount;
		}
    }
}
