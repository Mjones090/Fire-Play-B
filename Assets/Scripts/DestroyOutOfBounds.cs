using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //This is code to destroy Game Object if they go off screen so stops gaem slowing down over time

    public float zBoundaryRange = 12;
    public float xBoundaryRange = 12;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -zBoundaryRange)
        {
            Destroy(gameObject);
        }

        if (transform.position.z > zBoundaryRange)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < -xBoundaryRange)
        {
            Destroy(gameObject);
        }

        if (transform.position.x > xBoundaryRange)
        {
            Destroy(gameObject);
        }
    }
}
