using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DelegateStuff : MonoBehaviour
{
    public static Func<string> DelegateAction;
    public static Action<string> AnotherDel;
    public static Action ThirdDel;


    void OnBecameVisible()
    {
        if (DelegateAction != null)
        {
            print(DelegateAction());
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (AnotherDel != null)
        {
            AnotherDel("Hallo hallo, hallo?");
        }
    }

    void OnMouseDrag()
    {
        if(ThirdDel != null)
        {
            ThirdDel();
        }
    }
} 