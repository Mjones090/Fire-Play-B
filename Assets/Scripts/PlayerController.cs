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

    public float xRange = 5;
    public float zRange = 5;

    public GameObject fuelPrefab;

    public ParticleSystem rainParticleSystem;
    public bool makeItRain = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    
    {
        //Launch fuel projectile from player on pressing spacebar
        if (Input.GetKeyDown(KeyCode.Space))
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rainParticleSystem.Play();
        }
    }
}
