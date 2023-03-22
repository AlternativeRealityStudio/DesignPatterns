using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Game
{
    // The template method defines the overall structure of the game
    public void Play()
    {
        Initialize();
        StartGame();
        EndGame();
    }

    // These methods are implemented by the concrete subclasses
    protected abstract void Initialize();
    protected abstract void StartGame();

    // This method is common to all the concrete subclasses and is not overridable
    private void EndGame()
    {
        Debug.Log("Game over!");
    }
}