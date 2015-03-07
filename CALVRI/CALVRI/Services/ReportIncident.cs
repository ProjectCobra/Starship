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

namespace CALVRI.Services
{
    public class ReportIncident
    {
        private readonly MongoHelper<ReportIncident> _alert;

        //public ReportIncident()
        //{
        //    _alert = new MongoHelper();
        //}

        //public void AddIncident(Incident alert)
        //{
        //    _alert.Collection.Save(alert);
        //}

        //public IList<Incident> GetAllIncidents()
        //{
        //    //return _alert.Collection.FindAll().SetSortOrder(SortBy.Descending("DateofIncident")).ToList();
        //    ;
            
        //}

        //public Incident GetIncident(ObjectId id)
        //{
        //    var alert = _alert.Collection.Find(Query.EQ("_id", id)).Single();
        //    return alert;
        //}

    }
}