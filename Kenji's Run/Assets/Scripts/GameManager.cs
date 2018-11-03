using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public PlayerController thePlayer;
    private Vector3 playerStartPoint;
    private ScoreManager theScoreHandler;
    public GameOverMenu theGameOverScreen;
    public PauseMenu thePauseScreen;
    public GameWinMenu theWin;

    // Use this for initialization
    void Start()
    {
        playerStartPoint = thePlayer.transform.position;
        theScoreHandler = FindObjectOfType<ScoreManager>();

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
        thePlayer.transform.position = playerStartPoint;
       
        thePlayer.gameObject.SetActive(true);


        theScoreHandler.scoreCount = 0;
        theScoreHandler.scoreIncrease = true;
        Time.timeScale = 1;
       
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

}
