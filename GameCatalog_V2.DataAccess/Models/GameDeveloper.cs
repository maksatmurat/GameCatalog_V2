using System.ComponentModel.DataAnnotations;

namespace GameCatalog_V2.DataAccess.Models;

public class GameDeveloper
{
    public int Id { get; set; }
    [Required]
    public string? DeveloperName { get; set; }
    public string? StudioDescription { get; set; }
    public string? Image { get; set; }
    public IEnumerable<GameModel>? GameModels { get; set; }

}
