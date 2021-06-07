using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePointOnDestruction : MonoBehaviour
{
    public int scorePoints = 200;

    void OnDestroy()
    {
        GameController.score += scorePoints;    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
