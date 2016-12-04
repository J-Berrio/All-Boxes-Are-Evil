using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HandlingDelegates : MonoBehaviour
{
    void Start()
    {
        DelegateStuff.DelegateAction += DelegateActHandler;
    }

    private string DelegateActHandler()
    {
        print("What's your name?");
        return "George";
    }
}
