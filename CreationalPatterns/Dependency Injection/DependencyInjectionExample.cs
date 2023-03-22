using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DependencyInjectionExample : MonoBehaviour
{
    [SerializeField] private Character player;
    private List<IAbility> playerAbilities;
    private void Awake()
    {
        player = GetComponent<Character>();
    }
    private void Start()
    {
        // Set up abilities
        playerAbilities = new List<IAbility>
        {
            new Fireball(),
            new Heal(),
            new IceBlast(),
            new Teleport(),
            new Invisibility()
        };

        // Inject abilities into the player
        player.SetAbilities(playerAbilities);
        //Use anywhere you wanted
        //May you can use enums to make indices more suitable
        //player.UseAbility(0);
        // Use all of them
        UseAllAbilities();
    }

    void UseAllAbilities()
    {
        for (int i = 0; i < playerAbilities.Count; i++)
        {
            player.UseAbility(i);
        }
    }
}
