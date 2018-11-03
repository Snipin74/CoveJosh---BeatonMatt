using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWinMenu : MonoBehaviour {

    public string mainMenuLevel;
    public string nextLevel;

    //public AudioSource death;
    //public AudioSource background;

    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenuLevel);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(nextLevel);
        Time.timeScale = 1f;
    }



    // Use this for initialization
    void Start()
    {
        // background.Stop();
        //death.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //background.Stop();
    }
}
