﻿using System.ComponentModel.DataAnnotations;

namespace Localization.ViewModels
{
    public class ProductVm
    {
        [Required(ErrorMessage = "NameRequired")]
        [StringLength(20, ErrorMessage = "NameLength", MinimumLength = 6)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "PriceRequired")]
        [Range(10, 100, ErrorMessage = "PriceRange")]
        [Display(Name = "Price")]
        public int Price { get; set; }
    }
}