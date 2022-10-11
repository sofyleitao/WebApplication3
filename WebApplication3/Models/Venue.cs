﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Venue
    {
        [Key]
        public int VenueID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
