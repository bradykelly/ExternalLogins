using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Emit;

namespace ExternalLogins.Facebook
{
    public class LoginViewModel
    {
        // TODO Show password.
        [Required(AllowEmptyStrings = false)]
        [EmailAddress]
        [StringLength(10)]
        [Display(Name = "Email")]
        public string UserName { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me?")]
        public bool RememberMe { get; set; }

        [ScaffoldColumn(false)]
        [StringLength(254, MinimumLength = 3)]
        public string Email { get; set; }
    }
}
