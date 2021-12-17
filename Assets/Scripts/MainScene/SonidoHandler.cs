using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoHandler : MonoBehaviour
{
    public Estado state = null;
    // Start is called before the first frame update
    void Start()
    {
        state = GameObject.FindGameObjectWithTag("EstadoDeJuego").GetComponent<Estado>();
    }

    public void cambiarSonido()
    {
        state.cambiarSonido();
    }
}
