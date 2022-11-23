using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private readonly IUnitOfWork unitOfWork;

    public PersonController(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IEnumerable<Person> GetPeople()
    {
        return unitOfWork.Person.GetAll();
    }

    [Route("[action]")]
    [HttpGet]
    public IEnumerable<Person> GetAdults()
    {
        return unitOfWork.Person.GetAdults();
    }
}

