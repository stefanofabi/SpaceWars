using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    public float destroyTime = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Die", destroyTime);
    }

    void Die() {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
