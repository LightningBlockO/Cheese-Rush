using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCheeseSpawner : MonoBehaviour
{
    public GameObject redCheese;
    public Transform spawnPoint;
    public float maxX;
    public float maxZ;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCheese", 0f, 8f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCheese()
    {
        float randomX = Random.Range(-maxX,maxX);
        float randomZ = Random.Range(-maxZ,maxZ);
        Vector3 randomSpawnPos = new Vector3(randomX, 1f, randomZ);
        Instantiate(redCheese, randomSpawnPos, Quaternion.identity);
    }
}
