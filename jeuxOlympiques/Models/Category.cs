using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace jeuxOlympiques.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Catégorie Ticket")]
        [MinLength(3)]
        public string Name { get; set; }


        [DisplayName("Description")]
        [MinLength(10)]
        public string Description { get; set; }


        [DisplayName("Prix")]
        [MinLength(1)]
        public int Price { get; set; }
    }
}
