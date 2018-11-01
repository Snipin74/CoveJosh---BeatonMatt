using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthManager : MonoBehaviour {

    //player health

    public Text HealthText;
    float maxHealth = 100f;
    public static float health;

	// Use this for initialization
	void Start () {

        health = maxHealth;
        		
	}
	
	// Update is called once per frame
	void Update () {

        HealthText.text = ("Health: " + health);
       
	}
}
