using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacadeExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObjectFacade facade = new GameObjectFacade("MyGameObject");
        facade.AddComponent<MeshRenderer>();
        facade.AddComponent<SphereCollider>();
        //....
        facade.SetPosition(new Vector3(0, 0, 0));
        facade.SetRotation(Quaternion.identity);
        facade.SetScale(new Vector3(1, 1, 1));

    }

    
}
