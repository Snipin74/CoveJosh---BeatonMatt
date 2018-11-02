using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FemaleAttack : MonoBehaviour {

    public FemaleZombieController theFemale;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            //myZombie.GetComponent<FemaleZombieController>().IsAttacking = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            //myZombie.GetComponent<FemaleZombieController>().IsAttacking = false;
        }
    }

    // Use this for initialization
    void Start()
    {
        theFemale = FindObjectOfType<FemaleZombieController>();

    }

    // Update is called once per frame
    void Update()
    {

    }


}
