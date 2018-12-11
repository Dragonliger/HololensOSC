using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityOSC;

public class OSCActivator : MonoBehaviour {

	// Use this for initialization
	void Start () {
        OSCHandler.Instance.Init();
	}
	
	// Update is called once per frame
	void Update () {
        OSCHandler.Instance.UpdateLogs();
        if (OSCHandler.Instance.Servers["Hololens"].log.Count != 0)
        {
            print(OSCHandler.Instance.Servers["Hololens"].log[OSCHandler.Instance.Servers["Hololens"].log.Count - 1]);
        }
        else
        {
            print("No messages");
        }
	}
}
