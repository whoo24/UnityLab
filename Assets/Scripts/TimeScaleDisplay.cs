using UnityEngine;
using System.Collections;
using System.Text;

public class TimeScaleDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        StringBuilder builder = new StringBuilder();
        builder.AppendFormat("timeScale:{0}\n", Time.timeScale);
        builder.AppendFormat("deltatimeTime:{0}\n", Time.deltaTime);
        //builder.AppendFormat("targetFrameRate:{0}\n", Application.);
        builder.AppendFormat("fixedTimeDelta:{0}\n", Time.fixedDeltaTime);
        gameObject.GetComponent<GUIText>().text = builder.ToString();
	}
}
