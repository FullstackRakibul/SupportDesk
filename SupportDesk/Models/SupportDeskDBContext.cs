using Microsoft.EntityFrameworkCore;
using SupportDesk.Models;



namespace SupportDesk.Model
{
    public class SupportDeskDBContext : DbContext
    {
        public SupportDeskDBContext(DbContextOptions<SupportDeskDBContext> options)
            :base(options) { 
        }

        public DbSet<Ticket> Tickets {
            get; set; 
        }

        public DbSet<Agent> Agents {
            get; set; 
        }

        public DbSet<User> Users
        {
            get; set;
        }

    }
}
