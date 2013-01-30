using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

    public float timeScale = 1.0f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.frameCount == 1)
            Time.timeScale = 0;
        //if(Time.timeScale != timeScale)
        //    Time.timeScale = timeScale;

        gameObject.transform.RotateAround(Vector3.zero, Vector3.up, 180 * Time.deltaTime);
	}
}
