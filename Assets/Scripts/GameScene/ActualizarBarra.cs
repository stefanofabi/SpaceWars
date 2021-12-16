using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualizarBarra : MonoBehaviour
{
    Health health = null;
    BarraVida barraVida = null;
    // Start is called before the first frame update
    void Start()
    {
        health = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        barraVida = GameObject.FindGameObjectWithTag("Objetobarra").GetComponent<BarraVida>();
    }

    // Update is called once per frame
    void Update()
    {
        barraVida.SetHealth(health.healthPoints);
    }
}
