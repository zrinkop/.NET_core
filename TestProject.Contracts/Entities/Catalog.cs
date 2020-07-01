using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestProject.Contracts.Entities
{
    public class Catalog:BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Catalog name")]
        [Required(ErrorMessage ="Please enter Catalog name.")]
        public string CatalogName { get; set; }

        [Display(Name = "Desription")]
        [Required(ErrorMessage = "Please enter Catalog description.")]
        public string CatalogDescription { get; set; }

        public virtual ICollection<CatalogItems> CatalogItems { get; set; }

    }
}
