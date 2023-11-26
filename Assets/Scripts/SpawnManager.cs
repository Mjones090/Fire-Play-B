using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //This is code to spawn the enemy slugs and lawnmower monsters
    //Spawn is limited to the right of the screen so enemies are outside not inside

    public GameObject[] enemyPrefabs;
    private float spawnRangeX = 0;
    private float spawnPosZ = 9;
    private float startDelay = 2;
    private float spawnInterval = 2;

    // Start is called before the first frame update
    void Start()
    {
        //This code allows enemies to be spawned automatically after a slight delay nad wiht a slight interval between them each time
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomEnemy()
    {
        //This code is to allow the enemy slugs and lawnmower monsters to spawn at various locations on x axis but still be outside
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX, spawnRangeX + 3), 0, spawnPosZ);


        //Using enemy index for enemy aray so get a mixture of slugs and lawnmower monsters spawned
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);


        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    }
}
