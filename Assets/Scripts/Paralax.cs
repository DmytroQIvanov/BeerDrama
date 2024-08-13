using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    private GameObject Player;
    public float Coef=0.2f;
    public float xPos = 0;
    private float StartPositionX;
    //private float StartPositionY;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        StartPositionX = Player.transform.position.x;
        
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(transform.position.x);
       transform.position = new Vector3(transform.position.x - (StartPositionX - Player.transform.position.x)*Coef, transform.position.y,xPos);
        StartPositionX = Player.transform.position.x;

    }
}
