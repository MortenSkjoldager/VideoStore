using System.Text;

namespace VideoStore.RentalStatement
{
    public class RentalStatementReportService : IRentalStatementReportService
    {
        public string GetRentalStatementReport(Model.RentalStatement rentalStatement)
        {
            StringBuilder stringBuilder = new StringBuilder();

			stringBuilder.AppendLine($"Rental Record for { rentalStatement.CustomerName }");

            foreach (var rental in rentalStatement.Rentals)
            {
				stringBuilder.AppendLine($"\t{rental.Movie.Title}\t{rental.RentalAmount}");
            }

			stringBuilder.AppendLine($"You owed { rentalStatement.TotalRentalAmount }");
			stringBuilder.AppendLine($"You earned { rentalStatement.FrequentRenterPoints } frequent renter points");
			
			return stringBuilder.ToString();
        }
    }
}
