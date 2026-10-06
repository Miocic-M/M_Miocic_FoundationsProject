using UnityEngine;
//This script is to destroy a game object using the space bar

public class PushSpaceToDestory : MonoBehaviour
{

    public GameObject gameObjectToDestroy; //This is a reference to the game object that we want to destroy

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Destroy(gameObject);//Destroy the game object this script is attached to

            //Destroy(this);//Destroys the script attached to the game object

            //Destroy(this.gameObject);//This destroys the game object this script is attached to

            Destroy(gameObjectToDestroy);//This destroys the game object that is referenced in the inspector

        }
    }
}
