#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;
namespace MtmDemo.Models;

public class MyContext : DbContext
{

    public MyContext(DbContextOptions options) : base(options) { }

    public DbSet<Movie> Movies { get; set; }
    public DbSet<Actor> Actors { get; set; } 
    public DbSet<Association> Associations { get; set; }
}
