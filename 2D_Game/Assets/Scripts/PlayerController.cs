using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{

// Player movement variables
    public float moveSpeed; 
    public float jumpHeight;
        // Player grounded variables
    private bool grounded;



    // Start is called before the first frame update
    void Start() {
        // Default to true
        grounded = true;

        }

       // this && (and) that
       // this || (or) that
       // !Not this 

    // Update is called once per frame
    void Update() {
        // Moves player Left and Right
        if(Input.GetKeyDown(KeyCode.D)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

        }
        if(Input.GetKeyDown(KeyCode.A)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

// Player jump
        else if(Input.GetKeyDown(KeyCode.W)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
        }


    }
}
