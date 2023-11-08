namespace SupportDesk.Model
{
    public class User
    {
        public int UserId { get; set; }
        public int EmpId { get; set; }
        public Boolean Admin { get; set; } = false;
        public Boolean Agent { get; set; } = false;

        public string Name { get; set;}
        public string Phone { get; set; }
        public string? Email { get; set; } = null;
        public string UserName { get; set; } = null;
        public string Password { get; set; } = null;
        public DateTime AddDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;


        public string UserNameLowerCase()
        {
            var lowerCaseUserName = UserName.ToLower();
            return lowerCaseUserName;
        }
    }
}
