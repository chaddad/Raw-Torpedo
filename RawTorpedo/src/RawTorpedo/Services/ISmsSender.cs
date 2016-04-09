using System.Threading.Tasks;

namespace RawTorpedo.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
