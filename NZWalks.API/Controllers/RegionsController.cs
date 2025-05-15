using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Controllers.Models.Domain;
using NZWalks.API.Data;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly NZWalksDbContext dbContext;

        public RegionsController(NZWalksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAll()
        {

            var regions = dbContext.Regions.ToList();

            return Ok(regions);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            var regionId = dbContext.Regions.FirstOrDefault(r => r.Id == id);

            if (regionId == null) {
                return NotFound();
            }

            return Ok(regionId);
        }

    }
}
