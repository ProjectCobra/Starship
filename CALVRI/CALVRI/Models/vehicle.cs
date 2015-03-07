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
    public class vehicle
    {
        [BsonId]
        public ObjectId id { get; set; }
        public string Vmake { get; set; }
        public string Vcolor { get; set; }
        public string VReg { get; set; }
        public string EngineNo { get; set; }
        public ulong ChasisNo { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime RTDate { get; set; }
        public Boolean PaidRT { get; set; }
    }
}