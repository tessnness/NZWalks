using NZWalks.API.Controllers.Models.Domain;

namespace NZWalks.API.Repositories
{
    public interface IRegionRepository
    {
        Task<List<Region>> GetAllAsync();
        Task<Region?> GetByIdAsync(Guid id);
        Task<Region> DeleteAsync(Guid id);
        Task<Region?> UpdateAsync(Guid id, Region region);
        Task<Region> CreateAsync(Region region);
    }
}
