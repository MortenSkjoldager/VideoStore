using VideoStore.Model;

namespace VideoStore.FrequentRenterPoints
{
    public class FrequentRenterPointService : IFrequentRenterPointService
    {
        public int GetFrequentRenterPoints(Movie movie, int rentalDays)
        {
            if (movie.MovieType == MovieType.NewRelease && rentalDays > 1)
            {
                return 2;
            }

            return 1;
        }
    }
}
