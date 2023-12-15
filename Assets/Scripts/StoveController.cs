using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveController : MonoBehaviour
{
    //Used ChatGPt to help with this script and Bing and google

    public bool isHit = false;
    public Renderer stoveRenderer;

    public GameObject dogPrefab;
    public int collisionCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        stoveRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Make thr stove change colour frm balck cold to red hot if hit with fuel

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

    private void OnCollisionEnter(Collision collision)
    {

        //Make a dog appear near the fire if it is hit with x3 pieces of fuel

        if (collision.gameObject.CompareTag("Fuel"))
        {
            collisionCount++;
            if (collisionCount == 3)
            {
                Instantiate(dogPrefab, transform.position, Quaternion.identity);
            }
        }
    }
}
