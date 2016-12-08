using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOne : MonoBehaviour
{
    public int baldness = 4;

    void Balding()
    {
        switch (baldness)
        {
            case 4:
                print("Man, look at that hair!");
                break;

            case 3:
                print("Hmm, you'd better get that checked out, Jim.");
                break;

            case 2:
                print("Rogaine?? You bought a lifetime supply of Rogaine?!");
                break;

            case 1:
                print("Are you sure that stuff works?");
                break;

            default:
                print("Weaves don't work, Jim. Nor do wigs. Or toupees. Just shave it off!");
                break;
        }
    }
}
