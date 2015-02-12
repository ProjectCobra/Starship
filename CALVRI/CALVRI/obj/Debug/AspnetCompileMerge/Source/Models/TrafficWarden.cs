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
    public class TrafficWarden
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
        [BsonElement("Username")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [BsonElement("Password")]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}