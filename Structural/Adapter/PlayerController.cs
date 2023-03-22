using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;

    private IInputHandler _inputHandler;

    private void Start()
    {
        // Choose which input system to use
        //_inputHandler = new UnityInputHandler(); 
        _inputHandler = new CustomInputHandler(new CustomInputSystem());
    }

    private void Update()
    {
        float horizontal = _inputHandler.GetAxis("Horizontal");
        float vertical = _inputHandler.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical);
        transform.position += movement * speed * Time.deltaTime;
    }
}
