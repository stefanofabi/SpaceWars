using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSceneUI : MonoBehaviour
{ 
    
    public void Awake()
    {
        Button backToMainMenuButton = GameObject.Find("MainMenuButton").GetComponent<Button>();
        backToMainMenuButton.onClick.AddListener(backToMainMenu);      
    }

    void backToMainMenu()
    {
        Debug.Log("Click Main Menu");
        Loader.Load(Loader.Scene.MainMenu);
    }
}
