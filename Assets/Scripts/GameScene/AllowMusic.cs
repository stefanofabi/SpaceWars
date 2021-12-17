using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllowMusic: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Estado state = GameObject.FindGameObjectWithTag("EstadoDeJuego").GetComponent<Estado>();
        if(!Estado.sonidoOn)
        {
            Debug.Log("Entro al if de allow music");
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.mute = true;
        }
    }
    
}
