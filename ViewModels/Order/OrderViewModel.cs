﻿using AloeExpress.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AloeExpress.ViewModels.Order
{
    public class OrderViewModel
    {
        [Key]
        [Display(Name ="Order Id")]
        public int Id { get; set; }
        public int RecipientId { get; set; }
        [Display(Name ="Product")]
        public ProductAddViewModel Product { get; set; }
        [Display(Name ="Product Type")]
        public ProductTypeAddViewModel ProductType { get; set; }
        public bool IsDeleted { get; set; }
    }
}
