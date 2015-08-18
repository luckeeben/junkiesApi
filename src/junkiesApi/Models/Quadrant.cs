using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace junkiesApi.Models
{
    public class Quadrant
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
