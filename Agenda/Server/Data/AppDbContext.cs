using Agenda.Shared.Models;
using Microsoft.EntityFrameworkCore;
namespace FilmCrud.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        //Referenciamos los modelos que vaya a utilizar Entity Framework. 
        public DbSet<Contact> Contacts { get; set; }
    }
}
