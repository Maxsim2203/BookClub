using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BookClub.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Display(Name = "Книга")]
        public string Title { get; set; }

        [Display(Name = "Авторы")]
        public string Author { get; set; }

        [Display(Name = "Цена")]
        public decimal Cost { get; set; }

        [Display(Name = "Анотация")]
        public string Description { get; set; }

        //[Display(Name = "Дата выхода")]
        //public Date relase { get; set; }
        [Display(Name = "Редакция")]
        public string Edition { get; set; } 
    }
}
