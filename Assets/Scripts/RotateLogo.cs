using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLogo : MonoBehaviour
{
    [SerializeField] private Vector3 rotation;
    [SerializeField] private float speed;

    //Code to rotate the logos for fuel and stove
    // tutorial from you-tube www.youtube.com/watch?v=xk0YFoqXPtI&t=23s 
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation * speed * Time.deltaTime);
    }
}
