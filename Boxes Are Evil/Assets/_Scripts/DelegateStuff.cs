using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DelegateStuff : MonoBehaviour
{
    public static Func<string> DelegateAction;
    public static Action<string> AnotherDel;


    void OnBecameVisible()
    {
        if (DelegateAction != null)
        {
            print(DelegateAction());
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (AnotherDel != null)
        {
            AnotherDel("Hallo hallo, hallo?");
        }
    }
} 