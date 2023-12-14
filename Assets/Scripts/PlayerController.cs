using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private variables
    private float speed = 10;
    private float turnSpeed = 40;
    private float horizontalInput;
    private float forwardInput;

    public float xRange = 8;
    public float zRange = 8;
    public GameObject Fuel;
    public bool hasFuel = false;

    public Transform fuelFirepoint;

    public int maxFuel = 3;
    public int fuelFired = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {

        //Launch fuel projectile from player on pressing spacebar but only if they have touched the fuel bunker to get fuel
        //once launch x3 pieces of fuel then have to return to bunker to get more.
        //I chose x3 pieces of fuel at a time as thats about the amount someone would carry.

        if (Input.GetKeyDown(KeyCode.Space) && hasFuel)

        {
            if (fuelFired < maxFuel)
            {
                Fire();
                fuelFired++;
            }

            else if (fuelFired == maxFuel)
            {
                hasFuel = false;
                fuelFired = 0;
            }
        }



        //Keep player inbounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }


        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Move player forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Allow player to turn around
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Code to say if player goes over and touches fuel bunker then player has fuel.
        //Once has fuel is then able to fire it but not otherwise
        if (other.CompareTag("Fuel Bunker"))
        {
            hasFuel = true;
        }

    }


    void Fire()
    {

        //This is code to make the fuel fire from the front of the player.
        //I used Chat GPT and google searches to work out how to do this.
        Vector3 spawnPosition = fuelFirepoint.position;
        Quaternion spawnRotation = transform.rotation;


        {
            Instantiate(Fuel, spawnPosition, spawnRotation);
        }

    }
}

