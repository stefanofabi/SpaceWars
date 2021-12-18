using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public GameObject MainCanvas = null;
    public GameObject RankingCanvas = null;
    // Start is called before the first frame update
    private void Awake()
    {
        MainCanvas = GameObject.FindGameObjectWithTag("MainCanvas");
        RankingCanvas = GameObject.FindGameObjectWithTag("CanvasRanking");
        RankingCanvas.SetActive(false);

    }

    public void activarMainCanvas()
    {
        MainCanvas.SetActive(true);
    }
    public void desactivarMainCanvas()
    {
        MainCanvas.SetActive(false);
    }
    public void activarRankingCanvas()
    {
        RankingCanvas.SetActive(true);
    }
    public void desactivarRankingCanvas()
    {
        RankingCanvas.SetActive(false);
    }
}
