using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public PlayerController thePlayer;

   
   private Vector3 playerStartPoint;
   // private Vector3 backgroundStartPoint;

   // private GroundDestroyer[] groundList;

    private ScoreManager theScoreHandler;

    public GameOverMenu theGameOverScreen;

    // Use this for initialization
    void Start()
    {

        
        playerStartPoint = thePlayer.transform.position;


        theScoreHandler = FindObjectOfType<ScoreManager>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RestartGame()
    {
        theScoreHandler.scoreIncrease = false;
        thePlayer.gameObject.SetActive(false);

        theGameOverScreen.gameObject.SetActive(true);
        Time.timeScale = 0;

        //StartCoroutine("RestartGameCo");
    }

    public void Reset()
    {
        theGameOverScreen.gameObject.SetActive(false);

        Application.LoadLevel(Application.loadedLevel);
        thePlayer.transform.position = playerStartPoint;
       
        thePlayer.gameObject.SetActive(true);


        theScoreHandler.scoreCount = 0;
        theScoreHandler.scoreIncrease = true;
        Time.timeScale = 1;

       
    }
}
