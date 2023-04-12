using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Data.Data.Shop
{
    public class Author
    {
        [Key]
        public int Id { get; set; }//AuthorId 
        [Required]
        [MaxLength(100)]
        public string? FullName { get; set; }

        //Navigations Properties //lub         public virtual ICollection<Book_Author> Book_Authors { get; set; }
        //public List<Book_Author> Book_Authors { get; set; }
    }
}
