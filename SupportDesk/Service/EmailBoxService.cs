using MailKit.Net.Pop3;
using MimeKit.Cryptography;
using MimeKit;
using System.Collections.Generic;
using System.IO;
using static SupportDesk.Service.EmailBoxService;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SupportDesk.Models;
using SupportDesk.Model;

namespace SupportDesk.Service
{
    public class EmailBoxService
    {
        private readonly SupportDeskDBContext _dbContext;

        public EmailBoxService(SupportDeskDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public class EmailDetails
        {
            public string Subject { get; set; } = "";
            public string Body { get; set; } = "";
            public string From { get; set; } = "";
            public string To { get; set; } = "";
            public string Cc { get; set; } = "";
            public string Bcc { get; set; } = "";
            public List<string>? Attachments { get; set; }
            // Add more properties as needed
        }
        private List<string> GetAttachmentFilenames(MimeMessage message)
        {
            var attachmentFilenames = new List<string>();

            foreach (var attachment in message.Attachments)
            {
                var filename = attachment.ContentDisposition?.FileName ?? "Attachment";
                attachmentFilenames.Add(filename);
            }

            return attachmentFilenames;
        }
        public List<EmailDetails> GetEmailDetails() {
            var emails = new List<string>();
            var emailDetailsList = new List<EmailDetails>();
            try
            {
                using var client = new Pop3Client();
                client.Connect("mail.dhakawestern.com", 995, true);
                client.Authenticate("it@dhakawestern.com", "it@dhakawestern.com");

                for (int i = 0; i < client.Count; i++)
                {
                    var message = client.GetMessage(i);
                    var emailDetails = new EmailDetails
                    {
                        Subject = message.Subject,
                        Body = message.TextBody,
                        From = message.From.ToString(),
                        To = message.To.ToString(),
                        Cc = message.Cc.ToString(),
                        Bcc = message.Bcc.ToString(),
                        Attachments = GetAttachmentFilenames(message)

                    };
                    // create mail in Ticket 
                    //var ticket = new Ticket
                    //{
                    //    Subject = emailDetails.Subject,
                    //    Body = emailDetails.Body,
                    //    From = emailDetails.From,
                    //    To = emailDetails.To,
                    //    Cc = emailDetails.Cc,
                    //    Bcc = emailDetails.Bcc,
                    //    Attachments = emailDetails.Attachments
                    //    // Set other properties accordingly
                    //};

                    //_dbContext.Tickets.Add(ticket);
                    //_dbContext.SaveChanges();

                    emailDetailsList.Add(emailDetails);
                }
                client.Disconnect(true);

            }catch (Exception e) { 
                Console.WriteLine(e.Message);
            }
            return emailDetailsList;
        }
        

        public EmailBoxService()
        {
            try
            {
                using var client = new Pop3Client();
                client.Connect("mail.dhakawestern.com", 995, false);
                client.Authenticate("it@dhakawestern.com", "it@dhakawestern.com");
                for (int i = 0; i < client.Count; i++)
                {
                    var message = client.GetMessage(i);


                    Console.WriteLine("Subject:{0}",
                    message.Subject);
                    
                }
                client.Disconnect(true);
            }catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}
