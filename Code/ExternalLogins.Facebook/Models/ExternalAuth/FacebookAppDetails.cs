namespace ExternalLogins.Facebook.Models.ExternalAuth
{
    public class FacebookAppDetails
    {
        public readonly string Scheme = "Facebook";

        // TODO One scheme many uses.
        public string AppId { get; set; }
        public string AppSecret { get; set; }
    }
}