using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public Slider slider;
    public void SetHealth(float health)
    {
        //Debug.Log("Se actualizo el valor de la vida en: "+ health);
        slider.value = (int) health;

    }
}
