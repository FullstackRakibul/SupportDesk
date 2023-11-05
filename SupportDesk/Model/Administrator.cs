namespace SupportDesk.Model
{
    public class Administrator
    {
        public int AdminId { get; set; }
        public int EmpId { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
    }
}
