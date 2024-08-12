using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dangerous : MonoBehaviour
{
    // Start is called before the first frame update

    public Player Player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        Debug.Log(col+"sddd");
        Debug.Log(col.name);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision);
        collision.gameObject.SendMessage("Damage", 1);
        Player.RemoveLife();
    }


    }
