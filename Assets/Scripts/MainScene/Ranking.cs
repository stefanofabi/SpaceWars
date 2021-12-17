using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;

public class Ranking : MonoBehaviour
{
    public CanvasManager canvasManager = null;
    private void Awake()
    {
        canvasManager = GameObject.FindGameObjectWithTag("CanvasManager").GetComponent<CanvasManager>();
    }
    public void backButton()
    {
        canvasManager.desactivarRankingCanvas();
        canvasManager.activarMainCanvas();
        //GameObject.FindGameObjectWithTag("Canvas_Ranking").SetActive(false);
        //GameObject.FindGameObjectWithTag("MainCanvas").SetActive(true);
    }
}
