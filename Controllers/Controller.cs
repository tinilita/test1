using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace libshopsoul.Controllers
{
    [Route(template: "shop")]
    [ApiController]
    public class ShopController : ControllerBase
    {

        private readonly ILogger<ShopController> _logger;
        public ShopController(ILogger<ShopController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public List<Book> GetAllBooks()
        {
            return new List<Book>()
            {
                new Book()
                {
                    Name = "Дом на краю ночи",
                    Autor = "Кэтрин Бэннер"
                },
                new Book()
                {
                    Name = "Ежевичная зима",
                    Autor = "Сара Джио"
                }
            };
        }


        [HttpGet]
        public List<Shop> GetAllShop()
        {
            return new List<Shop>()
            {
                new Shop()
                {
                    Name = "Лабиринт",
                    Adress= "Пушкина, дом 3"
                },
                new Shop()
                {
                    Name = "Киви",
                    Adress = "Сковорода, строение 52"
                }
            };
        }


        [HttpPost(template:"add")]
        public void AddBook( Book book)
        {
            bd.Books.Add(book);
            bd.SaveChanges();

            return RedirectToAction("Index");
        }
    }
    
}
