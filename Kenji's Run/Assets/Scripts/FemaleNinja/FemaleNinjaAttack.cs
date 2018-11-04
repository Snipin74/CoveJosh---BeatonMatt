using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FemaleNinjaAttack : MonoBehaviour
{
    FemaleNinjaController FNC;

    void Start()
    {
        FNC = gameObject.GetComponentInParent<FemaleNinjaController>();
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            if(FNC)
                FNC.IsAttacking = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            if(FNC)
                FNC.IsAttacking = false;
        }
    }*/
}
