using Microsoft.EntityFrameworkCore;
using Save_Seas.Models;

namespace Save_Seas.Data
{
    public class Formdbcontext:DbContext
    {
        public Formdbcontext(DbContextOptions<Formdbcontext> options) : base(options)
        {

        }

        public DbSet<ContactForm> ContactForm { get; set; }
    }
}
