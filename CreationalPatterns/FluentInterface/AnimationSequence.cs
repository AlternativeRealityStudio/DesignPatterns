using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSequenceList
{
    private List<IEnumerator> _sequences;

    public AnimationSequenceList()
    {
        _sequences = new List<IEnumerator>();
    }

    public AnimationSequenceList Play(GameObject gameObject, string animationName)
    {
        _sequences.Add(PlayAnimation(gameObject, animationName));
        return this;
    }

    public AnimationSequenceList WithDelay(float delay)
    {
        _sequences.Add(Delay(delay));
        return this;
    }

    public List<IEnumerator> GetEnumerator()
    {
        return _sequences;
    }

    private IEnumerator PlayAnimation(GameObject gameObject, string animationName)
    {
        Animator animator = gameObject.GetComponent<Animator>();
        if (animator != null)
        {
            animator.CrossFade(animationName,0.1f);
        }
        yield return null;
    }

    private IEnumerator Delay(float delay)
    {
        yield return new WaitForSeconds(delay);
    }
}
