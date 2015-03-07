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
    public class twarden
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public ulong CNICNo { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string DutyPlace { get; set; }
        public List<challan> Issued { get; set; }
    }
}