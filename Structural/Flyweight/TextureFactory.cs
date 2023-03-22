using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureFactory
{
    private Dictionary<string, Texture> textures = new Dictionary<string, Texture>();
    public Texture GetTexture(string name)
    {
        if (!textures.ContainsKey(name))
        {
            textures[name] = Resources.Load<Texture>("Flyweight/Textures/" + name);
        }

        return textures[name];
    }
}
    
