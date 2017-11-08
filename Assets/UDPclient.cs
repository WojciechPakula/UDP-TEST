using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;
using UnityEngine.Networking;

public class UDPclient : MonoBehaviour {
    /*private Thread t;

    private void OnDestroy()
    {
        if (t != null) {
            t.Abort();
            listener.Close();
        }
    }

    void Start () {
        t = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (t != null && !t.IsAlive)
        {
            //t = null;
            Debug.Log("Dead");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (t != null)
            {
                t.Abort();
                listener.Close();
                Debug.Log("Abord");
                t = null;               
            }            
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (t == null)
            {
                t = new Thread(() => StartListener(Thread.CurrentThread));
                t.Start();
                Debug.Log("Start");
            }           
        }       
    }

    private const int listenPort = 11000;
    UdpClient listener=null;

    private void StartListener(Thread main)
    {   
        try
        {
            bool done = false;
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, listenPort);
            listener = new UdpClient(listenPort);
            listener.Client.ReceiveTimeout = 1000;
            while (!done)
            {
                //Thread.Sleep(1000);
                if (!main.IsAlive) throw new Exception("Aplikacja zamknieta");
                try
                {               
                    //Debug.Log("Waiting for broadcast");
                    byte[] bytes = listener.Receive(ref groupEP);

                    //Debug.Log("Odebrano");
                    string json = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
                    Debug.Log(json);


                    //MyClass myObject = JsonUtility.FromJson<MyClass>(json);
                    object myObject = JsonUtility.FromJson<MyClass>(json);
                    if (myObject is MyClassTest)
                    {
                        Debug.Log("MyClassTest xd");
                    }
                    Debug.Log("Received broadcast \n");              
                }
                catch (Exception e)
                {
                    //Debug.Log("Blad");
                }
                finally
                {
                    //Debug.Log("fin");                   
                }
            }
            listener.Close();
        }
        catch (Exception e)
        {
            listener.Close();
            Debug.Log("Stop");
        }
    }*/
}
