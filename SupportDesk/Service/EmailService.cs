using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using MimeKit;
using SupportDesk.Helper;

namespace SupportDesk.Service
{
    public class EmailService: IEmailService
    {
        private readonly EmailSettings emailSettings;

        public EmailService(IOptions<EmailSettings>options)
        {
            this.emailSettings = options.Value;
        }

        public async Task SendEmailAsync(Mailrequest mailrequest)
        {
            var email = new MimeMessage();

            // using mail kit to send mail 

            email.Sender = MailboxAddress.Parse(emailSettings.Email);
            email.To.Add(MailboxAddress.Parse(mailrequest.ToEmail));
            email.Subject = mailrequest.Subject;

            var builder = new BodyBuilder();
            builder.HtmlBody= mailrequest.Body;
            email.Body=builder.ToMessageBody();

            // create email client 
            using var smtp = new SmtpClient();
            smtp.Connect(emailSettings.Host, emailSettings.Port,SecureSocketOptions.SslOnConnect);
            smtp.Authenticate(emailSettings.Email, emailSettings.Password);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
        }
    }
}
