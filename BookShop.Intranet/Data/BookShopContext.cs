using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookShop.Intranet.Models.Shop;

namespace BookShop.Intranet.Data
{
    public class BookShopContext : DbContext
    {
        public BookShopContext (DbContextOptions<BookShopContext> options)
            : base(options)
        {
        }

        public DbSet<BookShop.Intranet.Models.Shop.Author> Author { get; set; } = default!;

        public DbSet<BookShop.Intranet.Models.Shop.Book>? Book { get; set; }

        public DbSet<BookShop.Intranet.Models.Shop.Category>? Category { get; set; }

        public DbSet<BookShop.Intranet.Models.Shop.Order>? Order { get; set; }
    }
}
