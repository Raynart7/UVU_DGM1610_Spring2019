using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{

// Player movement variables
    public float moveSpeed; 
    public float jumpHeight;
    private bool doubleJump;

// Player grounded variables
    private bool grounded;
    public Transform groundCheck;
    public float groundCheckRadius; 
    public LayerMask whatIsGround;

    public Animator animator;
    private float moveVelocity;





    // Start is called before the first frame update
    void Start() {
         animator = GetComponent<Animator>();
         animator.SetBool("IsWalking" ,false);
         animator.SetBool("IsJumping" ,false);

    }

     void FixedUpdate(){
             grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
         }
 

    // Update is called once per frame
    void Update(){
        

        // Moves player Left and Right
        if(Input.GetKey(KeyCode.D)){
            //GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            moveVelocity = moveSpeed;
            animator.SetBool("IsWalking" ,true);
            transform.localScale = new Vector3(0.5f,0.5f,1f);

        }

        else if(Input.GetKeyUp (KeyCode.D)){
            animator.SetBool("IsWalking" ,false);
        }

        if(Input.GetKey(KeyCode.A)){
            //GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            moveVelocity = -moveSpeed;
            animator.SetBool("IsWalking" ,true);
            transform.localScale = new Vector3(-0.5f,0.5f,1f);
        }

        else if(Input.GetKeyUp (KeyCode.A)){
            animator.SetBool("IsWalking" ,false);

        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

        // Player jump
        if(Input.GetKeyDown(KeyCode.W) && grounded){
        Jump();

        }

        if(grounded){
            doubleJump = false;
            animator.SetBool("IsJumping" ,false);
        }

        if(Input.GetKeyDown (KeyCode.W) && !doubleJump && !grounded){
            Jump();
            doubleJump = true;

        }

        moveVelocity = 0f;

        }


        void Jump(){
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
            animator.SetBool("IsJumping" ,true);
        }
}

