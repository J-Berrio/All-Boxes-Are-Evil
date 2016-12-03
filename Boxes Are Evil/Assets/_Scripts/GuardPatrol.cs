using UnityEngine;
using System.Collections;
using System;

public class GuardPatrol : MonoBehaviour, IDamage, IArmor
{
    public Transform player;
    public float wait;

    //This will be for a "guard", some box that comes around to hunt down the player
    //He also will take away health on impact with player
    //But his speed should be slower than the players
    IEnumerator Patrol()
    {
        yield return new WaitForSeconds(wait);
        UnityEngine.AI.NavMeshAgent guard = GetComponent<UnityEngine.AI.NavMeshAgent>();
        guard.destination = player.position;
    }

    public void Damage()
    {
        StaticVar.maxHealth = StaticVar.maxHealth - 35;
        //maybe on second touch it does -70
        //on third touch kills?
    }

    public void Armor()
    {
        //probably something like health that regenerates over time
        //so probably a coroutine that adds .something health back
       //to total health of guard
    }
}
