using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VGameManager : MonoBehaviour
{
    public List<VCharacter> Characters;
    public ICharacterVisitor FireballAbility=new FireballAbility();
    public ICharacterVisitor ShieldAbility=new ShieldAbility();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ApplyAbility(FireballAbility);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            ApplyAbility(ShieldAbility);
        }
    }

    private void ApplyAbility(ICharacterVisitor visitor)
    {
        foreach (var character in Characters)
        {
            character.Accept(visitor);
        }
    }
}