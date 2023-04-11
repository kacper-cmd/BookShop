using System.ComponentModel.DataAnnotations;

namespace BookShop.Intranet.Models.Shop
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
