using UnityEngine;
using System.Collections;

public class GuardPatrol : MonoBehaviour
{
    public Transform player;
    public float wait;

    //This will be for a "guard", some box that comes around to hunt down the player
    //He also will take away health on impact with player
    //But his speed should be slower than the players
    IEnumerator Patrol()
    {
        yield return new WaitForSeconds(wait);
        NavMeshAgent guard = GetComponent<NavMeshAgent>();
        guard.destination = player.position;
    }
}
