using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Runtime.InteropServices.JavaScript.JSType;
using BookClub.Data;
using System.ComponentModel.DataAnnotations;

namespace BookClub.Views.Home
{
    public class Book_detailModel : PageModel
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public decimal Cost { get; set; }
        public Date relase { get; set; }

        public string? Edition { get; set; }
    }
}