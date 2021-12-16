using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite; 
using UnityEngine.UI;

public class UserHandler : DBConnector, UserInterface
{   
    public  bool createUser(string name, string password) 
    {
        this._query = "INSERT INTO users (name, password) VALUES ('"+name+"', '"+password+"')";
        Debug.Log("Se inserto : " + name + password);
        _command = _connection.CreateCommand();
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
        
        dbConnect("spacewars.db");

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

    public bool loginUser(string name, string pass)
    {
        bool resultado = false;
        this._query = "SELECT id,name, password FROM users WHERE name='" + name + "' AND password = '" + pass+"' LIMIT 1";
        
        _command = _connection.CreateCommand();
        _command.CommandText = _query;

        try
        {
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                string userName = _reader.GetString(1);
                string passw = _reader.GetString(2);
                Estado.idUsuario = _reader.GetInt32(0);
                resultado = true;
                Debug.Log("SE LOGUEO USUARIO =" + userName + "CONTRASEÑA =" + passw);
            }
            else
            {
                Debug.Log("Contraseña Incorrecta");
            }
        }
        catch (SqliteException exception)
        {
            Debug.Log(exception.ToString());
        }

        return resultado;
    }

    public void ReadLogInInput()
    {
        Debug.Log("Clicked LogIn Button");

        dbConnect("spacewars.db");

        string name = GameObject.FindGameObjectWithTag("PlayerNameText").GetComponent<UnityEngine.UI.Text>().text;
        string password = GameObject.FindGameObjectWithTag("PlayerPasswordText").GetComponent<UnityEngine.UI.Text>().text;

        if (loginUser(name, password))
        {
            Loader.Load(Loader.Scene.MainMenu);
            Debug.Log("Se Logueo el usuario " + name + " existosamente");
        }
        else
        {
            Debug.Log("Hubo un error al Loguear un usuario");
        }

        dbDisconnect();
    }

    public void ReadScoreInput(int id, int score)
    {
        dbConnect("spacewars.db");
        cargarScore(id, score);
        dbDisconnect();
    }
    
    public bool cargarScore(int id, int score)
    {
        this._query = "INSERT INTO scores (date, user_id, score) VALUES (DATE('now'), '" + id + "' , " + score + ")";
        Debug.Log("Se registro el puntaje : " + score);
        _command = _connection.CreateCommand();
        _command.CommandText = _query;

        try
        {
            _reader = _command.ExecuteReader();
        }
        catch (SqliteException exception)
        {
            Debug.Log(exception.ToString());
        }
        return _reader.RecordsAffected > 0 ? true : false;
    }
}
