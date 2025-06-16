#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;
namespace EFDemo.Models;

public class MyContext : DbContext 
{   

    public MyContext(DbContextOptions options) : base(options) { }    
    public DbSet<Song> Songs { get; set; } 
}
