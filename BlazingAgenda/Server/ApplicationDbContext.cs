using BlazingAgenda.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazingAgenda.Server
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
