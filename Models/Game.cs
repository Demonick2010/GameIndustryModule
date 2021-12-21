using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Урок 9 модуль 2(1)
namespace GameIndustryModule2.Models
{
    public class Game
    {
        //Урок 10 (11)
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        // Урок 15 (1)
        // Добавить несколько свойств
        public string Description { get; set; } // Описание
        public bool InSale { get; set; } // В продаже?
        public string GameplayVideo { get; set; } // Ссылка на видео ютуба

        // Урок 12 (3)
        //public string Genre { get; set; }

        // Урок 16 (2.1 / 2.2)
        // Комментируем GenreId и создаём лист GamesGenres
        //public int GenreId { get; set; }
        public List<GamesGenres> GamesGenres { get; set; } = new();

        [Required]
        public DateTime? ReleaseDate { get; set; }
        public string Image { get; set; }

        public string ShortName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Name))
                    return null;

                if (Name.Length > 60)
                    return Name.Substring(0, 60) + "...";
                else
                    return Name;
            }
        }
    }
}

//////////////////////////