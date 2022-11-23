using System;
using Domain;
using Domain.Interfaces;

namespace DataAccessEF.Repositories.TypeRepositories
{
	public class PersonRepository : GenericRepository<Person>, IPersonRepository
	{
		public PersonRepository(PeopleContext context): base(context)
		{
		}

        public IEnumerable<Person> GetAdults()
        {
            return context.Person.Where(pers => pers.Age >= 18).ToList();
        }
    }
}

