using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
   //public TextMeshProUGUI fuelText;
    //private int fuel;

       public TextMeshProUGUI gameOverText;
    
    // Start is called before the first frame update
    void Start()
    {
        // fuel = 0;
        // updateFuel(0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   // void updateFuel(int fuelToAdd)
   //Need to work this out so can display fuel amount
    //{
        //fuel += fuelToAdd;
        //fuelText.text = "Fuel: " + fuel;
    //}

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Destroy(gameObject);
        Destroy(other.gameObject);
        if (other.gameObject.CompareTag("Player"))
        {
            GameOver();
        }

    }
}
