using UnityEngine;

public class GameObjectFacade
{
    private GameObject gameObject;

    public GameObjectFacade(string name)
    {
        gameObject = new GameObject(name);
    }

    public void AddComponent<T>() where T : Component
    {
        gameObject.AddComponent<T>();
    }

    public void SetPosition(Vector3 position)
    {
        gameObject.transform.position = position;
    }

    public void SetRotation(Quaternion rotation)
    {
        gameObject.transform.rotation = rotation;
    }

    public void SetScale(Vector3 scale)
    {
        gameObject.transform.localScale = scale;
    }
}
