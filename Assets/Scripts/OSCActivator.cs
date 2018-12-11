using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityOSC;

public class OSCActivator : MonoBehaviour {

    public GameObject Cube;
    public Material Color;

	// Use this for initialization
	void Start () {
        OSCHandler.Instance.Init();
	}
	
	// Update is called once per frame
	void Update () {
        OSCHandler.Instance.UpdateLogs();
        if (OSCHandler.Instance.Servers["Hololens"].log.Count != 0)
        {
            int Value = OSCParseInt(OSCHandler.Instance.Servers["Hololens"].log[OSCHandler.Instance.Servers["Hololens"].log.Count - 1]);
            print(Value);
            if(Value == 3)
            {
                Cube.GetComponent<Renderer>().material = Color;
            }
        }
        else
        {
            print("No messages");
        }
	}

    public int OSCParseInt(string message)
    {
        string[] messageParts = message.Split(' ');
        //return int.Parse(messageParts[1]);
        print(messageParts[1]);
        return 3;
    }
}
