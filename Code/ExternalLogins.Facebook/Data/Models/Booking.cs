using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ExternalLogins.Facebook.Data.Models
{
    // NB Urgently replace with mapped viewmodel!
    public class Booking
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        public DateTime Start { get; set; }

        public DateTime? End { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(200)]
        public string Description { get; set; }
    }
}
