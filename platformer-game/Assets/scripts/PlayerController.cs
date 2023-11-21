using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlayerController : MonoBehaviour
{
    //Movement Variables
    Rigidbody2D rb; //create reference for rigidbody bc jump requires physics
    public float jumpForce; //the force that will be added to the vertical component of player's velocity
    public float speed;
<<<<<<< Updated upstream
=======
    //animation values
    Animator anim;  
    public bool moving = false;
    Vector2 startpos; 
 
>>>>>>> Stashed changes


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
<<<<<<< Updated upstream
=======
        anim = GetComponent<Animator>();
        startpos = transform.position;
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======
            moving = true;
>>>>>>> Stashed changes
        }

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            newPosition.x += speed;
            newScale.x = currentScale;
        }

        if ((Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.UpArrow)) && isGrounded == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }


        transform.position = newPosition;
        transform.localScale = newScale;

        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Spike"))
        {
            Die();
            Debug.Log("spikes ow");
        }
        if (collision.CompareTag("Finish"))
        {
            SceneManager.LoadScene(2);
        }
    }

    void Die()
    {
        Respawn();
    }
    void Respawn()
    {
        transform.position = startpos;
    }
  
}