using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private PlayerController thePlayer;
    private Vector3 playerStartPoint;
    private ScoreManager theScoreHandler;
    private HealthManager theHealthHandler;
    public GameOverMenu theGameOverScreen;
    public PauseMenu thePauseScreen;
    public GameWinMenu theWin;
    public GameObject currentCheckpoint;


    // Use this for initialization
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
        theScoreHandler = FindObjectOfType<ScoreManager>();
        theHealthHandler = FindObjectOfType<HealthManager>();

        playerStartPoint = thePlayer.transform.position;
    }

    public void GameOver()
    {
        theScoreHandler.scoreIncrease = false;
        thePlayer.gameObject.SetActive(false);

        theGameOverScreen.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void Reset()
    {
        theGameOverScreen.gameObject.SetActive(false);
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1;

        /* The blocked out here will be used in the future to make the level reset
         * properly.
         * thePlayer.transform.position = playerStartPoint;
         * thePlayer.gameObject.SetActive(true);
         * theScoreHandler.scoreCount = 0;
         * theScoreHandler.scoreIncrease = true;*/
    }

    public void PauseGame()
    {
        thePauseScreen.gameObject.SetActive(true);
        Time.timeScale = 0f;
        AudioListener.pause = true;
        AudioListener.pause = true;
    }

    public void GameWin()
    {
        theWin.gameObject.SetActive(true);
        Time.timeScale = 0;

    }

    public void Respawn()
    {
        Debug.Log("You are back!!!");
        thePlayer.transform.position = currentCheckpoint.transform.position;       
    }

}
