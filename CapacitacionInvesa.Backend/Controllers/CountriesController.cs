using Microsoft.AspNetCore.Mvc;
using CapacitacionInvesa.Backend.Intertfaces;
using CapacitacionInvesa.Shared.Entities;

namespace CapacitacionInvesa.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : GenericController<Country>
    {
        public CountriesController(IGenericUnitOfWork<Country> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
