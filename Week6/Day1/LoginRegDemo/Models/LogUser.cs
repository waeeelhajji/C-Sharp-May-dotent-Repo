#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LoginRegDemo.Models;

public class LogUser
{

    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string LogEmail { get; set; }
    [Required]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string LogPassword { get; set; }

}
