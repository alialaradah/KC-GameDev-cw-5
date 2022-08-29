using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class paddle : MonoBehaviour
{
    Rigidbody2D padle;
    float playerInput;
    public float speed;




    // Start is called before the first frame update
    void Start()
    {
        padle = GetComponent<Rigidbody2D>();
    }

    

    private void FixedUpdate()
    {
        move(); 
    }


     private void move()
    {
      playerInput = Input.GetAxis("Horizontal");
      padle.velocity = new Vector2(playerInput * speed, 0);    
    }
}
