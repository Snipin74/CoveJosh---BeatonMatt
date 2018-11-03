using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public string mainMenuLevel;
    public GameObject pauseMenu;
    public AudioSource background;

 

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        pauseMenu.SetActive(false);
        AudioListener.pause = false;
    }

    public void RestartGame()
    {
        FindObjectOfType<GameManager>().Reset();
        //  AudioListener.pause = false;
        //death.Stop();
        //background.Play();


    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(mainMenuLevel);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
