using Entraides.Services.NecessiteuxAPI.Models.Dtos;

namespace Entraides.Services.NecessiteuxAPI.Repository
{
    public interface IBenevoleRepository
    {
        Task<IEnumerable<BenevoleDto>> GetBenevoles();
        Task<BenevoleDto> GetBenevoleById(int id);
        Task<BenevoleDto> CreateUpdateBenevole(BenevoleDto benevoleDto);
        Task<bool> DeleteBenevole(int id);
    }
}
