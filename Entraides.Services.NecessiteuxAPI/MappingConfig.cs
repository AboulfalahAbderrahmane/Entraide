using AutoMapper;
using Entraides.Services.NecessiteuxAPI.Models;
using Entraides.Services.NecessiteuxAPI.Models.Dtos;

namespace Entraides.Services.NecessiteuxAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<BenevoleDto, Benevole>();
                config.CreateMap<Benevole, BenevoleDto>();
            }

                );
            return mappingConfig;
        }
    }
}
