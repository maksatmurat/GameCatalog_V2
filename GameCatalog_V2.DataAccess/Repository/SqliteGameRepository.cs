using DataAccess;
using GameCatalog_V2.DataAccess.Models;

namespace GameCatalog_V2.DataAccess.Repository;

public class SqliteGameRepository : IRepository
{
    private readonly ApplicationDbContext _db;

    public SqliteGameRepository(ApplicationDbContext db)
    {
        _db = db;
    }
    public bool CreateNewGame(GameModel newGame)
    {
        if(newGame is null) return false;
        
        _db.Add(newGame);
        _db.SaveChanges();
        return true;    
    }

    public bool EditGenre(Genre editedgenre)
    {
        if(editedgenre is null) return false;

        _db.Genres.Update(editedgenre);
        _db.SaveChanges();
        return true;
    }

    public List<GameDeveloper> GetAllDevelopers() => _db.GameDevelopers.ToList();

    public List<GameModel> GetAllGames()=>_db.Games.ToList();   

    public List<Genre> GetAllGenres()
    {
        var genres = _db.Genres.ToList();
        return genres;
    }

    public GameModel? GetGameById(int id)
    {
       var game = _db.Games.FirstOrDefault(x => x.Id == id);
        if(game is null) return null;
        return game;
    }

    public Genre? GetGenreById(int id)
    {
        var genre = _db.Genres.FirstOrDefault(x => x.Id == id); 
        if(genre is null) return null;
        return genre;
    }
}
