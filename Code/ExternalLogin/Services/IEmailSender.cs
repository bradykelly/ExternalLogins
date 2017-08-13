using System.Threading.Tasks;

namespace ExternalLogins.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
