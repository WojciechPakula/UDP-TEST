using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Test : MonoBehaviour {
    public IPEndPoint ip = null;
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        //dwie metody które muszą być regularnie wywoływane
        NetworkManager.instance.update();
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("R");
            NetworkManager.instance.runSerwer();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (ip != null)
            {
                Debug.Log("C");
                NetworkManager.instance.connectToSerwer(ip);
            }          
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("B");
            NetworkManager.instance.sendBroadcast(new Q_SERVER_INFO_REQUEST());
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("H");
            NetworkManager.instance.sendToAllComputers(new Q_HELLO { text = "komunikat"});
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E");
            NetworkManager.instance.enableNetwork();
        }
    }

    private void OnDestroy()
    {
        NetworkManager.instance.kill();
    }
}
