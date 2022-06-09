using dashboard.Application.Requests.Mail;
using System.Threading.Tasks;

namespace dashboard.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}