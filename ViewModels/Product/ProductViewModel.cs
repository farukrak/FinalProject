using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AloeExpress.ViewModels.Product
{
    public class ProductViewModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        [Display(Name = "Product Quantity")]
        public int Quantity { get; set; }
        [Display(Name="Volume")]
        public float Volume { get; set; }
        [Display(Name="Weight")]
        public float Weight { get; set; }

    }
}
