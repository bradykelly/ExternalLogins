using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ExternalLogins.Models
{
    public static class ExternalAuthModel
    {
        public static class Facebook
        {
            public static class SecretKeys
            {
                public const string AppIdKey = "Auth:Facebook:AppId";
                public const string AppSecretKey = "Auth:Facebook:AppSecret";
            }
        }

        public static class Twitter
        {
            public const string ApiKey = "Auth.Google.ApiKey";
            public const string ApiSecret = "Auth.Google.ApiSecret";
        }
    }
}
