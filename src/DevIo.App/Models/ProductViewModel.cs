using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevIo.App.Models
{
    public class ProductViewModel
    {
        [HiddenInput]
        public Guid Id { get; set; }

        public Guid ProviderId { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [StringLength(120, MinimumLength = 3, ErrorMessage = " {0} size should be between {2} and {1}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [StringLength(400, MinimumLength = 3, ErrorMessage = " {0} size should be between {2} and {1}")]
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public IFormFile Image { get; set; }

        [Required(ErrorMessage = "{0} is required!")]       
        public decimal Price { get; set; }

        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime Created { get; set; }

        [Display(Name = "Is Active?")]
        public bool IsActive { get; set; }

        public ProviderViewModel Provider { get; set; }
        public IEnumerable<ProviderViewModel> Providers { get; set; }

    }
}