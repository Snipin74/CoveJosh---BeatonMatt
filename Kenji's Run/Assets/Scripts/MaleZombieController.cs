﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaleZombieController : MonoBehaviour {

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
    private GameObject myZombie;

    public bool IsAttacking = false;
    public GameObject ninjaStar;
    public SpriteRenderer sr;

    // Player Chasing AI

    private Transform myPlayer;
    public float stopDistance;


    // Use this for initialization
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        myRidgidBody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
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
                sr.flipX = true;
            }
            else
            {
                sr.flipX = false;
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