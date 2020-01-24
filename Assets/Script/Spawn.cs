using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefabTuberias;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnTuberias", 0f, 1f);
    }

    void SpawnTuberias()
    {
        Instantiate(prefabTuberias, transform.position, Quaternion.identity);
    }

}
