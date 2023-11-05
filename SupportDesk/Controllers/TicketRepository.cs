using SupportDesk.Model;

namespace SupportDesk.Controllers
{
    public class TicketRepository
    {
        public static List<Ticket> Tickets { get; set; } = new List<Ticket>(){
                new Ticket
                {
                    Id = 1,
                    TicketId = 12452,
                    Subject = "This is a test subject",
                    Description ="",
                    Status =true,
                    Priority ="Normal",
                    Type ="Final Settlement",
    },
                new Ticket
                {
                    Id = 2,
                    TicketId = 11102,
                    Subject = "This is a test subject",
                    Description ="",
                    Status =true,
                    Priority ="Normal",
                    Type ="Final Settlement",

                },
        };
    }
}
