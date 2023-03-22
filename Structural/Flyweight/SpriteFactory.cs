using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFactory
{
    private Dictionary<string, Sprite> sprites = new Dictionary<string, Sprite>();
    public Sprite GetSprite(string name)
    {
        if (!sprites.ContainsKey(name))
        {
            sprites[name] = Resources.Load<Sprite>("Flyweight/Textures/" + name);
        }

        return sprites[name];
    }
}

