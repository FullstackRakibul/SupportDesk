using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Security;
using SupportDesk.Helper;
using SupportDesk.Models;
using SupportDesk.Service;
using static SupportDesk.Service.EmailBoxService;

namespace SupportDesk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;
        private readonly EmailBoxService _emailBoxService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
            _emailBoxService = new EmailBoxService();
        }

        [HttpPost("SendMail")]
        public async Task<IActionResult> SendMail()
        {
            try
            {
                var mailrequest = new Mailrequest();

                mailrequest.ToEmail = "it@dhakawestern.com";
                mailrequest.Subject = "work from home";
                mailrequest.Body = "This is a mail body";
                if (_emailService != null)
                {
                    await _emailService.SendEmailAsync(mailrequest);
                    return Ok(mailrequest);
                }
                else
                {
                    return BadRequest("A bad request");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        [HttpGet("GetMails")]
        public IActionResult GetEmails()
        //public async Task<IActionResult> GetEmails()
        {
            
            try {
                var emailDetailsList = _emailBoxService.GetEmailDetails();
                return Ok(emailDetailsList);
            }catch (Exception ex) { 
                return BadRequest(ex.Message);
            }
        }

         
    }
}
