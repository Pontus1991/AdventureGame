using System.ComponentModel.DataAnnotations;

namespace WebLibrary2.Models.Accounts
{
    public class ValidateResetTokenRequest
    {
        [Required]
        public string Token { get; set; }
    }
}