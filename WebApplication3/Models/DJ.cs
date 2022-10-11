using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class DJ
    {
        [Key]
        public int DJID { get; set; }
        public string StageName { get; set; }
    }
}
