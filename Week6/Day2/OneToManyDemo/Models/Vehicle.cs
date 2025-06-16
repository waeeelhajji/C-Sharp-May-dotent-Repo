#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace OneToManyDemo.Models;

public class Vehicle
{
    [Key]
    public int VehicleId { get; set; }

    [Required]
    public string ModelName { get; set; }
    [Required]
    public string Color { get; set; }
    [Required]
    public int MakerId { get; set; }

    //! Navigation property
    public Maker? Maker { get; set; }


    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}