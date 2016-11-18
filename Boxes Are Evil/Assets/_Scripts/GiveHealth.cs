using UnityEngine;
using System.Collections;

public class GiveHealth : MonoBehaviour
{
    public float giveHealth;
    public GameObject player;

    //just for giving health, there's only one box that does this
    public void OnTriggerEnter(Collider player)
    {
        StaticVar.maxHealth = StaticVar.maxHealth + giveHealth;
        print(StaticVar.maxHealth);

        if(StaticVar.maxHealth > 100)
        {
            StaticVar.maxHealth = 100;
        }
    }
}
