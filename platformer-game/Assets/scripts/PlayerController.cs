using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Movement Variables
    Rigidbody2D rb; //create reference for rigidbody bc jump requires physics
    public float jumpForce; //the force that will be added to the vertical component of player's velocity
    public float speed;
    //animation values
    Animator anim;  
    public bool moving = false;
 


    //Ground Check Variables
    public LayerMask groundLayer; //layer information 
    public Transform groundCheck; //Transform gives information on everything in the transform tab in unity
    public bool isGrounded; //bool that determines whether the player is on the ground

    SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, .5f, groundLayer); //checks if the groundCheck and groundLayer are overlapping within the radius of a circle.
                                                                                      //This function also returns a false or true value which is why you could equal it to a bool
                                                                                      //Formated in (first thing being checked, radius of circle, second thing being checkedww
        Vector3 newPosition = transform.position;
        Vector3 newScale = transform.localScale;
        float currentScale = Mathf.Abs(transform.localScale.x);

        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            newPosition.x -= speed;
            newScale.x = -currentScale;
           moving = true;
        }

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            newPosition.x += speed;
            newScale.x = currentScale;
            moving = true; 
        }

        if ((Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.UpArrow)) && isGrounded == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        if (Input.GetKeyUp("a") || Input.GetKeyUp("d") || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            moving = false; 
        }
        anim.SetBool("isMoving", moving);
        transform.position = newPosition;
        transform.localScale = newScale;
    }
}