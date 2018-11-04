using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillLine : MonoBehaviour {

    public GameManager theGameManager;
    public HealthManager theHealthHandler;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            theHealthHandler.health -= 1f;
            theGameManager.Respawn();
        }
    }
}
