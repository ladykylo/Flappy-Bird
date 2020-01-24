using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pollo : MonoBehaviour
{
    [Range(3,8)]
    public float speed = 5f;
    private Rigidbody2D myRigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidBody2D.velocity = Vector2.up * speed;
        }
    }
}
