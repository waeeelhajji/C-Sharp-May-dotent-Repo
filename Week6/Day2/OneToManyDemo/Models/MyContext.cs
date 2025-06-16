#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;
namespace OneToManyDemo.Models;

public class MyContext : DbContext
{

    public MyContext(DbContextOptions options) : base(options) { }

    public DbSet<Maker> Makers { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
}
