using System.Collections.Generic;

namespace VideoStore.Model
{
	public class Customer
	{
		public string Name { get; set; }

		public IList<Rental> Rentals { get; set; }

		public Customer(string name)
		{
			this.Name = name;
			this.Rentals = new List<Rental>();
		}
	}
}
