
using System.ComponentModel.DataAnnotations;

namespace InteractiveMapProject.Contracts.Entities;
 public class ResetPassword
{
    [Required]
    public string Password { get; set; } = null!;
    [Compare("Password")]

    public string PasswordConfirmation { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Token { get; set; } = null!;
}
