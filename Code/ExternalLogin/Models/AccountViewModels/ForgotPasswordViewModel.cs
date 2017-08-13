using System.ComponentModel.DataAnnotations;

namespace ExternalLogins.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
