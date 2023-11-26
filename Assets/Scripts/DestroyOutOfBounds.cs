using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public float zBoundaryRange = 15;
    public float xBoundaryRange = 15;
    

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
