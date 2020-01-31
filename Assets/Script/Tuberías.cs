using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tuberías : MonoBehaviour
{
    public float speed = 5f;
    private Transform myPosotion;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", 6f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + speed * Time.deltaTime * Vector3.left;
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
