using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float spawnRangeX = 0;
    private float spawnPosZ = 9;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Spawn slug lawnmower monster enemies on pressing S key
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomEnemy();
        }
    }

    void SpawnRandomEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX, spawnRangeX + 3), 0, spawnPosZ);

        int enemyIndex = Random.Range(0, enemyPrefabs.Length);


        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    }
}
