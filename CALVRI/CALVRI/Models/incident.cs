using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace CALVRI.Models
{
    [BsonIgnoreExtraElements]
    public class incident
    {
        [ScaffoldColumn(false)]
        [BsonId]
        public ObjectId IncidentId { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        public DateTime DateofIncident { get; set; }

        [Required]
        public string PlaceofIncident { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        public string IncidentType { get; set; }

        [Required]
        public string IncidentDescription { get; set; }
    }
}