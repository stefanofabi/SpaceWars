using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screens : MonoBehaviour
{
    public GameObject Canvas_Insert, Canvas_Search, Canvas_Update, Canvas_Delete;
    // Start is called before the first frame update
    void Start()
    {
        Canvas_Insert.SetActive(true);
        Canvas_Delete.SetActive(false);
        Canvas_Search.SetActive(false);
        Canvas_Update.SetActive(false);

    }
    public void insert()
    {
        Canvas_Insert.SetActive(true);
        Canvas_Delete.SetActive(false);
        Canvas_Search.SetActive(false);
        Canvas_Update.SetActive(false);
    }
    public void Delete()
    {
        Canvas_Insert.SetActive(false);
        Canvas_Delete.SetActive(true);
        Canvas_Search.SetActive(false);
        Canvas_Update.SetActive(false);
    }
    public void Search()
    {
        Canvas_Insert.SetActive(false);
        Canvas_Delete.SetActive(false);
        Canvas_Search.SetActive(true);
        Canvas_Update.SetActive(false);
    }

    public void Updates()
    {
        Canvas_Insert.SetActive(false);
        Canvas_Delete.SetActive(false);
        Canvas_Search.SetActive(false);
        Canvas_Update.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {

    }
}