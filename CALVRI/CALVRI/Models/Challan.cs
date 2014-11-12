using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CALVRI.Models
{
    public class Challan
    {
        [Required]
        [Display(Name = "ID")]
        public int ID { get; set; }


    }
}