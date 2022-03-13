//using NUnit.Framework;
//using VideoStore.Model;
//namespace VideoStore
//{
//	[TestFixture]
//	public class CustomerTest
//	{
//		Customer customer;

//		[SetUp]
//		public void Setup()
//		{
//			customer = new Customer("Fred");
//		}

//		[Test]
//		public void SingleNewReleaseStatement()
//		{
//			customer.AddRental(new Rental(new Movie("The Cell", MovieType.NewRelease), 3));
//			Assert.AreEqual("Rental Record for Fred\n\tThe Cell\t9\nYou owed 9\nYou earned 2 frequent renter points\n", customer.GetStatement());
//		}

//		[Test]
//		public void DualNewReleaseStatement()
//		{
//			customer.AddRental(new Rental(new Movie("The Cell", MovieType.NewRelease), 3));
//			customer.AddRental(new Rental(new Movie("The Tigger Movie", MovieType.NewRelease), 3));
//			Assert.AreEqual("Rental Record for Fred\n\tThe Cell\t9\n\tThe Tigger Movie\t9\nYou owed 18\nYou earned 4 frequent renter points\n", customer.GetStatement());
//		}

//		[Test]
//		public void SingleChildrensStatement()
//		{
//			customer.AddRental(new Rental(new Movie("The Tigger Movie", MovieType.Childrens), 3));
//			Assert.AreEqual("Rental Record for Fred\n\tThe Tigger Movie\t1.5\nYou owed 1.5\nYou earned 1 frequent renter points\n", customer.GetStatement());
//		}

//		[Test]
//		public void MultipleRegularStatement()
//		{
//			customer.AddRental(new Rental(new Movie("Plan 9 from Outer Space", MovieType.Regular), 1));
//			customer.AddRental(new Rental(new Movie("8 1/2", MovieType.Regular), 2));
//			customer.AddRental(new Rental(new Movie("Eraserhead", MovieType.Regular), 3));

//			Assert.AreEqual("Rental Record for Fred\n\tPlan 9 from Outer Space\t2\n\t8 1/2\t2\n\tEraserhead\t3.5\nYou owed 7.5\nYou earned 3 frequent renter points\n", customer.GetStatement());
//		}
//	}
//}
