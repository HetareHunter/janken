using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : SingletonMonoBehaviour<StateManager>
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public GameState gameState = GameState.Stanby;
    public enum GameState
    {
        Stanby,
        PrePlay,
        Play,
        PlayEnd,
        Result
    }

    private void Update()
    {
        if (gameState == GameState.PrePlay)
        {
            gameState = GameState.Play;
        }
        else if (gameState == GameState.PlayEnd)
        {
            gameState = GameState.Stanby;
        }
    }
}
