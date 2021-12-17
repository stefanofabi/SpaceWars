using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuSceneUI : MonoBehaviour
{

    public void Awake()
    {
        Button playMenuButton = GameObject.Find("PlayButton").GetComponent<Button>();
        playMenuButton.onClick.AddListener(playButton);

        Button exitMenuButton = GameObject.Find("ExitButton").GetComponent<Button>();
        exitMenuButton.onClick.AddListener(exitButton);
    }

    void playButton()
    {
        GameController.SetScoreToCero();
        Loader.Load(Loader.Scene.SpaceWars);
    }

    void exitButton()
    {
        Application.Quit();
    }
    public void rankingButton()
    {
        GameObject.FindGameObjectWithTag("MainCanvas").SetActive(false);
        GameObject.FindGameObjectWithTag("CanvasRanking").SetActive(true);
    }
}
