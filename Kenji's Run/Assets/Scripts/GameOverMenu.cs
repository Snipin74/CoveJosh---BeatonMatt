using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour {

    public string mainMenuLevel;

    //public AudioSource death;
    //public AudioSource background;

   /* public void RestartGame()
    {
        FindObjectOfType<LevelManager>().Reset();
        AudioListener.pause = false;
        death.Stop();
        background.Play();


    }*/

    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenuLevel);

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
