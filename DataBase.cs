using UnityEngine;
public interface IDatabase : ITDB, IFDb, IVDb
    {
        void Connect();
        
        void Close();
    }

    public interface ITDB
    {
        void GetTables();
    }

    public interface IFDb
    {
        void GetFiles();
    }

    public interface IVDb
    {
        void GetViews();
    }

    public class DataBase : IDatabase
    {
        public void Connect()
        {
        }

        public void Close()
        {
            
        }

        public void GetTables()
        {
            Debug.Log("Get Tables");

        }

        public void GetFiles()
        {
            Debug.Log("Get Files");

        }
        public void GetViews()
        {
            Debug.Log("Get Views");
        }
    }
