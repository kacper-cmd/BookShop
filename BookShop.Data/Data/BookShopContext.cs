using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShop.Data.Data.Shop;

namespace BookShop.Data.Data
{
    public class BookShopContext : DbContext
    {
        public BookShopContext(DbContextOptions<BookShopContext> options)
            : base(options)
        {
        }

        public DbSet<Author> Author { get; set; } = default!;

        public DbSet<Book>? Book { get; set; }

        public DbSet<Category>? Category { get; set; }

        public DbSet<Order>? Order { get; set; }
    }
}
