using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class IfColliderDetected : MonoBehaviour
{
    public GameObject box;

    public void Start()
    {
        //if ((CapsuleCollider)OnCollisionEnter.BoxCollider == true)
        //{

        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        //box.SetActive(false);
        Debug.Log("BoxTriggered");


    }

    private void OnTriggerExit(Collider other)
    {
        //box.SetActive(true);
        Debug.Log("Box Exit");

    }
}
