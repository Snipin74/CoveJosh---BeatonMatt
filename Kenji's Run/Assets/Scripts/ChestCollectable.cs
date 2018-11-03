using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChestCollectable : MonoBehaviour {

    public GameManager theGameManager;

    private void OnTriggerEnter2D(Collider2D ChestCollider)
    {
        if (ChestCollider.gameObject.CompareTag("Sword"))
        {

            theGameManager.GameWin();
        }
    }
}
