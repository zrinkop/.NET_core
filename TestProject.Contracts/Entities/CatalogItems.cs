using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestProject.Contracts.Entities
{
    public class CatalogItems:BaseEntity
    { 
    
        [Key, Column(Order = 0)]
        public int CatalogId { get; set; }

        [Key, Column(Order = 1)]
        public int ProductId { get; set; }

        public virtual Catalog Catalog { get; set; }

        public virtual Product Product { get; set; }
    }
}
