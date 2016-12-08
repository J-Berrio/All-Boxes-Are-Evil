using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherSwitch : MonoBehaviour
{
    public int animals = 3;

    void OnTriggerEnter()
    {
        TheZoo();
    }

    public void TheZoo()
    {
        print("Enter");
        switch(animals)
        {
            case 3:
                print("The cow goes MOO");
                goto case 2;

            case 2:
                print("The duck does QUACK");
                goto case 1;

            case 1:
                print("What does the fox say?");
                goto default;

            default:
                print("Muahahaha");
                break;
        }
    }
}
