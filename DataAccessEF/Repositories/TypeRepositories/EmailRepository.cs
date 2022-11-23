using System;
using Domain;
using Domain.Interfaces;

namespace DataAccessEF.Repositories.TypeRepositories
{
	public class EmailRepository : GenericRepository<Email>, IEmailRepository
	{
		public EmailRepository(PeopleContext context): base(context)
		{
		}
	}
}

