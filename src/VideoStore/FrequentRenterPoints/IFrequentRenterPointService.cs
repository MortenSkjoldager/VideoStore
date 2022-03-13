using VideoStore.Model;

namespace VideoStore.FrequentRenterPoints
{
    public interface IFrequentRenterPointService
    {
        int GetFrequentRenterPoints(Movie movie, int rentalDays);
    }
}
