using Mono.Data.Sqlite;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : DBConnector
{
    public static int score = 0;
    public string scorePrefix = string.Empty;
    public Text scoreText = null;
    public Text gameOverText = null;
    public static GameController gameController = null;

    public void Awake()
    {
        gameController = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        //  gameController.ship.gameObject.SetActive(false);
        gameController.gameOverText.gameObject.SetActive(false);

    }
    public static void GameOver()
    {
        if(gameController.gameOverText != null)
        {
            gameController.gameOverText.gameObject.SetActive(true);
            if (score > 0)
            {
                cargarScore();
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        if(scoreText != null)
        {
            scoreText.text = scorePrefix + score.ToString();
        }
    }

    public static void SetScoreToCero()
    {
        score = 0;
    }

    public static void cargarScore()
    {
        UserHandler handler = new UserHandler();
        handler.ReadScoreInput(Estado.idUsuario, score);
    }
}
