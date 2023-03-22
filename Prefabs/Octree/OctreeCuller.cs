using System.Collections.Generic;
using UnityEngine;

public class OctreeCuller : MonoBehaviour
{
    public Camera cam;
    public Bounds sceneBounds;
    public int maxObjectsPerNode = 5;
    public int maxDepth = 10;
    public List<GameObject> obj = new List<GameObject>();
    private Octree octree;

    private void Start()
    {
        octree = gameObject.AddComponent<Octree>();
        octree.Initialize(sceneBounds);
        foreach (var item in obj)
        {
            AddObject(item);
        }
    }
    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            foreach (GameObject item in GetVisibleObjects())
            {
                item.SetActive(false);
            }
        }
    }

    public void AddObject(GameObject obj)
    {
        Collider collider = obj.GetComponent<Collider>();

        if (collider != null)
        {
            octree.Insert(obj, collider.bounds);
        }
    }

    public List<GameObject> GetVisibleObjects()
    {
        Bounds cameraBounds = GetCameraBounds(cam);
        List<GameObject> visibleObjects = octree.Query(cameraBounds);

        return visibleObjects;
    }

    private Bounds GetCameraBounds(Camera camera)
    {
        float height = 2f * camera.orthographicSize;
        float width = height * camera.aspect;

        Vector3 center = camera.transform.position;
        Vector3 size = new Vector3(width, height, 100f);

        return new Bounds(center, size);
    }

    private void OnDrawGizmos()
    {
        if (octree != null)
        {
            octree.DrawGizmos();
        }
    }
}
