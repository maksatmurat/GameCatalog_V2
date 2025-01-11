
using GameCatalog_V2.DataAccess.Models;

namespace GameCatalog_V2.DataAccess.Repository;

public interface IRepository
{
    List<GameModel> GetAllGames();
    bool CreateNewGame(GameModel newGame);
    GameModel? GetGameById(int id);
    List<Genre> GetAllGenres();
    Genre? GetGenreById(int id);
    bool EditGenre(Genre editedgenre);
    List<GameDeveloper> GetAllDevelopers();
}
