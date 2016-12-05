using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HandlingDelegates : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        DelegateStuff.DelegateAction += DelegateActHandler;
        DelegateStuff.AnotherDel += AnotherDelHandler;
        DelegateStuff.ThirdDel += ThirdDelHandler;
    }

    private string DelegateActHandler()
    {
        print("What's your name?");
        return "George";
    }

    private void AnotherDelHandler(string s)
    {
        print(s);
    }

    public void ThirdDelHandler()
    {
        player.transform.position = new Vector3(0,10,0);
    }
}
