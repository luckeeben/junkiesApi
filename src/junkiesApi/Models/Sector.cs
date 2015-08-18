using System.ComponentModel.DataAnnotations;

namespace junkiesApi.Models
{
    public class Sector
    {
        public int Id { get; set; }
        [Required]
        public int No { get; set; }
        [Required]
        public int QuadrantId { get; set; }
    }
}
