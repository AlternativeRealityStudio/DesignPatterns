using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptInterpreter
{
    public static void Evaluate(string script, GameObject gameObject)
    {
        string[] commands = script.Split(';');

        foreach (string command in commands)
        {
            string[] tokens = command.Split(' ');
            string commandType = tokens[0];
            ICommand cmd = null; 
            switch (commandType)
            {
                case "move":
                    float x = float.Parse(tokens[1]);
                    float y = float.Parse(tokens[2]);
                    float z = float.Parse(tokens[3]);
                    cmd = new MoveCommand(new Vector3(x, y, z));
                    Debug.Log("move");
                    break;
                case "attack":
                    // Parse target object from tokens[1]
                    GameObject target = GameObject.Find(tokens[1]);
                    cmd = new AttackCommand(target);
                    Debug.Log("attack");
                    break;
                case "heal":
                    float amount = float.Parse(tokens[1]);
                    cmd = new HealCommand(amount);
                    Debug.Log("heal");
                    break;
                case "delay":
                    float duration = float.Parse(tokens[1]);
                    cmd = new DelayCommand(duration);
                    Debug.Log("delay");
                    break;
                default:
                    Debug.Log("Unknown command: " + commandType);
                    break;
            }

            if (cmd != null)
            {
                cmd.Execute(gameObject);
            }
        }
    }
}