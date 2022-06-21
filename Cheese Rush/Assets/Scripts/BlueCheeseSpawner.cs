using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCheeseSpawner : MonoBehaviour
{
    public GameObject blueCheese;
    public Transform spawnPoint;
    public float maxX;
    public float maxZ;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCheese", 0f, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            blueCheese.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            blueCheese.SetActive(true);
        }
    }

    void SpawnCheese()
    {
        float randomX = Random.Range(-maxX,maxX);
        float randomZ = Random.Range(-maxZ,maxZ);
        Vector3 randomSpawnPos = new Vector3(randomX, 1f, randomZ);
        Instantiate(blueCheese, randomSpawnPos, Quaternion.identity);
    }
}
