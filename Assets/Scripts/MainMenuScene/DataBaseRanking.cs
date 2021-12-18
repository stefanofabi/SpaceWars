using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using UnityEngine.UI;


public class DataBaseRanking : DBConnector
{
    public Text ScoreText = null;
    public void CargarScoreDB()
    {
        string resultado = "";
        this._query = "SELECT name,date,MAX(score) as score FROM scores INNER JOIN users on users.id = scores.user_id GROUP BY name, date ORDER BY score DESC ";

        _command = _connection.CreateCommand();
        _command.CommandText = _query;

        try
        {
            _reader = _command.ExecuteReader();
            while (_reader.Read())
            {
                string userName = _reader.GetString(0);
                string date = _reader.GetString(1);
                int score = _reader.GetInt32(2);
                resultado += userName + "     " +date + "     "+ score +"\n";
                //Debug.Log("EL USUARIO =" + userName + "TIENE ESTE SCORE =" + score);
            }
            ScoreText.text = resultado;
        }
        catch (SqliteException exception)
        {
            Debug.Log(exception.ToString());
        }
    }

    public void CargarScores()
    {
        Debug.Log("Clicked Ranking Button");

        dbConnect("spacewars.db");
        CargarScoreDB();
        dbDisconnect();
    }
}
