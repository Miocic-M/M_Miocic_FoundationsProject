using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public GameObject clickObjToDestroy;
bool IsNear;

void OnekeyDownE()
{
    if (IsNear == true)
    Debug.Log("Object is destroyed");
    Destroy(clickObjToDestroy);
}
void OnKeyDownE()
{
    if (IsNear == false)
    {
        Debug.Log("Player not detected");
    }
}

void OnKeyDownE()
{
    if (CapsuleCollider IsNear == true)
    {

    }
}