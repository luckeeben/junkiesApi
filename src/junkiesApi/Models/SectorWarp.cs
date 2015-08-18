using System.ComponentModel.DataAnnotations;

namespace junkiesApi.Models
{
    public class SectorWarp
    {
        public int Id { get; set; }
        [Required]
        public int SectorId { get; set; }
        [Required]
        public int WarpId { get; set; }
    }
}
