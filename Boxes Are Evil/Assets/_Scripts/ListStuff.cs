using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListStuff : MonoBehaviour
{
    private void Start()
    {
        List<CollectItems> collectibles = new List<CollectItems>();

        collectibles.Add(new CollectItems("Epic Axe of Headbashing", 150));
        collectibles.Add(new CollectItems("Seriously Obnoxious Curse", 345));
        collectibles.Add(new CollectItems("Forked Tongue", 75));

        foreach(CollectItems thing in collectibles)
        {
            print(thing.itemName + " " + thing.powerAttack);
        }
    }

  
}
