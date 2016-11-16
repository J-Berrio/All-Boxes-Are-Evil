using UnityEngine;
using System.Collections;
using System;

public class EnemyDamage : MonoBehaviour
{
    public static Action <EnemyDamage> DamageHealth;
    public GameObject player;

    void OnTriggerEnter()
    {
        Start();
    }

    public void Start()
    {
        EnemyDamage.DamageHealth += DamageHandler();

        if (DamageHealth != null)
        {
            DamageHealth();
        }
    }

    public float minusHealth;

    void DamageHandler(EnemyDamage _d)
    {
        StaticVar.maxHealth = StaticVar.maxHealth - minusHealth;
    }
}
