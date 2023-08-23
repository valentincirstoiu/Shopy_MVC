using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Shopy.Models
{
    public class Category
    {
        [Key]                               // in cazul in care vrei sa schimbi numele ID-ului principal
        public int Id { get; set; }
        [Required]                          //nu poate fi null in SQL
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="Display Order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
