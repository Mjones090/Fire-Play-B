using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTheFire : MonoBehaviour
{

    

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Stove"))
        {
            //Increase temperature
            //Will display this by stove changing colour if hit by x1 piece of fuel
            //If stove hit by all three pieces of fuel then will make pet dog appear and that is level complete
            //Used ChatGPt to help wiht this script

            Destroy(gameObject);

            collision.gameObject.GetComponent<StoveController>().OnHitByFuel();


        }



    }
}