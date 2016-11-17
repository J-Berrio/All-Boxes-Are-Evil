using UnityEngine;
using System.Collections;
using System;

public class EnemyDamage : MonoBehaviour, IDamage
{
    public float minusHealth;
    public GameObject player;

    public void Damage()
    {
        StaticVar.maxHealth = StaticVar.maxHealth - minusHealth;
        print(StaticVar.maxHealth);
       
        if(StaticVar.maxHealth < 0)
        {
            StaticVar.maxHealth = StaticVar.minHealth;
            print(StaticVar.minHealth);
        }
    }

    public void OnTriggerEnter(Collider player)
    {
        Damage();
    }
}
