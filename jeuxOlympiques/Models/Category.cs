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
        [MinLength(3)]
        public string Description { get; set; }


        [DisplayName("Prix en €")]
        [Range(1,9999, ErrorMessage ="Le prix ne peut pas être inférieur à 1€ et supérieur à 9999€")]
        public int Price { get; set; }
    }
}
