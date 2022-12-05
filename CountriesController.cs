using Microsoft.AspNetCore.Mvc;
using backendcountry.Models;

namespace backendcountry.Controllers;

[ApiController]
[Route("api/countries")]
public class CountriesController : ControllerBase
{
  private readonly CountrydbsContext DBContext;

    public CountriesController(CountrydbsContext dbContext)
    {
       this.DBContext = dbContext;
    }

    [HttpGet("GetCountryDetails")]
    public IQueryable<Countrystabless> GetAll()
    {
var users =this.DBContext.Countrystablesses;
return users;
    }


    [HttpGet("GetCountryDetailsById/{cName}")]
    public IActionResult GetByID(string cName)
    {
            var users =this.DBContext.Countrystablesses.FirstOrDefault(o=>o.CountryName==cName);
            return Ok(users);
    }


}