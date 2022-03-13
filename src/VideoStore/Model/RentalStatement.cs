using System.Collections.Generic;

namespace VideoStore.Model
{
	public class RentalStatement
	{
		public decimal FrequentRenterPoints { get; set; }

		public decimal TotalRentalAmount { get; set; }

		public string CustomerName { get; set; }

		public IList<Rental> Rentals { get; set; }
	}
}
