using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    private GameManager theGameManager;

	// Use this for initialization
	void Start () {

        theGameManager = FindObjectOfType<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            theGameManager.currentCheckpoint = gameObject;
            Debug.Log("Checkpoint Active" + transform.position);
        }
    }
}
