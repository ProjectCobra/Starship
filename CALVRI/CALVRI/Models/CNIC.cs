using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson;

namespace CALVRI.Models
{
    public class CNIC
    {
        [BsonId(IdGenerator = typeof(CombGuidGenerator))]
        public Guid Id { get; set; }

        [Required]
        [BsonElement("CNICNumber")]
        [Display(Name = "CNICNumber")]
        public int CNICNo { get; set; }

        [Required]
        [BsonElement("Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [BsonElement("DoB")]
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }

        [Required]
        [BsonElement("PlaceofBirth")]
        [Display(Name = "Place of Birth")]
        public string Birthplace { get; set; }

        [Required]
        [BsonElement("DrivingLicenseNumber")]
        [Display(Name = "Driving License Number")]
        public int DLicense { get; set; }

        [Required]
        [BsonElement("LicenseExpiry")]
        [Display(Name = "License expiry")]
        public DateTime EDLicense { get; set; }

        [Required]
        [BsonElement("VehicleRegistration")]
        [Display(Name = "Vehicle Registration")]
        public string VReg { get; set; }

        [Required]
        [BsonElement("VehicleMake")]
        [Display(Name = "Vehicle Make")]
        public string Vmake { get; set; }

        [Required]
        [BsonElement("VehicleColor")]
        [Display(Name = "Vehicle Color")]
        public string Vcolor { get; set; }

        [Required]
        [BsonElement("RoadTaxPaidUpto")]
        [Display(Name = "Road Tax paid upto" )]
        public DateTime RTDate { get; set; }

    }
}