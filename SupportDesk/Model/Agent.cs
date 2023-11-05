namespace SupportDesk.Model
{
    public class Agent
    {
        public int AgentId { get; set; }
        public int EmpId { get; set; }
        public string Name { get; set; }
        public User User { get; set; }

    }
}
