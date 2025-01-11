using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameCatalog_V2.DataAccess.Models;

public class GameModel
{
    public int Id { get; set; } = 1;
    [Required]
    [MinLength(3), MaxLength(50)]
    public string? Name { get; set; }
    [Required]
    [MinLength(3), MaxLength(500)]
    public string? Description { get; set; }
    public bool InSale { get; set; }
    public string? GamePlayVideo { get; set; }
    [Required]
    public DateTime? ReleaseDate { get; set; }
    public string? Image { get; set; }
    public string? ShortName
    {
        get
        {
            if (string.IsNullOrWhiteSpace(Name))
                return null;
            else if (Name.Length > 50)
                return Name.Substring(0, 50) + "...";
            else return Name;
        }
    }
    public int? DeveloperId { get; set; }
    [ForeignKey(nameof(DeveloperId))]
    public GameDeveloper? Developer { get; set; }
    public IEnumerable<Genre>? Genres { get; set; }
}
