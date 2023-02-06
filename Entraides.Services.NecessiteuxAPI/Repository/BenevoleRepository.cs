using AutoMapper;
using Entraides.Services.NecessiteuxAPI.DbContexts;
using Entraides.Services.NecessiteuxAPI.Models;
using Entraides.Services.NecessiteuxAPI.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Entraides.Services.NecessiteuxAPI.Repository
{
    public class BenevoleRepository : IBenevoleRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;
        public BenevoleRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<BenevoleDto> CreateUpdateBenevole(BenevoleDto benevoleDto)
        {

            Benevole benevole = _mapper.Map<BenevoleDto, Benevole>(benevoleDto);
            if (benevole.Id > 0)
                _db.Benevoles.Update(benevole);
            else

                _db.Benevoles.Add(benevole);
            await _db.SaveChangesAsync();
            return _mapper.Map<Benevole, BenevoleDto>(benevole);
        }

        public async Task<bool> DeleteBenevole(int id)
        {
            try
            {
                Benevole benevole = await _db.Benevoles.Where(x => x.Id == id).FirstOrDefaultAsync();
                if (benevole == null) return false;
                _db.Benevoles.Remove(benevole);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<BenevoleDto> GetBenevoleById(int id)
        {
            Benevole benevole = await _db.Benevoles.Where(x => x.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<BenevoleDto>(benevole);
        }

        public async Task<IEnumerable<BenevoleDto>> GetBenevoles()
        {
            List<Benevole> benevoleList = await _db.Benevoles.ToListAsync();
            return _mapper.Map<List<BenevoleDto>>(benevoleList);
        }
    }
}
