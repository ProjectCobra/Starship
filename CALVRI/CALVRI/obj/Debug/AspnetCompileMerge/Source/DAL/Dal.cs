using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CALVRI.Models;
using MongoDB.Driver;
using System.Configuration;

namespace CALVRI.DAL
{
    public class Dal : IDisposable
    {
        private MongoServer mongoServer = null;
        private bool disposed = false;

        // To do: update the connection string with the DNS name
        // or IP address of your server. 
        //For example, "mongodb://testlinux.cloudapp.net"
        private string connectionString = "mongodb://ubuntu:TR7464TOk5Oy@ec2-54-149-161-212.us-west-2.compute.amazonaws.com:27017";

        // This sample uses a database named "Tasks" and a 
        //collection named "TasksList".  The database and collection 
        //will be automatically created if they don't already exist.
        private string dbName = "calvridb";
        private string collection_CNIC = "CNICHolder";
        private string collection_TWarden = "TrafficWarden";

        // Default constructor.        
        public Dal()
        {
        }

        // Gets all Task items from the MongoDB server.        
        public List<CNIC> GetProfile()
        {
            try
            {
                MongoCollection<CNIC> collection = GetTasksCollection();
                return collection.FindAll().ToList<CNIC>();
            }
            catch (MongoConnectionException)
            {
                return new List<CNIC>();
            }
        }

        // Creates a Task and inserts it into the collection in MongoDB.
        public void CreateTask(CNIC CNIC_profile)
        {
            MongoCollection<CNIC> collection = GetTasksCollectionForEdit();
            try
            {
                collection.Insert(CNIC_profile, SafeMode.True);
            }
            catch (MongoCommandException ex)
            {
                string msg = ex.Message;
            }
        }

        private MongoCollection<CNIC> GetTasksCollection()
        {
            MongoServer server = MongoServer.Create(connectionString);
            MongoDatabase database = server[dbName];
            MongoCollection<CNIC> todoTaskCollection = database.GetCollection<CNIC>(collection_CNIC);
            return todoTaskCollection;
        }

        private MongoCollection<CNIC> GetTasksCollectionForEdit()
        {
            MongoServer server = MongoServer.Create(connectionString);
            MongoDatabase database = server[dbName];
            MongoCollection<CNIC> todoTaskCollection = database.GetCollection<CNIC>(collection_CNIC);
            return todoTaskCollection;
        }

        # region IDisposable

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (mongoServer != null)
                    {
                        this.mongoServer.Disconnect();
                    }
                }
            }

            this.disposed = true;
        }

        # endregion
    }
}