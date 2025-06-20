#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace MtmDemo.Models;

public class Actor
{
    [Key]
    public int ActorId { get; set; }
    [Required]
    [MinLength(2)]
    public string Name{ get; set; }
    [Required]
    [MinLength(3)]
    public string Image { get; set; }
    // Navigation properties
    public List<Association> MyMovies { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

}