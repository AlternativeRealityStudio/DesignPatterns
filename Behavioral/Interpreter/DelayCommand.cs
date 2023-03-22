using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayCommand : ICommand
{
    private float duration;

    public DelayCommand(float duration)
    {
        this.duration = duration;
    }

    public void Execute(GameObject gameObject)
    {
        // Delay the execution of the script by duration seconds
        gameObject.GetComponent<MonoBehaviour>().StartCoroutine(DelayRoutine());
    }

    private IEnumerator DelayRoutine()
    {
        yield return new WaitForSeconds(duration);
        Debug.Log("Delayed:" + duration);
    }
}
