using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExternalLogins.Facebook.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false)]
        [EmailAddress]
        [StringLength(254, MinimumLength = 5)]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

        [HiddenInput(DisplayValue = false)]
        [StringLength(2000)]
        public string ReturnUrl { get; set; }
    }
}
