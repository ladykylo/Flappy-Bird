using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pollo : MonoBehaviour
{
    [Range(3,8)]
    public float speed = 5f;
    public Text scoreText;
    public Text highScoreText;
    public Transform lookAt;

    private Rigidbody2D myRigidBody2D;
    private int score = 0;
    private int highScore = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();

        highScore = PlayerPrefs.GetInt("highScore");
        highScoreText.text = highScore + "";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void Update()                               // Esto es para que el pollo mire hacia el sitio donde se ha acordado(en este caso el spwan de tuberías)
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidBody2D.velocity = Vector2.up * speed;
        }

        Vector3 targetPosition = lookAt.position;
        targetPosition.x = targetPosition.x - transform.position.x;
        targetPosition.y = targetPosition.y - transform.position.y;

        float angle = Mathf.Atan2(targetPosition.y, targetPosition.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }

    private void OnCollisionEnter2D(Collision2D collision)   // Para funcionar se necesita que los objetos que participan tenga 2 colliders y un rigibody. Esta es la muerte.
    {
        string sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);

        if(PlayerPrefs.GetInt("highScore") < score)
        { 
        PlayerPrefs.SetInt("highScore", score);                 // PlayerPrefs sirve para guardar cosas, como por ejemplo los pts.
        }
    }


    private void OnTriggerEnter2D(Collider2D other)        // Suma de los puntos.
    {
        score++;
        scoreText.text = score.ToString();
    }

}
