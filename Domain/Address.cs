using System;
namespace Domain
{
	public class Address
	{
		public int AddressId { get; set; }

		public string StreetAddress { get; set; }

		public string City { get; set; }

		public string State { get; set; }

		public string Zipcode { get; set; }

		public Address()
		{
		}
	}
}

