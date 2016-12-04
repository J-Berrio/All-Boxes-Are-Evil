using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DelegateStuff : MonoBehaviour
{
    public static Func<string> DelegateAction;
    public string names;

    void OnBecameVisible()
    {
        print(DelegateAction());
    }
}
