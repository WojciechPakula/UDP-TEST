using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

public class UDPhost : MonoBehaviour {
    /*int i = 0;
    Socket s = null;
	// Use this for initialization
	void Start () {
        //initSender();
        //IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
        //Debug.Log(localIPs);
        //string ipAddress = "";    
        //foreach (IPAddress a in localIPs)
        //{
        //    if (a.AddressFamily == AddressFamily.InterNetwork)
        //        ipAddress = a.ToString();
        //}
        //Debug.Log(ipAddress);
        object rq = new Q_SERVER_INFO_REQUEST();
        NetworkManager.instance.runSerwer();
        NetworkManager.instance.sendBroadcast(rq);
    }

    // Update is called once per frame
    void Update () {
        NetworkManager.instance.sendAllQueriesInQueue();
        NetworkManager.instance.executeAllQueriesInQueue();
        if (Input.GetKeyDown(KeyCode.S))
        {
            string o = "lol";
            sendObject(IPAddress.Broadcast, o);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            string o = "lol";
            object obj = o;
            string str = "";
            if (obj is string) str = (string)obj;
            Debug.Log("Test: " + str);
        }
    }

    private void OnDestroy()
    {
        NetworkManager.instance.kill();
    }

    void initSender()
    {
        s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        s.EnableBroadcast = true;
        s.MulticastLoopback = false;
    }

    void sendObject(IPAddress ip, object o)
    {
        MyClassTest myObject = new MyClassTest();
        myObject.level = i;
        myObject.timeElapsed = 47.5f;
        myObject.playerName = "Dr Charles Francis";
        myObject.secretVariable = 666;

        object xd = myObject;

        Type t = xd.GetType();

        if (xd is MyClass)
        {
            Debug.Log("Tak jest "+t);
        }

        string m = JsonUtility.ToJson(xd);

        byte[] sendbuf = Encoding.UTF8.GetBytes(m);
        IPEndPoint ep = new IPEndPoint(ip, 11000);
        ++i;
        s.SendTo(sendbuf, ep);

        Debug.Log("Message sent: "+m);
    }*/
}

/*class DataContainer {
    int type;
    public byte[] Data;
}

[Serializable]
public class MyClass
{
    public int level;
    public float timeElapsed;
    public string playerName;
}

[Serializable]
public class MyClassTest : MyClass
{
    public int secretVariable;
}*/