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
    public GameObject fuelPrefab;
    public bool hasFuel = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    
    {
        //Launch fuel projectile from player on pressing spacebar but only if they have touched the fuel bunker to get fuel
        if (Input.GetKeyDown(KeyCode.Space) && hasFuel)
        {
            Instantiate(fuelPrefab, transform.position, fuelPrefab.transform.rotation);
        }


        //Keep player inbounds
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.x > xRange)
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
       //Code to say if player goes over and touches fuel bunker then player has fuel. Once has fuel is then abel to fire it but not otherwise
        if (other.CompareTag("Fuel Bunker"))
        {
            hasFuel = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Would like this to work but does not yet. Idea is that if player has gone to fuel bunker and has fuel and then collides with stove then message will appear.
        //I do not know why not working.

        if (collision.gameObject.CompareTag("Stove") && hasFuel)
        {
            Debug.Log("Collided with:" + collision.gameObject.name + "with fuel set to" + hasFuel);
        }
    }
}
