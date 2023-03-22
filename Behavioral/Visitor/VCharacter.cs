using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VCharacter : MonoBehaviour
{
    public float Health;

    public abstract void Accept(ICharacterVisitor visitor);
}