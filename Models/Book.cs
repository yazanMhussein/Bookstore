using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100,MinimumLength =5,ErrorMessage ="please enter more text please")]
        public string Title { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "please enter more text please")]
        public string Author { get; set; }
        [Required][Range(1,900,ErrorMessage = "Price must be between 1 and 900")]
        public double Price { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "please enter more text please")]
        public string Genre { get; set; }
    }
}
