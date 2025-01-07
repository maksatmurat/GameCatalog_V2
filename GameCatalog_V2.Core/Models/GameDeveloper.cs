using System.ComponentModel.DataAnnotations;

namespace GameCatalog_V2.Core.Models;

public class GameDeveloper
{
    public int Id { get; set; }
    [Required]
    public string? DeveloperName { get; set; }

    public string? Image { get; set; }
}
