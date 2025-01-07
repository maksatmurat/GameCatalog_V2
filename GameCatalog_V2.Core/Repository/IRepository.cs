
using GameCatalog_V2.Core.Models;

namespace GameCatalog_V2.Core.Repository;

public interface IRepository
{
    List<GameModel> GetAllGames();
}
