using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CALVRI.Models
{
    public class CNIC
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]

        [Display(Name = "CNICNumber")]
        public int CNICNo { get; set; }


        //[Display(Name = "CNIC")]
        //public int CNICnum { get; set; }
        //[Display(Name = "CNICNumber")]
        //public int CNICNo { get; set; }

        [Display(Name = "CNICNumber")]
        public int CNICnum { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }

        [Required]
        [Display(Name = "Place of Birth")]
        public string Birthplace { get; set; }

        [Required]
        [Display(Name = "Driving License Number")]
        public int DLicense { get; set; }

        [Required]
        [Display(Name = "License expiry")]
        public DateTime EDLicense { get; set; }

        [Required]
        [Display(Name = "Vehicle Registration")]
        public string VReg { get; set; }

        [Required]
        [Display(Name = "Vehicle Make")]
        public string Vmake { get; set; }

        [Required]
        [Display(Name = "Vehicle Color")]
        public string Vcolor { get; set; }

        [Required]
        [Display(Name = "Road Tax paid upto" )]
        public DateTime RTDate { get; set; }

    }
}