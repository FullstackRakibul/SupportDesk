using SupportDesk.Models;

namespace SupportDesk.Controllers
{
    public class TicketRepository
    {
        public static List<Ticket> Tickets { get; set; } = new List<Ticket>(){
                new Ticket
                {
                    Id = 1,
                    TicketId = 12452,
                    CreatedBy = new User{ UserId=1},
                    AcknowledgedBy = new Agent{ AgentId=1},
                    Subject = "This is a test subject",
                    Description ="",
                    TicketStatus =TicketStatus.Closed,
                    Priority =Priority.Regular,
                    Type ="Final Settlement",
    },
                new Ticket
                {
                    Id = 2,
                    TicketId = 11102,
                    CreatedBy = new User{ UserId=2},
                    AcknowledgedBy = new Agent{ AgentId=2},
                    Subject = "This is a test subject",
                    Description ="",
                    TicketStatus =TicketStatus.InProgress,
                    Priority = Priority.Regular,
                    Type ="Final Settlement 2nd",

                },
        };
    }
}
