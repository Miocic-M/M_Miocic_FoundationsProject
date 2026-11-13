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

    public GameObject hitObject;

void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);

        deltaMove = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;

        // 1. Convert screen coordinates (e.g., mouse position) to a world-space Ray
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // 2. Cast the ray into the scene
        if (Physics.Raycast(ray, out hit))
        {
            // Access information about the hit object

            hitObject = hit.transform.gameObject;
            hitObject.SetActive(false);
            Debug.Log("Hit: " + hit.collider.name + " at position " + hit.point, hit.collider.gameObject);
        }
    }

}
