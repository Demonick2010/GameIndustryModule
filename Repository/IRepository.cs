using System.Collections.Generic;
using GameIndustryModule2.Models;

// Урок 9 модуль 2(8)
namespace GameIndustryModule2.Repository
{
    public interface IRepository
    {
        List<Game> GetAllGames();

        // Урок 11 (11.3)
        List<Genre> GetAllGenres();
        List<GameDeveloper> GetAllDevelopers();

        // Урок 11 (11.4)
        Genre GetGenreById(int id);
        // Урок 15
        Game GetGameById(int id);

        // Урок 11 (11.5)
        bool EditGenre(Genre editedGenre);

        // Урок 15
        bool CreateNewGame(Game newGame);
    }
}