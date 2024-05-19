
using System.ComponentModel.DataAnnotations;

namespace InteractiveMapProject.Contracts.Entities;
 public class ResetPassword
{
    [Required]
    public string Password { get; set; } = null!;
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]

    public string PasswordConfirmation { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Token { get; set; } = null!;
}
