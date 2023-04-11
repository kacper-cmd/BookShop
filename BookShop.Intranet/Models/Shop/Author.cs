using System.ComponentModel.DataAnnotations;

namespace BookShop.Intranet.Models.Shop
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
