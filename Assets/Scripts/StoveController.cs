using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveController : MonoBehaviour
{

    public bool isHit = false;
    public Renderer stoveRenderer;

    // Start is called before the first frame update
    void Start()
    {
        stoveRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isHit)
        {
            ChangeColor();
            isHit = false;
        }
    }

    public void OnHitByFuel()
    {
        isHit = true;
    }

    public void ChangeColor()
    {
        stoveRenderer.material.color = Color.red;
    }
}
