using System.Linq;
using VideoStore.Model;

namespace VideoStore.RentalStatement
{
    public class RentalStatementService : IRentalStatmentService
    {
        public VideoStore.Model.RentalStatement GetRentalStatement(Customer customer)
        {
            var frequentRenterPoints = customer.Rentals.Sum(x => x.FrequentRenterPoints);
            var totalRentalAmount = customer.Rentals.Sum(x => x.RentalAmount);

            return new Model.RentalStatement()
            {
                CustomerName = customer.Name,
                FrequentRenterPoints = frequentRenterPoints,
                TotalRentalAmount = totalRentalAmount,
                Rentals = customer.Rentals
            };
        }
    }
}
