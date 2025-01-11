using GameCatalog_V2.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlite("Data Source:C:\\Users\\Maksat\\source\\repos\\GameCatalog_V2\\GameCatalog_V2.DataAccess\\Database\\GameIndustryBase.db");
    //}

    public DbSet<GameModel> Games { get; set; }
    public DbSet<GameDeveloper> GameDevelopers { get; set; }
    public DbSet<Genre> Genres { get; set; }
}
