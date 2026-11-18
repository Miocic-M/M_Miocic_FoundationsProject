using UnityEngine;

public class Collecttotrigger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (gameObject.CompareTag("Collectable"))
        {
            gameObject.SetActive(true);
        }
    }

}
