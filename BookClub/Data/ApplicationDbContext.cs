using BookClub.Models;
using BookClub.Views.Home;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookClub.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationIdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ReadBook> ReadBooks { get; set; }
        //public string Author { get; set; }

        //public decimal Cost { get; set; }
        public DbSet<Book> Books { get; set; }
        public object DetailBooks { get; internal set; }

        //public DbSet<Book_detailModel> Book_Details { get; set; }  
    }
}