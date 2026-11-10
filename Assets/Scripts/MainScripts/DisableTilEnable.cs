using UnityEngine;

public class DisableTilEnable : MonoBehaviour
{
    public GameObject objToDisable;
    void Start()
    {
        objToDisable.SetActive(false);
        Debug.Log("Object is disabled");
    }
}
