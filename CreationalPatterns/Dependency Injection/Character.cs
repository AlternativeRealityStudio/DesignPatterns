using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private List<IAbility> abilities;

    public void SetAbilities(List<IAbility> newAbilities)
    {
        abilities = newAbilities;
    }

    public void UseAbility(int index)
    {
        if (index >= 0 && index < abilities.Count)
        {
            abilities[index].Execute(this);
        }
    }
}
