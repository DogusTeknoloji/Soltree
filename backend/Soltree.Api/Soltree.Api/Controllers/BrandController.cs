using Microsoft.AspNetCore.Mvc;
using Soltree.Api.Data;
using Soltree.Api.Data.Dtos;
using Soltree.Api.Data.Etities;
using Soltree.Api.Data.Repositories;

namespace Soltree.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class BrandController : ControllerBase
    {
        private readonly IRepository<Brand> _brandRepo;

        public BrandController(IRepository<Brand> brandRepo)
        {
            _brandRepo = brandRepo;
        }

        [HttpGet]
        public IEnumerable<BrandResponseDto> Get()
        {
            var brands = _brandRepo.GetAll().Select(m => new BrandResponseDto(m.Id, m.Name)).ToList();

            return brands;
        }
    }
}
