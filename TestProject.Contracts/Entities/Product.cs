using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestProject.Contracts.Entities
{
    public class Product:BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Product name")]
        [Required(ErrorMessage = "Please enter Product name.")]
        public string ProductName { get; set; }

        [Display(Name = "Desription")]
        [Required(ErrorMessage = "Please enter Product description.")]
        public string ProductDescription { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Please enter Product price.")]
        public decimal BasePrice { get; set; }

        public virtual ICollection<CatalogItems> CatalogItems { get; set; }


    }
}
