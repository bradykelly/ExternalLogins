using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ExternalLogins.Facebook.ViewModels.Account
{
    public class LoginViewModel
    {
        // TODO Show password.
        [Required(AllowEmptyStrings = false)]
        [EmailAddress]
        [Display(Name = "Email")]
        public string UserName { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me?")]
        public bool RememberMe { get; set; }

        [HiddenInput(DisplayValue = false)]
        [StringLength(2000)]
        public string ReturnUrl { get; set; }

        [HiddenInput(DisplayValue = false)]
        [StringLength(254, MinimumLength = 5)]
        public string Email
        {
            get => UserName;
            set => UserName = value;
        }

        [HiddenInput(DisplayValue = false)]
        [StringLength(50)]
        public string LoginProvider { get; set; }
    }
}
