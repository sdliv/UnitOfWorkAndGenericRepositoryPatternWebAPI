using System;
namespace Domain.Interfaces
{
    public interface IPersonRepository : IGenericRepository<Person>
	{
		IEnumerable<Person> GetAdults();
	}
}

