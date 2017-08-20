using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExternalLogins.Facebook.Data
{
    [Table("Booking")]
    public class BookingDataModel
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public string Comment { get; set; }
    }
}
