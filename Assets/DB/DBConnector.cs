using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;

public class DBConnector : MonoBehaviour
{
    protected SqliteConnection _conexion;
    protected SqliteCommand _command;
    protected SqliteDataReader _reader;

    protected string _query;
    
    public void dbConnect(string dbname) 
    {
        _conexion = new SqliteConnection(dbname);
        _conexion.Open();
    }

    public void dbDisconnect() 
    {
        if (_reader != null)
            _reader.Close(); 
        
        _reader = null;
        _command = null;

        if (_conexion != null) 
            _conexion.Close();
        
        _conexion = null;
    }

}
