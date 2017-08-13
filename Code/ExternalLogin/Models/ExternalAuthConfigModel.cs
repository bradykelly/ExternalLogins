using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExternalLogins.Models
{
    public static class ExternalAuthConfigModel
    {
        public static class Facebook
        {
            public static class SecretKeys
            {
                public const string AppIdKey = "Auth:Logins:Facebook:AppId";
                public const string AppSecretKey = "Auth:Logins:Facebook:AppSecret";
            }
        }
    }
}
