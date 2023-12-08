using static SupportDesk.Service.EmailBoxService;
using SupportDesk.Models;
using System;
using SupportDesk.Model;

namespace SupportDesk.Service
{
    public class TicketService
    {
        private readonly SupportDeskDBContext _dbContext;

        public TicketService(SupportDeskDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateTicket(EmailDetails emailDetails)
        {
            
        }
    }
}
