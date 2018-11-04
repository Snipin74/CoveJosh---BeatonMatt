using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyStar : MonoBehaviour {

    public float speed;
    public float rotationSpeed;
    public PlayerController thePlayer;
    private Rigidbody2D myRigidbody2D;
    private GameManager theGameManager;
    private HealthManager theHealthHandler;

    // Use this for initialization
    void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
        theGameManager = FindObjectOfType<GameManager>();
        myRigidbody2D = GetComponent<Rigidbody2D>();
        theHealthHandler = FindObjectOfType<HealthManager>();

        if (thePlayer.transform.position.x < transform.position.x)
        {
            speed = -speed;
            rotationSpeed = -rotationSpeed;
        }
	}
	
	// Update is called once per frame
	void Update () {
        myRigidbody2D.velocity = new Vector2(speed, myRigidbody2D.velocity.y);
        myRigidbody2D.angularVelocity = rotationSpeed;
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
           theHealthHandler.health -= 1f;
            theGameManager.Respawn();
            Destroy(gameObject);
        }
    }
}
