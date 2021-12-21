using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameIndustryModule2.Models
{
    // Урок 11 (1)
    public class Genre
    {
        public int Id { get; set; }
        // Урок 11 (4)
        [Required]
        public string Name { get; set; }

        // Урок 16 (2.2 / 2.2)
        // создаём лист GamesGenres
        public List<GamesGenres> GamesGenres { get; set; } = new();
    }
}
