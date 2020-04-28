using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static Ball instance;
    Rigidbody2D rb;
    public float bounceForce;
    public bool gameStarted = false;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        rb = GetComponent<Rigidbody2D>();
        
       
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStarted)
        {
            StartBounce();
        }
    }

    void Bounce()
    {
        StartBounce();
    }
     void StartBounce() // this will make the ball move in a random direction
    {
        gameStarted = false;
        Vector2 randomDirection = new Vector2(Random.Range(-1, 1), 1);
        rb.AddForce(randomDirection * bounceForce, ForceMode2D.Impulse);
    }

     private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "FallCheck")
        {
            GameManager.instance.Restart();
            
        }else if(collision.gameObject.tag == "Paddle")
        {
            Counter.instance.ScoreUp();
        }


    }
}
