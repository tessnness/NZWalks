using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Controllers.Models.Domain;
using NZWalks.API.Data;
using NZWalks.API.Models.DTO;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {
        private readonly NZWalksDbContext dbContext;
        private readonly IMapper mapper;
        private readonly IWalkRepository walkRepository;

        public WalksController(NZWalksDbContext dbContext, IMapper mapper, IWalkRepository walkrepository)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.walkRepository = walkrepository;
        }

        public IWalkRepository Walkrepository { get; }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddWalkRequestDto addWalksRequestDto)
        {
            var walkDomainModel = mapper.Map<Walk>(addWalksRequestDto);

            await walkRepository.CreateAsync(walkDomainModel);

            return Ok(mapper.Map<WalkDto>(walkDomainModel));

            //var walksDto = mapper.Map<Walk>

            //return CreatedAtAction(nameof(), new {Id =  walkDto.Id}, walkDto)
        }
    }
}
