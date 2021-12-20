using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public static float damage = 100.0f;
    public float lifetime = 2.0f;

    void OnEnable()
    {
        CancelInvoke();
        Invoke("Die", lifetime);
    }

    void OnTriggerEnter(Collider col)
    {
        Health health = col.gameObject.GetComponent<Health>();
        if (health == null)
            return;
        health.healthPoints -= damage;
        Invoke("Die", 0.0f);
    }

    void Die()
    {
        gameObject.SetActive(false);
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
