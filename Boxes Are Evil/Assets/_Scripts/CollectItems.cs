using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    public string itemName;
    public int powerAttack;


    public CollectItems(string Name, int PowerAttack)
    {
        itemName = Name;
        powerAttack = PowerAttack;
    }
}

