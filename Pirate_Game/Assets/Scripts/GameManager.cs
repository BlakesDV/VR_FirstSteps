using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    /// <summary>
    /// Singleton Game Manager Instance
    /// </summary>
    public static GameManager instance;

    private GameStates m_gameState;

    private void Awake() {
        if (instance != null && instance != this) {
            Destroy(this);
        } else {

            instance = this;
        }
    }
    
    private void Start() {
        changeGameState(GameStates.Playing);
        print(getGameState());
    }
    

    /// <summary>
    /// Changes the Game State
    /// </summary>
    /// <param name="t_newState">Updated Game State</param>
    public void changeGameState(GameStates t_newState) {
        if (m_gameState == t_newState) {
            return;
        }
        m_gameState = t_newState;

        switch (m_gameState) {
            case GameStates.None:
                break;
            case GameStates.LoadGame:
                break;
            case GameStates.MainMenu:
                break;
            case GameStates.Tutorial:
                break;
            case GameStates.Playing:
                break;
            case GameStates.GameOver:
                break;

        }
    }

    public GameStates getGameState() {
        return m_gameState;
    }

    public bool compareGameState(GameStates t_otherGameState) {
        return m_gameState == t_otherGameState;
    }
}

public enum GameStates {
    None,
    LoadGame,
    MainMenu,
    GameStart,
    Tutorial,
    Playing,
    GameOver
}

