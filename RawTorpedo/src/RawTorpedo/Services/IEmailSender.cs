using System.Threading.Tasks;

namespace RawTorpedo.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
