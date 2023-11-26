using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Spawn slug lawnmower monster enemies
        if (Input.GetKeyDown(KeyCode.S))
        {
            int enemyIndex = Random.Range(0, enemyPrefabs.Length);

            Instantiate(enemyPrefabs[enemyIndex], new Vector3(0, 0, 5), enemyPrefabs[enemyIndex].transform.rotation);
        }

      
    }
}
