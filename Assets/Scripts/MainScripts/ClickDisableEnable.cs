using UnityEngine;

public class ClickDisableEnable : MonoBehaviour
{
    public GameObject clickObjToDisable;
    public GameObject clickObjToEnable;

    void OnMouseDown()
    {
        clickObjToDisable.SetActive(false);
        clickObjToEnable.SetActive(true);

        Debug.Log("Object was disabled and enabled");
    }
}
