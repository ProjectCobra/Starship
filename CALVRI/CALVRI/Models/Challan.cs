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
    public class challan
    {
        [BsonId]
        public ObjectId id { get; set; }
        public DateTime DateofViolation { get; set; }
        public string PlaceofViolation { get; set; }
        public string ViolationType { get; set; }
        public ulong ViolationAct { get; set; }
        public ulong AmountDue { get; set; }
        public string WardenName { get; set; }
        public string VReg { get; set; }
        public string VMake { get; set; }
        public Boolean PaidC { get; set; }
    }
}