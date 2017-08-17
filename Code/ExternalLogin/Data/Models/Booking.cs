using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ExternalLogins.Data.Models
{
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
