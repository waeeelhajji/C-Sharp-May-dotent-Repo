#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace MtmDemo.Models;

public class Association
{
    [Key]
    public int AssociationId { get; set; }

    //! Track the IDs of our joining models/tables
    [Required]
    public int MovieId { get; set; }
    [Required]
    public int ActorId { get; set; }

    // Navigation properties
    public Actor? Actor { get; set; }
    public Movie? Movie { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;



}