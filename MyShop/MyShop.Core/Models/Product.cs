using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Product
    {
        public string Id { get; set; }

        [StringLength(20)]
        [DisplayName("Producto")]
        public string Name { get; set; }
        [DisplayName("Descripción")]
        public string Description { get; set; }
        [DisplayName("Precio")]
        public decimal Price { get; set; }
        [DisplayName("Categoría")]
        public string Category { get; set; }
        [DisplayName("Imagen")]
        public string Image { get; set; }

        public Product()
        {
            this.Id = Guid.NewGuid().ToString();
        }

    }
}
