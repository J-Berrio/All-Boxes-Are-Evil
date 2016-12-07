using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSoup : MonoBehaviour
{
    //polymorphism 2,3
    void Start()
    {
        Veggies myVeggie = new Carrot();

        myVeggie.Peel();
        myVeggie.Chop();

        //the above (I think) is upcasting and the below is downcasting.

        Carrot myCarrot = (Carrot)myVeggie;
        myCarrot.Peel();
        myCarrot.Chop();
    }
}
