using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepByStepMovement : MonoBehaviour
{
    private Transform theTransform = null;
    public float step = 10.0f;
    // Start is called before the first frame update

    private void Awake()
    {
        theTransform = GetComponent<Transform>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        float coordenadaX = 0, coordenadaY = 0, coordenadaZ = 0;
        coordenadaX = theTransform.position.x;
        coordenadaY = theTransform.position.y;
        coordenadaZ = theTransform.position.z;
        
            theTransform.position.Set(coordenadaX+1.0f, coordenadaY, coordenadaZ);
    */
        theTransform.position += theTransform.right  ;
    }
}
