using System;
using UnityEngine;

public class PrefabLoader
{
    private static readonly Lazy<GameObject> _prefab = new Lazy<GameObject>(() => Resources.Load<GameObject>("Prefab"));

    public static GameObject InstantiatePrefab(Vector3 position)
    {
        return UnityEngine.Object.Instantiate(_prefab.Value, position, Quaternion.identity);
    }
}
