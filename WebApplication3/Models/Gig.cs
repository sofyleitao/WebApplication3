using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Gig
    {
        [Key]
        public int GigID { get; set; }
        [ForeignKey("DJ")]
        public int DJID { get; set; }
        [ForeignKey("Venue")]
        public int VenueID { get; set; }
        public DJ DJ { get; set; }
        public Venue Venue { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DataType(DataType.Time)]
        public TimeSpan Time { get; set; }
    }
}
