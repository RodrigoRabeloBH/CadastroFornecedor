using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace DevIo.App.Models
{
    public class AddressViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = " {0} size should be between {1} characteres")]
        public string Zipcode { get; set; }

        [Required(ErrorMessage = "{0} is required!")]        
        public int Number { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [StringLength(120, MinimumLength = 3, ErrorMessage = " {0} size should be between {2} and {1} characters")]
        public string Street { get; set; }

        
        [StringLength(120, MinimumLength = 3, ErrorMessage = " {0} size should be between {2} and {1} characters")]
        public string Complement { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [StringLength(120, MinimumLength = 3, ErrorMessage = " {0} size should be between {2} and {1} characters")]
        public string District { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [StringLength(120, MinimumLength = 3, ErrorMessage = " {0} size should be between {2} and {1} characters")]
        public string City { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [StringLength(120, MinimumLength = 2, ErrorMessage = " {0} size should be between {2} and {1} characters")]
        public string State { get; set; }

        [HiddenInput]
        public Guid ProviderId { get; set; }
    }
}