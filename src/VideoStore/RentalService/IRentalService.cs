using VideoStore.Model;

namespace VideoStore.RentalService
{
    public interface IRentalService
    {
        Rental AddRental(Customer customer, Movie movie, int daysRented);
    }
}
