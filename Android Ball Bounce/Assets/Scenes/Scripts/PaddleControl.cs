using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControl : MonoBehaviour
{

    Rigidbody2D rb;
    public float moveSpeed;
    public GameObject paddle; //in unity set the paddle sprite to refer to this variable
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void FixedUpdate() //FixedUpdate is a method that is continuously called by Unity when the game is running
    {
        TouchMove();
    }

    void TouchMove()
    {
        if (Input.GetMouseButton(0)) //We are detecting if the screen on an Android device has been touched or on PC if the left mouse button has been clicked
        {
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // getting the position of the touch
            Vector2 paddlePos = paddle.transform.position; //getting the x, y, z position of the paddle                                                                       

            if(touchPos.x < paddlePos.x - .5)// move left
            {
                rb.velocity = Vector2.left * moveSpeed;
            }
            else if(touchPos.x > paddlePos.x + .5) //move right
            {
                rb.velocity = Vector2.right * moveSpeed;
            }
           else
            {
                rb.velocity = Vector2.zero;
            }
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
