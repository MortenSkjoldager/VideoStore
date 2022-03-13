using VideoStore.Model;

namespace VideoStore.RentalPricing
{
    public interface IRentalPriceService
    {
        decimal GetRentalPrice(Movie movie, int rentalDays);
    }
}
