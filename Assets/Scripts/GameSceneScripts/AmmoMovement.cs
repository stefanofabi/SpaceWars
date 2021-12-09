using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoMovement : MonoBehaviour
{
    private Transform theTransform = null;
    public float maxSpeed = 0.0f;

    void Awake()
    {
        theTransform = GetComponent<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // hacemos ir al enemigo hacia abajo
        theTransform.position += theTransform.forward  * maxSpeed * Time.deltaTime;
    }
}