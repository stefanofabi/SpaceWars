using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite; 
using UnityEngine.UI;

public class UserHandler : DBConnector, UserInterface
{   
    public bool createUser(string name, string password) 
    {
        this._query = "INSERT INTO users (name, password) VALUES ('"+name+"', '"+password+"')";
        _command = _conexion.CreateCommand();
        _command.CommandText = _query;
        
        try 
        {
            _reader = _command.ExecuteReader();
        } catch (SqliteException exception) {
            Debug.Log(exception.ToString());
        }

        return _reader.RecordsAffected > 0 ? true : false;
    }

    public void ReadRegisterInput() 
    {
        Debug.Log("Clicked Register Button");

        dbConnect("URI=file:"+Application.dataPath+"/DB/spacewars.db");

        string name = GameObject.FindGameObjectWithTag("PlayerNameText").GetComponent<UnityEngine.UI.Text>().text;
        string password = GameObject.FindGameObjectWithTag("PlayerPasswordText").GetComponent<UnityEngine.UI.Text>().text;

        if (createUser(name, password)) 
        {
            Loader.Load(Loader.Scene.MainMenu);
            Debug.Log("Se creo el usuario "+name+" existosamente");
        } else 
        {
            Debug.Log("Hubo un error al insertar un nuevo usuario");
        }

        dbDisconnect();
    }
}
