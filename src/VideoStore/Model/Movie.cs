namespace VideoStore.Model
{
	public class Movie
	{
		public MovieType MovieType { get; }

		public string Title { get; }

		public Movie(string title, MovieType priceCode)
		{
			this.Title = title;
			this.MovieType = priceCode;
		}
	}
}
