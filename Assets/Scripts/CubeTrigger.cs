using UnityEngine;
using System.Collections;

public class CubeTrigger : MonoBehaviour {

    int StayCounter = 0;
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
        StayCounter++;

        if (StayCounter == 10)
            Destroy(gameObject);
    }
}
