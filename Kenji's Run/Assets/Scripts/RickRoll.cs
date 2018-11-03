using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RickRoll : MonoBehaviour {
  
    private void OnTriggerEnter2D(Collider2D ChestCollider)
    {
        if (ChestCollider.gameObject.CompareTag("Sword"))
        {

            Application.LoadLevel(4);
        }
    }
}
