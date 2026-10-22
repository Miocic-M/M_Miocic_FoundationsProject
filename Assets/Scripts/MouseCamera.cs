using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Following Youtube Tutorial: https://youtu.be/CxI2OBdhLno Posted by: Royal Skies Accessed 22/10/2026

public class MouseCamera : MonoBehaviour
{
    public Vector2 turn;
    public float sensitivity = 0.5f;
    public Vector3 deltaMove;
    public float speed = 1;
    public GameObject mover;

void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }

}
