using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenBlock : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject WillFall;
    public Rigidbody2D WillFallRigidbody2D;
    void Start()
    {
        WillFallRigidbody2D = WillFall.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Player" || col.gameObject.tag == "ground")
        {

            WillFall.AddComponent<Rigidbody2D>();
        }

    }

}
