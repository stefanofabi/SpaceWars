using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{

    // cantidad de daño del enemigo
    public float damagePoints = 10.0f;

    void OnTriggerStay(Collider otherCollider) {
        
        // obtengo la componente de vida de la nave
        Health health = otherCollider.gameObject.GetComponent<Health> ();

        // si colisiono con algo que no tiene vida no hago nada
        if (health == null) {
            return;
        }

        // resto vida a la nave 
        health.healthPoints -= damagePoints * Time.deltaTime;

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
