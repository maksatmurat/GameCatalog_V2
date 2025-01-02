﻿namespace GameCatalog_V2.Core.Models;

public class GameModel
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Genre { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public string? Image { get; set; }
}
