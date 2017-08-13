using System.ComponentModel.DataAnnotations;
using ExternalLogins.Facebook.ViewModels.Account;

namespace ExternalLogins.Facebook.Models.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public LoginViewModel Login { get; set; } = new LoginViewModel();

        public string ReturnUrl { get; set; }

        public string LoginProvider { get; set; }
    }
}
