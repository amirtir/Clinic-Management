using System.ComponentModel.DataAnnotations;

namespace dashbord.Models;

public class User
{
    [Key]       
    public int UserId { get; set; }
    [EmailAddress]
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
}