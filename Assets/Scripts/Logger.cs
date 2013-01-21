using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Logger : MonoBehaviour {

    class LoggingData
    {
        public string logMessage;
        public float loggingTime;
    }
    float visibleTime = 1.5f;
    static List<LoggingData> loggingData = new List<LoggingData>();
    GUIText logText;
	// Use this for initialization
	void Start () {
        logText = GameObject.Find("LogMessage").GetComponent<GUIText>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        StringBuilder logMsgBldr = new StringBuilder();

        foreach (LoggingData logData in loggingData)
        {
            logMsgBldr.AppendLine(logData.logMessage);
        }
        logText.text = logMsgBldr.ToString();

        loggingData = loggingData.FindAll(d => Time.time < d.loggingTime + visibleTime);
	}

    static public void Log(string log)
    {
        loggingData.Add( new LoggingData() { logMessage = log, loggingTime = Time.time });
        Logger logger = (Logger)GameObject.FindObjectOfType(typeof(Logger));
        if (logger == null)
        {
            GameObject logObject = new GameObject("Logger");
            logObject.AddComponent<Logger>();
        }
    }
}
