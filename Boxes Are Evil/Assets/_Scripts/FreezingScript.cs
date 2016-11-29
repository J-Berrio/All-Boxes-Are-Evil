using UnityEngine;
using System.Collections;

public class FreezingScript : MonoBehaviour
{

    public GameObject player;

    OnTriggerEnter(Collider player)
    {
        StartCoroutine(FreezePlayer());
    }

    IEnumerator FreezePlayer()
    {
        while()
    }
}
