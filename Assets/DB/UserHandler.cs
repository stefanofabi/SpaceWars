using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite; 

public class UserHandler : DBConnector, UserInterface
{   
    public void createUser(string email, string password) 
    {
        this._query = "INSERT INTO users (email, password) VALUES ('"+email+"', '"+password+"')";
        _command = _conexion.CreateCommand();
        _command.CommandText = _query;

        try 
        {
            _reader = _command.ExecuteReader();
           
            if (_reader.RecordsAffected == 1)
                Debug.Log("Se creo el usuario "+email+" existosamente");
        } catch (SqliteException exception) {
            Debug.Log("Hubo un error al insertar un nuevo usuario");
            Debug.Log(exception.ToString());
        }
        
    }

    void Start() {
        dbConnect("URI=file:"+Application.dataPath+"/DB/spacewars.db");
        createUser("stefano12", "123456");
        dbDisconnect();
    }
}
