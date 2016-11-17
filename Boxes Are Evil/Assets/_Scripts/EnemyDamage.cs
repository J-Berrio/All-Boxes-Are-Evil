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
    }

    void OnTriggerEnter(Collider player)
    {
        Damage();
    }
}
