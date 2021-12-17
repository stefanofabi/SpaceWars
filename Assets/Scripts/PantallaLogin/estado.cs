using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estado : MonoBehaviour
{
    public static Estado estado;
    public static int idUsuario;
    public bool sonidoOn = true;

    private void Awake()
    {
        if (estado == null)
        {
            estado=this;
            DontDestroyOnLoad(gameObject);
        }else if (estado != this)
        {
            Destroy(gameObject);
        }
    }
    public void cambiarSonido()
    {
        sonidoOn = !sonidoOn;
    }

}
