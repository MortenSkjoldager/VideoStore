namespace VideoStore.Model
{
	public class Rental
	{
		public int DaysRented {	get; set; }

		public Movie Movie { get; set; }

		public decimal RentalAmount { get; set; }

		public decimal FrequentRenterPoints { get; set; }

		public Rental(Movie movie, int daysRented)
		{
			this.Movie = movie;
			this.DaysRented = daysRented;
		}
	}
}
