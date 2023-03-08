using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace BookShopAsp.Models
{
    public class Order
    {
            // ID покупки
            public int Id { get; set; }
            // имя и фамилия покупателя
            [Required]
            [Display(Name = "Покупатель")]
            public string UserId { get; set; }
            public IdentityUser? User { get; set; }
            // адрес покупателя
            [Required]
            [Display(Name = "Адрес")]
            public string Address { get; set; }
            // ID книги
            [Required, Display(Name = "Книга")]
            public int BookId { get; set; }
            public Book? Book { get; set; }
            // дата покупки
            [DataType(DataType.Date), Display(Name ="Дата")]
            public DateTime Date { get; set; }
        }
}
