#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace MtmDemo.Models;


public class Movie
{
    [Key]
    public int MovieId { get; set; }
    [Required]
    public string Title { get; set; }
    // Navigation properties
    public List<Association> MyActors { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;


}