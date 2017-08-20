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
        public ManageLoginsRowViewModel(string userId)
        {
            UserId = userId;
        }

        public string UserId { get; set; }

        public string LoginProvider { get; set; }

        string ProviderDisplayName { get; set; }

        public string ProviderKey { get; set; }

        public bool IsLinked { get; set; }
    }
}

