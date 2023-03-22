using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface IPrototype<T>
{
    T Clone();
}
public abstract class Unit : MonoBehaviour, IPrototype<Unit>
{
    [SerializeField] protected string unitName;
    [SerializeField] protected int health;
    [SerializeField] protected int attackPower;
    [SerializeField] protected float moveSpeed;

    public abstract Unit Clone();
}