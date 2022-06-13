using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject cheese;
    public Transform spawnPoint;
    public float maxX;
    public float maxZ;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCheese", 0f, 0.35f);
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
        Instantiate(cheese, randomSpawnPos, Quaternion.identity);
    }
}
