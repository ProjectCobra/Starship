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
        private string connectionString = "mongodb://54.149.225.22:27017";

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
        public List<cnic> GetProfile()
        {
            try
            {
                MongoCollection<cnic> collection = GetTasksCollection();
                return collection.FindAll().ToList<cnic>();
            }
            catch (MongoConnectionException)
            {
                return new List<cnic>();
            }
        }

        // Gets all Task items from the MongoDB server.        
        public List<cnic> GetProfile(int CNICno, int DrivLic_no)
        {
            try
            {
                MongoCollection<cnic> collection = GetTasksCollection();
                return collection.FindAll().ToList<cnic>();
            }
            catch (MongoConnectionException)
            {
                return new List<cnic>();
            }
        }

        // Creates a Task and inserts it into the collection in MongoDB.
        public void CreateTask(cnic CNIC_profile)
        {
            MongoCollection<cnic> collection = GetTasksCollectionForEdit();
            try
            {
                collection.Insert(CNIC_profile, SafeMode.True);
            }
            catch (MongoCommandException ex)
            {
                string msg = ex.Message;
            }
        }

        private MongoCollection<cnic> GetTasksCollection()
        {
            MongoServer server = MongoServer.Create(connectionString);
            MongoDatabase database = server[dbName];
            MongoCollection<cnic> todoTaskCollection = database.GetCollection<cnic>(collection_CNIC);
            return todoTaskCollection;
        }

        private MongoCollection<cnic> GetProfileData(int CNICno, int DrivLic_no)
        {
            MongoServer server = MongoServer.Create(connectionString);
            MongoDatabase database = server[dbName];
            MongoCollection<cnic> CNICProfile = database.GetCollection<cnic>(collection_CNIC);
            return CNICProfile;
        }

        private MongoCollection<cnic> GetTasksCollectionForEdit()
        {
            MongoServer server = MongoServer.Create(connectionString);
            MongoDatabase database = server[dbName];
            MongoCollection<cnic> todoTaskCollection = database.GetCollection<cnic>(collection_CNIC);
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