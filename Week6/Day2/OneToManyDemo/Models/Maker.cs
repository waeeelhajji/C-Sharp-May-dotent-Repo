#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace OneToManyDemo.Models;

public class Maker
{
    [Key]
    public int MakerId { get; set; }

    [Required]
    public string Name { get; set; }
    
    // Navigation property
    public List<Vehicle> AllVehicles { get; set; } = new List<Vehicle>();

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}