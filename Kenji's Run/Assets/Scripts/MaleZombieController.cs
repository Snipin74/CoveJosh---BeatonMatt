using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaleZombieController : MonoBehaviour {

    public float moveSpeed;
    public bool IsAttacking;
    public float stopDistance;
    private Rigidbody2D myRidgidBody; 
    private Animator myAnimator;
    private Transform myPlayer;
    private SpriteRenderer spriteRenderer;
   

    // public Transform wallCheck;
    // public float wallCheckRadius;
    // public LayerMask whatIsWall;
    // private bool hittingWall;
    // private bool notAtEdge;
    //public Transform EdgeCheck;


    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        myRidgidBody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        IsAttacking = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, myPlayer.position) < stopDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, myPlayer.position, moveSpeed * Time.deltaTime);
            myAnimator.SetFloat("Speed", moveSpeed);

            if (myPlayer.transform.position.x < transform.position.x)
            {
                spriteRenderer.flipX = true;
            }
            else
            {
                spriteRenderer.flipX = false;
            }
        }
        else
        {
            myAnimator.SetFloat("Speed", 0.0f);
        }

        if (IsAttacking)
        {
            myAnimator.SetBool("Attack", true);
            myRidgidBody.velocity = Vector2.zero;
        }
        else
            myAnimator.SetBool("Attack", false);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            IsAttacking = true;
        }

        if (collision.tag == "Sword")
        {
            Destroy(gameObject);
        }

        if( collision.tag == "Ninja Star")
        {
            Destroy(gameObject);
        } 
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        IsAttacking = false;
    }

}