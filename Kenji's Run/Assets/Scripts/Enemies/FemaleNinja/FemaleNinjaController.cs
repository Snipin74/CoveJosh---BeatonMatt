using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FemaleNinjaController : MonoBehaviour {

    public float moveSpeed;
    public bool moveRight;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatIsWall;
    private bool hittingWall;

    private bool notAtEdge;
    public Transform EdgeCheck;
    private Rigidbody2D myRidgidBody; // Player's RidgidBody
    private Animator myAnimator;
    private GameObject myBoss;

    public bool IsAttacking = false;
    public GameObject ninjaStar;

    BossHealthManager healthManager;


    public ObjectPooler theObjectPool;

    // Use this for initialization
    void Start()
    {
        healthManager = gameObject.GetComponent<BossHealthManager>();
        myRidgidBody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myBoss = GetComponent<GameObject>();

    }

    // Update is called once per frame
    void Update()
    {

        hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);
        notAtEdge = Physics2D.OverlapCircle(EdgeCheck.position, wallCheckRadius, whatIsWall);

        if (hittingWall || !notAtEdge)
        {
            moveRight = !moveRight;
        }

        if (moveRight)
        {
            transform.localScale = new Vector3(-0.64f, 0.5f, transform.localScale.z);
            myRidgidBody.velocity = new Vector2(moveSpeed, myRidgidBody.velocity.y);

        }
        else
        {
            transform.localScale = new Vector3(0.64f, 0.5f, transform.localScale.z);
            myRidgidBody.velocity = new Vector2(-moveSpeed, myRidgidBody.velocity.y);
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
        if (collision.tag == "Sword")
        {
            IsAttacking = true;
            if (healthManager)
                healthManager.applyDamage(1);
        }

        if (collision.tag == "Ninja Star")
        {
            if (healthManager)
                healthManager.applyDamage(1);
        }
     
    }
}

