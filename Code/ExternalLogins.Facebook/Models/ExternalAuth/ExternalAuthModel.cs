namespace ExternalLogins.Facebook.Models.ExternalAuth
{
    public sealed class ExternalAuthModel
    {
        // NB Matrerialize object from config store.
        public static FacebookAppDetails Facebook { get; } = new FacebookAppDetails();
    }
}
