namespace ExternalLogins.Facebook.Models.ExternalAuth
{
    public class FacebookAppDetails
    {
        public readonly string Scheme = "Facebook";

        // TODO One scheme many uses.
        // NB Put below into list of n tuples.
        public string AppId { get; set; }
        public string AppSecret { get; set; }
    }
}