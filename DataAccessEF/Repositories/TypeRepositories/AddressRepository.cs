using System;
using Domain;
using Domain.Interfaces;

namespace DataAccessEF.Repositories.TypeRepositories
{
	public class AddressRepository : GenericRepository<Address>, IAddressRepository
	{
		public AddressRepository(PeopleContext context): base(context)
		{
		}
	}
}

