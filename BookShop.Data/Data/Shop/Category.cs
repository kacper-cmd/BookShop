using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Data.Data.Shop
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public string? ImageNameUrl { get; set; }

        //  public virtual ICollection<Book> Books { get; set; }


    }
}
