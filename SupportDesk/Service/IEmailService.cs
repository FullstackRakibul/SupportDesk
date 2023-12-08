using SupportDesk.Helper;
namespace SupportDesk.Service
{
    public interface IEmailService
    {
        Task SendEmailAsync(Mailrequest mailrequest);
    }
}
