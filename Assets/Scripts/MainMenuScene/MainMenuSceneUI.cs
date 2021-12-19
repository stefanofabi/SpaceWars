using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuSceneUI : MonoBehaviour
{
    public CanvasManager canvasManager = null;
    
    public void Awake()
    {
        Button playMenuButton = GameObject.Find("PlayButton").GetComponent<Button>();
        playMenuButton.onClick.AddListener(playButton);

        Button exitMenuButton = GameObject.Find("ExitButton").GetComponent<Button>();
        exitMenuButton.onClick.AddListener(exitButton);

        canvasManager = GameObject.FindGameObjectWithTag("CanvasManager").GetComponent<CanvasManager>();
    }

    void playButton()
    {
        GameController.SetScoreToCero();
        Loader.Load(Loader.Scene.SpaceWars);
    }

    void exitButton()
    {
        Loader.Load(Loader.Scene.LoginScreen);
    }
    
    public void rankingButton()
    {
        canvasManager.activarRankingCanvas();
        canvasManager.desactivarMainCanvas();
    }
}
