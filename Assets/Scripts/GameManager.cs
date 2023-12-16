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
     public TextMeshProUGUI youWinText;


    // Start is called before the first frame update
    void Start()
    {
        // fuel = 0;
        // updateFuel(0);
        
    }

   // void updateFuel(int fuelToAdd)
   //Need to work this out so can display fuel amount
    //{
        //fuel += fuelToAdd;
        //fuelText.text = "Fuel: " + fuel;
    //}

    //public void GameOver()
        //I want this to work such that if Player is destroyed then Game Over is displayed
        //If Dog appears I want You Win to be displayed
        //If either Game Over or You Win occurs then want button to enable restart game

}
