using System.Collections;
using System.Collections.Generic;
using GameState;
using UnityEngine;

public class GameManager : MonoBehaviour {

    //Auto-implemented properties that are not exposed to the editor's users.
    public StateGamePlaying stateGamePlaying { get; set; }
    public StateGameWon stateGameWon { get; set; }
    public StateGameLost stateGameLost { get; set; }

    private GameState currentState;

    private void Awake()
    {
        stateGamePlaying = new StateGamePlaying(this);
        stateGameWon = new StateGameWon(this);
        stateGameLost = new stateGameLost(this);
    }

    private void Start()
    {
        NewGameState(stateGamePlaying);
    }

    private void Update()
    {
        if(null != currentState)
        {
            currentState.StartUpdate();
        }
    }
}
