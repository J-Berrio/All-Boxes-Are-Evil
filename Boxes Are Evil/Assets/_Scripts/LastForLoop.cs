using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastForLoop : MonoBehaviour
{
    int numTanks = 7;

    void Start()
    {
        for (int i = 0; i < numTanks; i++)
        {
            print("Tank number " + i);
        }
    }
}
