using System.Collections.Generic;
using UnityEngine;

public class Octree : MonoBehaviour
{
    private List<GameObject> objects = new List<GameObject>();
    private Bounds bounds;
    private Octree[] children;
    private int maxObjectsPerNode = 5;
    private int maxDepth = 10;
    private int depth = 0;

    public void Initialize(Bounds bounds)
    {
        this.bounds = bounds;
    }

    public bool Insert(GameObject obj, Bounds bounds)
    {
        if (!this.bounds.Intersects(bounds))
        {
            return false;
        }

        if (objects.Count < maxObjectsPerNode || depth == maxDepth)
        {
            objects.Add(obj);
            return true;
        }

        if (children == null)
        {
            Split();
        }

        foreach (Octree child in children)
        {
            if (child.Insert(obj, bounds))
            {
                return true;
            }
        }

        return false;
    }

    private void Split()
    {
        float halfSize = bounds.size.x / 2f;
        Vector3 center = bounds.center;

        children = new Octree[8];

        children[0] = CreateChild(new Vector3(center.x - halfSize, center.y - halfSize, center.z - halfSize), halfSize);
        children[1] = CreateChild(new Vector3(center.x + halfSize, center.y - halfSize, center.z - halfSize), halfSize);
        children[2] = CreateChild(new Vector3(center.x - halfSize, center.y - halfSize, center.z + halfSize), halfSize);
        children[3] = CreateChild(new Vector3(center.x + halfSize, center.y - halfSize, center.z + halfSize), halfSize);
        children[4] = CreateChild(new Vector3(center.x - halfSize, center.y + halfSize, center.z - halfSize), halfSize);
        children[5] = CreateChild(new Vector3(center.x + halfSize, center.y + halfSize, center.z - halfSize), halfSize);
        children[6] = CreateChild(new Vector3(center.x - halfSize, center.y + halfSize, center.z + halfSize), halfSize);
        children[7] = CreateChild(new Vector3(center.x + halfSize, center.y + halfSize, center.z + halfSize), halfSize);

        objects.Clear();
    }

    private Octree CreateChild(Vector3 center, float halfSize)
    {
        Octree child = gameObject.AddComponent<Octree>();
        child.Initialize(new Bounds(center, Vector3.one * halfSize * 2f));
        child.maxObjectsPerNode = maxObjectsPerNode;
        child.maxDepth = maxDepth;
        child.depth = depth + 1;
        return child;
    }

    public List<GameObject> Query(Bounds queryBounds)
    {
        List<GameObject> result = new List<GameObject>();

        if (!bounds.Intersects(queryBounds))
        {
            return result;
        }

        foreach (GameObject obj in objects)
        {
            if (queryBounds.Intersects(obj.GetComponent<Collider>().bounds))
            {
                result.Add(obj);
            }
        }

        if (children != null)
        {
            foreach (Octree child in children)
            {
                result.AddRange(child.Query(queryBounds));
            }
        }

        return result;
    }
    public void DrawGizmos()
    {
        Gizmos.DrawWireCube(bounds.center, bounds.size);

        if (children != null)
        {
            foreach (Octree child in children)
            {
                child.DrawGizmos();
            }
        }
    }

}
