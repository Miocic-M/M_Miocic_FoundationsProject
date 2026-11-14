using UnityEngine;


//following Youtube tutorial: https://youtu.be/B34iq4O5ZYI Created by: Game Dev Beginner. Accessed 14/11/2026

public class Raycasttest : MonoBehaviour
{
    Ray ray;
    float maxDistance = 100;
    public LayerMask layersToHit;


    void Start()
    {
        ray = new Ray(transform.position, transform.forward);
        CheckForColliders();
    }

    void CheckForColliders()
    {

        if (Physics.Raycast(ray, out RaycastHit hit, maxDistance, 1>>6, QueryTriggerInteraction.Collide))
        {
            Debug.Log(hit.collider.gameObject.name + "Something was hit");
        }
    }
   
}
