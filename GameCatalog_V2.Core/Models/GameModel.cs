﻿namespace GameCatalog_V2.Core.Models;

public class GameModel
{
    public int Id { get; set; } = 1;
    public string? Name { get; set; }
    public int GenreId { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public string? Image { get; set; }
}
