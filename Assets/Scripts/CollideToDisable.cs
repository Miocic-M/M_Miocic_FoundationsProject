using UnityEngine;

public class CollideToDisable : MonoBehaviour
{
    public GameObject objToDisable;
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Detected");
        objToDisable.SetActive(false);
    }

    public GameObject BoxCollider;

    void OnDetected(BoxCollider boxCollider)
    {
        Debug.Log("Collision Detected");
        objToDisable.SetActive(false);
    }
}
