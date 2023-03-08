using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BookShopAsp.Models
{
    public class Book
    {
         // ID книги
            public int Id { get; set; }
            // название книги
            [Required]
            [Display(Name = "Название")]
            public string Name { get; set; }
            // автор книги
            [Required]
            [Display(Name = "Автор")]
            public string Author { get; set; }

            [Display(Name = "Жанр")]
            public string Genre { get; set; }
            // цена
            [Required]
            [Display(Name = "Цена")]
            public int Price { get; set; }
            public List<Order> Orders { get; set; } = new List<Order>();
        
    }
}

