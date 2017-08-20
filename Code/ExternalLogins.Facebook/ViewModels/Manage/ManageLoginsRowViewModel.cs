using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.AspNetCore.Identity;

namespace ExternalLogins.Facebook.ViewModels.Manage
{
    public class ManageLoginsRowViewModel
    {
        public string UserId { get; set; }

        public string LoginProvider { get; set; }

        public string ProviderDisplayName { get; set; }

        public string DisplayName => ProviderDisplayName ?? LoginProvider;

        public string ProviderKey { get; set; }

        public string AuthenticationScheme { get; set; }

        public bool IsLinked { get; set; }
    }
}

