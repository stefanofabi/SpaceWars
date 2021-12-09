using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;
public class GameSceneUI : MonoBehaviour
{ 
    public Button boton = null;
    public void Awake()
    {
        boton = GameObject.Find("MainMenuButton").GetComponent<Button>();
        if (boton != null)
        {
            boton.onClick.AddListener(volver);
        }
        else
        {
            Debug.Log("referencia de boton nula");
        }
    }

    void volver()
    {
        Debug.Log("Click Main Menu");
        Loader.Load(Loader.Scene.SpaceWars);
    }
}
