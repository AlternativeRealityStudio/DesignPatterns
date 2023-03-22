using UnityEngine;
public class Fireball : IAbility
{
    public void Execute(Character character)
    {
        // Code to cast a fireball
        Debug.Log("fireball");
    }
}

public class Heal : IAbility
{
    public void Execute(Character character)
    {
        // Code to heal the character
        Debug.Log("heal");
    }
}

public class IceBlast : IAbility
{
    public void Execute(Character character)
    {
        // Code to cast an ice blast
        Debug.Log("blast");
    }
}

public class Teleport : IAbility
{
    public void Execute(Character character)
    {
        // Code to teleport the character
        Debug.Log("teleport");
    }
}

public class Invisibility : IAbility
{
    public void Execute(Character character)
    {
        // Code to make the character invisible
        Debug.Log("invisible");
    }
}

