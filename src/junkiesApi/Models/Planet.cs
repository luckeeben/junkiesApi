using System.ComponentModel.DataAnnotations;
using junkiesApi.Repos;

namespace junkiesApi.Models
{
    public class Planet
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int SectorId { get; set; }
    }
}
