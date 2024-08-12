using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("TEST---OnTriggerEnter(Collider other)");
        Destroy(other.gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("TEST---OnCollisionEnter2D(Collider other)");

    }
    
        
    
}
