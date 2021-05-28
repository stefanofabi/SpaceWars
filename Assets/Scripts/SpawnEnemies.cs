using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public float maxRadius = 1.0f;
    public float interval = 5.0f;
    public GameObject objectToSpawn = null;
    private Transform origin = null;

    void Awake() {
        origin = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0.0f, interval);
    }

    void Spawn()
    {
        if (origin == null)
            return;
        
        Vector3 spawnPosition = origin.position + Random.onUnitSphere * maxRadius;
        spawnPosition = new Vector3(spawnPosition.x, 0.0f, spawnPosition.z);
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
