using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExternalLogins.Facebook.ViewModels.Manage;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.AspNetCore.Identity;

namespace ExternalLogins.Facebook.Models.ManageViewModels
{
    public class ManageLoginsViewModel
    {
        public ApplicationUser User { get; set; }

        public List<ManageLoginsRowViewModel> CurrentLogins { get; set; } = new List<ManageLoginsRowViewModel>();

        public List<ManageLoginsRowViewModel> OtherLogins { get; set; } = new List<ManageLoginsRowViewModel>();
    }
}
