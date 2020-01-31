using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefabTuberias;
    public float randomRange = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnTuberias", 0f, 2.54f);
    }

    void SpawnTuberias()
    {
        Vector3 spawnPosition;
        spawnPosition.x = transform.position.x;
        spawnPosition.y = Random.Range(3.5f, -3.5f);
        spawnPosition.z = transform.position.z;
        Instantiate(prefabTuberias, spawnPosition , Quaternion.identity);
    }

}
