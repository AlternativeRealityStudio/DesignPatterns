using System; 
using UnityEngine;

public class AssetLoader
{
    private static readonly Lazy<Texture2D> _texture = new Lazy<Texture2D>(() => Resources.Load<Texture2D>("Texture"));

    public static Texture2D GetTexture()
    {
        return _texture.Value;
    }
}
