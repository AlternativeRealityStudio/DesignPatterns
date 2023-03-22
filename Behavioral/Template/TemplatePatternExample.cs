using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemplatePatternExample : MonoBehaviour
{
    private void Start()
    {
        Game chessGame = new ChessGame();
        chessGame.Play();

        Game checkersGame = new CheckersGame();
        checkersGame.Play();
    }
}