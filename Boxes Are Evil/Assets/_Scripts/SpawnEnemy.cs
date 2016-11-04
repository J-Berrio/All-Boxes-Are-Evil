using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour
{
    public Transform[] spawnLoc;
    public GameObject[] enemies;
    public float spawnFrequency = 1;
    public bool canSpawnEnemy = true;

    private int i = 0;
    private int j = 0;
	
	void Start ()
    {
        StartCoroutine(SpawnEnemies()); 
	}

    IEnumerator SpawnEnemies ()
    {
        while(canSpawnEnemy)
        {
            i = Random.Range(0, spawnLoc.Length - 1);
            enemies[j].SetActive(true);
            enemies[j].transform.position = spawnLoc[i].position;

            if(j < enemies.Length -1)
            {
                j++;
            }
            else
            {
                j = 0;
            }

            yield return new WaitForSeconds(spawnFrequency);
        }
    }
}
