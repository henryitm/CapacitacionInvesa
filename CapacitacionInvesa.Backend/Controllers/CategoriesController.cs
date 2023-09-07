using CapacitacionInvesa.Backend.Intertfaces;
using CapacitacionInvesa.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CapacitacionInvesa.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : GenericController<Category>
    {
        public CategoriesController(IGenericUnitOfWork<Category> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
