using UnityEngine;
using System.Collections;

public class CubeTrigger : MonoBehaviour {

    int StayCounter = 0;
    public bool destroyCollisionStay = false;
    void OnTriggerEnter(Collider other)
    {
        Logger.Log("Enter");
    }

    void OnTriggerExit(Collider other)
    {
        Logger.Log("Exit");
    }

    void OnTriggerStay(Collider other)
    {
        Logger.Log("Stay");

        if (destroyCollisionStay)
        {
            StayCounter++;

            if (StayCounter == 10)
                Destroy(gameObject);
        }
    }
}
