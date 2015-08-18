using System.ComponentModel.DataAnnotations;

namespace junkiesApi.Models
{
    public class Ship
    {
        public int Id { get; set; }
        [Required]
        public int SectorId { get; set; }
    }
}
