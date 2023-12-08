using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SupportDesk.Models
{
    public class Ticket
    {
        
        public int Id { get; set; }
        public User CreatedBy { get; set; } = new User();
        public int TicketId { get; set; }
        public string Subject { get; set; } = "";
        public string Description { get; set; } = "";
        public IFormFile? Attachments { get; set; }
        public TicketStatus TicketStatus { get; set; }= TicketStatus.Open;
        public Agent AcknowledgedBy { get; set; }= new Agent();
        public Priority Priority { get; set; }= Priority.Regular;
        public string Type { get; set; } = "";
        public DateTime OpenDate { get; set; }
        public DateTime FirstReplyDate { get; set; }
        public DateTime SolveDate { get; set; }
        public DateTime ReopenDate { get; set; }
        public DateTime FinalSolveDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
public enum Priority
{
    High,
    Low,
    Emergency,
    BusinessClass,
    Regular
}

public enum TicketStatus
{
    Open,
    InProgress,
    Closed
}
}
