using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranking : MonoBehaviour
{
    public void backButton()
    {
        GameObject.FindGameObjectWithTag("Canvas_Ranking").SetActive(false);
        GameObject.FindGameObjectWithTag("MainCanvas").SetActive(true);
    }
}
