using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public static class DataBooks
    {
        public static void Init(BookContext context)
        {
            if(!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Name = "CLR via C#",
                        Author = "Jeffrey Richter",
                        Price = 2000.0

                    },
                    new Book
                    {
                        Name = "ASP.NET CORE MVC",
                        Author = "Adam Freeman",
                        Price = 2500.0
                    },
                    new Book
                    {
                        Name = "Computer Networks",
                        Author = "Andrew Tanenbaum",
                        Price = 1500.0
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
