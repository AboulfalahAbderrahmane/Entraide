using System.ComponentModel.DataAnnotations;

namespace Entraides.Services.NecessiteuxAPI.Models.Dtos
{
    public class BenevoleDto
    {  
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }

        public bool Active { get; set; }
    }
}
