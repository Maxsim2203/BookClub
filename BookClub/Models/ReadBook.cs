using BookClub.Data;
using System.ComponentModel.DataAnnotations;

namespace BookClub.Models
{
    public class ReadBook
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        [Display(Name = "Книги")]
       //public string Author { get; set; }

        //public decimal Cost { get; set; }

        public Book? Book { get; set; }

        public string UserId { get; set; }
        [Display(Name = "Пользователь")]
        public ApplicationIdentityUser? User { get; set; }

      
    }
}
