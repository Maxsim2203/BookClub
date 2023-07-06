using BookClub.Models;
using Microsoft.AspNetCore.Identity;

namespace BookClub.Data
{
    public class ApplicationIdentityUser : IdentityUser
    {
        public string Fio { get; set; }
        public string Password { get; set; }    
        public string Email { get; set; }
    }
}
