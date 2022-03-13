using VideoStore.FrequentRenterPoints;
using VideoStore.RentalPricing;
using VideoStore.Model;

namespace VideoStore.RentalService
{
    public class RentalService : IRentalService
    {
		private IFrequentRenterPointService _frequentRenterPointService;
        
		private IRentalPriceService _rentalPriceService;

        public RentalService(IFrequentRenterPointService frequentRenterPointService, IRentalPriceService rentalPriceService)
        {
			this._frequentRenterPointService = frequentRenterPointService;
            this._rentalPriceService = rentalPriceService;
        }

        public Rental AddRental(Customer customer, Movie movie, int daysRented)
        {
			var rental = new Rental(movie, daysRented);
			rental.FrequentRenterPoints = _frequentRenterPointService.GetFrequentRenterPoints(movie, daysRented);
			rental.RentalAmount = _rentalPriceService.GetRentalPrice(movie, daysRented);

			customer.Rentals.Add(rental);

            return rental;
        }
    }
}
