#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace FirstMvc.Models;

public class Pet
{
    [Required(ErrorMessage = "Name is required")]
    [MinLength(2,ErrorMessage="Message must be at least 3 characters in length.")]
    [MaxLength(100)]
    public string Name { get; set; }
    [Required]
    public string Species { get; set; }
    public bool IsFrindly { get; set; }
    [Required]
    [Range(0,int.MaxValue)]
    public int Age { get; set; }
}