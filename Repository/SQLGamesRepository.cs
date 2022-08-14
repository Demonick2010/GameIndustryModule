using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GameIndustryModule2.Repository
{
    // Урок 18 (10) Создаём класс репозитория для коммуникации с реальной базой данных SQLGamesRepository
    public class SqlGamesRepository : IRepository
    {
        // Урок 18 (11) Реализовать все методы нового класса
        private readonly ApplicationDbContext _db;
        public SqlGamesRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool CreateNewGame(Game newGame)
        {
            if (newGame is null)
                return false;

            _db.Add(newGame);
            _db.SaveChanges();
            return true;
        }

        public bool EditGenre(Genre editedGenre)
        {
            if (editedGenre is null)
                return false;

            _db.Genres.Update(editedGenre);
            _db.SaveChanges();
            return true;
        }

        public List<GameDeveloper> GetAllDevelopers() => _db.GameDevelopers.ToList();

        public List<Game> GetAllGames() => _db.Games.Include(x => x.GamesGenres).ToList();

        public List<Genre> GetAllGenres() => _db.Genres.Include(x => x.GamesGenres).ToList();

        public Game GetGameById(int id) => _db.Games.Include(x => x.GamesGenres).FirstOrDefault(x => x.Id == id);

        public Genre GetGenreById(int id) => _db.Genres.Include(x => x.GamesGenres).FirstOrDefault(x => x.Id == id);
    }
}
