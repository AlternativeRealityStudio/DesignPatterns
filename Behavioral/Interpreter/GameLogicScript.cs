using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogicScript : MonoBehaviour
{
    void Start()
    {
        TextAsset scriptAsset = Resources.Load<TextAsset>("Interpreter/game_logic");
        ScriptInterpreter.Evaluate(scriptAsset.text, gameObject);
    }
}