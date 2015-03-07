using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using MongoDB.Driver;
using CALVRI.Models;
using MongoDB.Driver.Builders;
using MongoDB.Bson;
using System.Text.RegularExpressions;
using System.Web;
using System.Diagnostics;
using CALVRI.Models;

namespace CALVRI
{
    public class IssueChallan
    {
        private readonly MongoHelper<IssueChallan> _cnic;

        public IssueChallan()
        {
            _cnic = new MongoHelper<IssueChallan>();
        }

        //public void AddChallan(cnic violator, Challan challan)
        //{
        //    violator.Challan = new List<Challan>();
        //    _cnic.Collection.Update(Query.EQ("_id", violator.DLicense),
        //        Update.PushWrapped("Challan", challan).Inc("TotalChallans", 1));
        //    _cnic.Collection.Save(challan);
        //}

        //public IList<Challan> GetChallans(ObjectId violatorId, int skip, int limit, int totalChallans)
        //{
        //    var newChallans = GetTotalChallans(violatorId) - totalChallans;
        //    skip += newChallans;

        //    var violator = _cnic.Collection.Find(Query.EQ("_id", violatorId)).SetFields(Fields.Exclude("CNICNo", "Name", "DOB", "Birthplace", "DLicense", "EDLicense", "VReg", "Vmake", "Vcolor", "RTDate").Slice("Challan", -skip, limit)).Single();
        //    return violator.Challan.OrderByDescending(c => c.DateofViolation).ToList();
        //}

        //public int GetTotalChallans(ObjectId violatorId)
        //{
        //    var violator = _cnic.Collection.Find(Query.EQ("_id", violatorId)).SetFields(Fields.Include("TotalChallans")).Single();
        //    return violator.TotalChallans;
        //}
    }
}