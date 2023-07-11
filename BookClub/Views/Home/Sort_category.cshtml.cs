using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BookClub.Views.Home
{
    public class Sort_categoryModel : PageModel
    { 
            public int Id { get; set; }
            public string Category { get; set; }
    }
}
