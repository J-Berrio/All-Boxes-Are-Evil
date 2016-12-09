using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastForEach : MonoBehaviour
{
    void Start()
    {
        string[] stuff = new string[4];
        stuff[0] = "baseball bat";
        stuff[1] = "shovel";
        stuff[2] = "gloves";
        stuff[3] = "bag";

        foreach(string item in stuff)
        {
            print(item);
        }
    }
}
