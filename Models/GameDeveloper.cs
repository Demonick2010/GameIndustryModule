using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameIndustryModule2.Models
{
    // Урок 13 (1)
    public class GameDeveloper
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        // Урок 14 (4)
        [Required]
        public string StudioDescription { get; set; }
    }
}
