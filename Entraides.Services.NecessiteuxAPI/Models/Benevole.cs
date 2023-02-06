using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entraides.Services.NecessiteuxAPI.Models
{
    [Table("Benevoles")]
    public class Benevole
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(50)]
        public string Tel { get; set; }

        public bool Active { get; set; }

    }
}
