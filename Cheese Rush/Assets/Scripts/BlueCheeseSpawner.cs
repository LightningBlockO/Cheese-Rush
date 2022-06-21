using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCheeseSpawner : MonoBehaviour
{
    public GameObject blueCheese;
    public Transform spawnPoint;
    public float maxX;
    public float maxZ;

    void Start()
    {
        InvokeRepeating("SpawnCheese", 0f, 2.5f);
    }
    void SpawnCheese()
    {
        float randomX = Random.Range(-maxX,maxX);
        float randomZ = Random.Range(-maxZ,maxZ);
        Vector3 randomSpawnPos = new Vector3(randomX, 1f, randomZ);
        Instantiate(blueCheese, randomSpawnPos, Quaternion.identity);
    }
}
