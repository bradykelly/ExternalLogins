using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExternalLogins.Facebook.Data;
using Microsoft.AspNetCore.Mvc;

namespace ExternalLogins.Facebook.Controllers.Base
{
    public abstract class BaseController: Controller
    {
        protected BaseController(ApplicationDbContext dbContext)
        {
            Db = dbContext;
        }

        protected ApplicationDbContext Db { get; }
    }
}
