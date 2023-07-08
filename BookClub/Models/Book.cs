using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace BookClub.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Display(Name = "Книги")]
        public string Title { get; set; }

        [Display(Name = "Авторы")]
        public string Author { get; set; }

        public decimal Cost { get; set; }
    }
}
