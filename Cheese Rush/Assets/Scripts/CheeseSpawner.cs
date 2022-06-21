using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseSpawner : MonoBehaviour
{
    public GameObject cheese;
    public Transform spawnPoint;
    public float maxX;
    public float maxZ;

    void Start()
    {
        InvokeRepeating("SpawnCheese", 0f, 0.35f);
    }
    void SpawnCheese()
    {
        float randomX = Random.Range(-maxX,maxX);
        float randomZ = Random.Range(-maxZ,maxZ);
        Vector3 randomSpawnPos = new Vector3(randomX, 1f, randomZ);
        Instantiate(cheese, randomSpawnPos, Quaternion.identity);
    }
}
