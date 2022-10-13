using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject building;
    public Transform spawnPoint;
    public float maxX;
    public float maxZ;

    void Start()
    {
        InvokeRepeating("SpawnBuilding", 0f, 0.5f);
    }
    void SpawnBuilding()
    {
        float randomX = Random.Range(-maxX + transform.position.x, maxX + transform.position.x);
        float randomZ = Random.Range(-maxZ + transform.position.z, maxZ + transform.position.z);
        Vector3 randomSpawnPos = new Vector3(randomX, 1.35f, randomZ);
        Instantiate(building, randomSpawnPos, Quaternion.identity);
    }
}
