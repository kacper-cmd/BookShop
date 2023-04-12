using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Data.Data.Shop
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        [MaxLength(200)]
        public string? Title { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        [Required]
        public int Quantity { get; set; }
        public string? ImageNameUrl { get; set; }
        //  public DateTime? DateRead { get; set; }
        //public int? Rate { get; set; }
        // public string Genre { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        //   public string CoverUrl { get; set; }
        public DateTime DateAdded { get; set; }

        //Navigation Properties
        //1 book can have single publisher - foreign key
        //public int PublisherId { get; set; }//is pimary key from the Publisher model, for book model is foreing// [Required]
        //public Publisher Publisher { get; set; }//        [ForeignKey("PublisherId")]
        //[Required]
        //public int CategoryId { get; set; }
        //[ForeignKey("CategoryId")]
        //public virtual Category Category { get; set; }

        ////many to many
        //public List<Book_Author> Book_Authors { get; set; }//        public virtual ICollection<Book_Author> Book_Authors { get; set; }

    }
}
