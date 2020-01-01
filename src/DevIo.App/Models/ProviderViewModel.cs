using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace DevIo.App.Models
{
    public class ProviderViewModel
    {
        [HiddenInput]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [StringLength(120, MinimumLength = 3, ErrorMessage = " {0} size should be between {2} and {1}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [StringLength(14, MinimumLength = 11, ErrorMessage = " {0} size should be between {2} and {1}")]
        public string Document { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [Display(Name = "Provider Type")]
        public int ProviderType { get; set; }
        public AddressViewModel Address { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [Display(Name = "Is Active?")]
        public bool IsActive { get; set; }
        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}