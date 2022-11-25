using Mango.Services.EmailAPI.Messages;

namespace Mango.Services.EmailAPI.Repositories
{
    public interface IEmailRepository
    {
        Task SendAndLogEmail(UpdatePaymentResultMessage message);
    }
}
