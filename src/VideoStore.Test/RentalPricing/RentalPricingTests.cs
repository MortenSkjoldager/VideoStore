using NUnit.Framework;
using VideoStore.Model;
using VideoStore.RentalPricing;

namespace VideoStore.Test.RentalPricing
{
    [TestFixture]
    public class RentalPricingTests
    {
        [Test]
        public void Childrens_Movie_Rented_For_3_Days_Yields_A_Price_Of_1point5()
        {
            var rentalPriceService = new RentalPriceService();

            var movie = new Movie("Disney", MovieType.Childrens);

            var rentalAmount = rentalPriceService.GetRentalPrice(movie, 3);

            var expectedAmount = 1.5m;
            
            Assert.AreEqual(expectedAmount, rentalAmount);
        }
        
        [Test]
        public void Childrens_Movie_Rented_For_4_Days_Yields_A_Price_Of_3()
        {
            var rentalPriceService = new RentalPriceService();

            var movie = new Movie("Disney", MovieType.Childrens);

            var rentalAmount = rentalPriceService.GetRentalPrice(movie, 4);

            var expectedAmount = 3m;
            
            Assert.AreEqual(expectedAmount, rentalAmount);
        }
    }
}