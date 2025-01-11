using System.ComponentModel.DataAnnotations;

namespace GameCatalog_V2.DataAccess.Models;

public class Genre
{
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string? Name { get; set; }
    public IEnumerable<GameModel>? Games { get; set; }
}
