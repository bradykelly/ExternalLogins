namespace ExternalLogins.Models
{
    public class FacebookLoginModel
    {
        public static class Credentials
        {
            // NB Use Secret Manager, not these. Need to be ready for more complex auth.
            public const string AppId = "1921033554817400";
            public const string AppSecret = "18163913013fad1ba18490be1b20e473";
        }
    }
}
