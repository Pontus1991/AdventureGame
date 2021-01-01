using System.ComponentModel.DataAnnotations;

namespace WebLibrary2.Models.Accounts
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
