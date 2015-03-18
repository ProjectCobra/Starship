using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace CALVRI.Models
{
    public class cnic
    {
        [BsonId]
        public ObjectId id { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public ulong CNICNo { get; set; }
        public ulong DLicense { get; set; }
        public DateTime DOB { get; set; }
        public String Birthplace { get; set; }
        public DateTime EDLicense { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime RenewalDate { get; set; }
        public string VehicleAuth { get; set; }
        public int TotalChallans { get; set; }
        public List<vehicle> Vehicle { get; set; }
        public List<challan> Challan { get; set; }
    }
}