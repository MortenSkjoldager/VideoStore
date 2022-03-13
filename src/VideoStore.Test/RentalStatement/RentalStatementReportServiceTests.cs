using NUnit.Framework;
using VideoStore.Model;
using VideoStore.RentalPricing;
using VideoStore.RentalStatement;
using VideoStore.FrequentRenterPoints;
namespace VideoStore.Test.RentalStatement
{
    [TestFixture]
    public class RentalStatementReportServiceTests
    {
        [Test]
        public void SingleNewReleaseStatement()
        {
            var rentalService = new RentalService.RentalService(
                new FrequentRenterPointService(),
                new RentalPriceService());

            var customer = new Customer("Fred");
            var movie = new Movie("The Cell", MovieType.NewRelease);

            var rental = rentalService.AddRental(customer, movie, 3);

            var rentalReportService = new RentalStatementReportService();
            var rentalStatementService = new RentalStatementService();

            var rentalStatement = rentalStatementService.GetRentalStatement(customer);
            
            var statementReport = rentalReportService.GetRentalStatementReport(rentalStatement);
            
            Assert.AreEqual($"Rental Record for { customer.Name }\r\n\t{ movie.Title }\t{ rental.RentalAmount }\r\nYou owed { rentalStatement.TotalRentalAmount }\r\nYou earned {rentalStatement.FrequentRenterPoints} frequent renter points\r\n", statementReport);
        }
    }
}
