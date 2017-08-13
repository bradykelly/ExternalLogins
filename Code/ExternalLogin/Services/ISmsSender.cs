using System.Threading.Tasks;

namespace ExternalLogins.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
