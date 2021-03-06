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
        origin = GameObject.FindGameObjectWithTag("EnemySpawner").GetComponent<Transform>();
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0.0f, interval);
    }

    void Spawn()
    {
        if (origin == null) {
            Debug.Log("No hay origen");
            return;
                }
        else {

            //Vector3 spawnPosition = origin.position + Random.onUnitSphere * maxRadius;
            Vector3 spawnPosition = origin.position;
            Vector3 aux = new Vector3(1,0,0);
            aux = aux * Random.value * maxRadius;
            spawnPosition = spawnPosition + aux;
            //spawnPosition.x = spawnPosition.x * Random.value * maxRadius;
            spawnPosition = new Vector3(spawnPosition.x, 0.0f, spawnPosition.z);

            Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
