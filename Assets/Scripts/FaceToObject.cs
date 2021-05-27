using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceToObject : MonoBehaviour
{

    public Transform objectToFollow = null;
    
    // si el enemigo esta muy lejos del personaje no lo seguimos, solo si esta muy cerca
    public bool followPlayer = false;

    private Transform theTransform = null;

    void Awake() {
        theTransform = GetComponent<Transform> ();

        // si no tengo que seguir al jugador finalizo este metodo
        if (!followPlayer) {
            return;
        }

        GameObject thePlayer = GameObject.FindGameObjectWithTag("Player");

        // si creamos un enemigo y el personaje ya fue destruido seria null
        if (thePlayer != null) {
            objectToFollow = thePlayer.GetComponent<Transform> ();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (objectToFollow == null) {
            return;
        }

        // aca obtiene el vector entre la nave y el enemigo
        Vector3 directionToFollow = theTransform.position - objectToFollow.position;

        if (directionToFollow != Vector3.zero) {
            theTransform.localRotation = Quaternion.LookRotation (directionToFollow.normalized, Vector3.up);
        }
    }
}
