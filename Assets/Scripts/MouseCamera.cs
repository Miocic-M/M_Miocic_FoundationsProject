using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;

// Following Youtube Tutorial: https://youtu.be/CxI2OBdhLno Posted by: Royal Skies. Accessed 13/11/2026

public class MouseCamera : MonoBehaviour
{
    public Vector2 turn;
    public float sensitivity = 0.5f;
    public Vector3 deltaMove;
    public float speed = 1;
    public GameObject mover;

    public GameObject hitObject;
    public GameObject hitInfo;

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

        // code from https://youtu.be/iu5hw8WFmmQ Posted by: Royal Skies. Accessed 14/11/2026
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed, 0, Input.GetAxisRaw("Vertical") * speed);



    }
}











//         // referencing https://discussions.unity.com/t/raycast-and-detect-tags/801551/10


// public class PickUp1 : MonoBehaviour
// {

//     public static bool IngredientCollected1 = false;





//     void Update()
//     {
//         RaycastHit hit;

//         if (Input.GetKeyDown("e"))
//         {
//             if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
//             {
//                 Debug.Log("Raycast Hit!");
//                 if (hit.transform.CompareTag("Selectable")) Debug.Log("Object is selectable");
//                 {
//                     Debug.Log("If statement successful");
//                     PickUpFunction();
//                 }
//             }
//         }
//     }
       
//         public void PickUpFunction(Transform targ)
//     {

//         var rb = targ.GetComponent<Rigidbody>();
//         if (rb != null) rb.useGravity = false;
//         IngredientCollected1 = true;
//         gameObject.transform.Translate(0, 1000, 0);
//     }
// }




        //  // 1. Convert screen coordinates (e.g., mouse position) to a world-space Ray
        //  Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //  RaycastHit hit;

        //  // 2. Cast the ray into the scene
        //  if (Physics.Raycast(ray, out hit))

        //  {
        //      // Access information about the hit object

        //      hitObject = hit.transform.gameObject;
        //      hitObject.SetActive(false);
        //      Debug.Log("Hit: " + hit.collider.name + " at position " + hit.point, hit.collider.gameObject);

        //  }

