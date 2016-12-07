using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrot :  Veggies
{
    //polymorphism 1
    public new void Peel()
    {
        print("Steve! The carrots, I said. Not the potatoes!");
    }

    public new void Chop()
    {
        print("There's a difference between 'chop' and 'dice', you know.");
    }

    public new void SaladShooter()
    {
        print("Shoots everything. Even cheese.");
    }
}

 
