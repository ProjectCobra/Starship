using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

using CALVRI.Models;

namespace CALVRI.Models
{
    public class MongoHelper<T>
    {

        public object Getdb(string col)
        {
            Console.WriteLine("Connecting....");
            var connectionString = "mongodb://root:OqkVBsTKj6TK@54.149.225.22:27017";

            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            Console.WriteLine("GetServer");
            var database = server.GetDatabase("calvridb");
            Console.WriteLine("GetDB");
            var collection = database.GetCollection(col);
            Console.WriteLine("GetCollection");

            Console.WriteLine(collection.FindOne());
            //var col = collection.Find();
            //collection.Remove(query);

            return collection;
        }
        public IEnumerable<T> Getallprofiles(string col)
        {
            Console.WriteLine("Connecting....");
            var connectionString = "mongodb://root:OqkVBsTKj6TK@54.149.225.22:27017";

            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            Console.WriteLine("GetServer");
            MongoDatabase database = server.GetDatabase("calvridb");
            Console.WriteLine("GetDB");
            MongoCollection<T> collection = database.GetCollection<T>(col);
            Console.WriteLine("GetCollection");
            return collection.FindAll();
        }

        public T Getprofile(ulong cnic, string col)
        {
            Console.WriteLine("Connecting....");
            var connectionString = "mongodb://root:OqkVBsTKj6TK@54.149.225.22:27017";

            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            Console.WriteLine("GetServer");
            MongoDatabase database = server.GetDatabase("calvridb");
            Console.WriteLine("GetDB");
            MongoCollection<T> collection = database.GetCollection<T>(col);
            Console.WriteLine("GetCollection");

            var query = Query<cnic>.EQ(e => e.CNICNo, cnic);
            var entity = collection.FindOne(query);
            return entity;
        }
    }
}