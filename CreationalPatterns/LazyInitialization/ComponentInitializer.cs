using System;
using UnityEngine;
public class ComponentInitializer : MonoBehaviour
{
    private Lazy<Rigidbody> _rigidbody;

    private void Awake()
    {
        _rigidbody = new Lazy<Rigidbody>(() => GetComponent<Rigidbody>());
    }
 

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rigidbody.Value.AddForce(Vector3.up * 20.0f);
            Debug.Log("Clicked");
        }  
        
 
    }
}
