using System.ComponentModel.DataAnnotations;

namespace WebLibrary2.Models.Accounts
{
    public class VerifyEmailRequest
    {
        [Required]
        public string Token { get; set; }
    }
}
