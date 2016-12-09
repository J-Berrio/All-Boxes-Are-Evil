using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    int ducksinarow = 6;

    void Start()
    {
        while (ducksinarow > 0)
        {
            print("You have you're ducks in a row!");
            ducksinarow--;
        }
    }
}
