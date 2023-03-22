using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public GameObject animatorComponent;
    List<IEnumerator> sequences;
    void Start()
    {
        //sequences = new List<IEnumerator>()
        //{
        //    new AnimationSequence()
        //        .Play(animatorComponent.gameObject, "Idle")
        //        .WithDelay(1.0f)
        //        .Play(animatorComponent.gameObject, "Vertical")
        //        .WithDelay(1.0f)
        //        .Play(animatorComponent.gameObject, "Horizontal")
        //        .GetEnumerator() 
        //};

        //StartCoroutine(PlaySequence());
        //Debug.Log("count sequence:"+sequences.Count);
        AnimationSequenceList sequenceList = new AnimationSequenceList()
            .Play(gameObject, "Vertical")
            .WithDelay(4.0f)
            .Play(gameObject, "Horizontal")
            .WithDelay(3.0f)
            .Play(gameObject, "Idle")
            .WithDelay(3.0f)
            .Play(gameObject, "Vertical")
            .WithDelay(4.0f)
            .Play(gameObject, "Horizontal")
            .WithDelay(3.0f)
            .Play(gameObject, "Idle");

       Debug.Log("Count seq:" + sequenceList.GetEnumerator().Count);
        sequences = sequenceList.GetEnumerator();
        StartCoroutine(PlaySequence());

    }

    IEnumerator PlaySequence()
    {
        foreach (var item in sequences)
        {
            yield return item;
        }
    }
}
