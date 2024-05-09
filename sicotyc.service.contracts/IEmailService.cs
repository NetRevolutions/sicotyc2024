using sicotyc.entities.Models;

namespace sicotyc.service.contracts
{
    public interface IEmailService
    {
        Task<bool> SendMailAsync(EmailMetadata emailMetadata);
    }
}
