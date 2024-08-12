using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCloudText : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CloudObject;
    public bool playerEntered = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && playerEntered)
        { CloudObject.active = !CloudObject.active; }
        }
    void OnTriggerEnter2D(Collider2D collision)
    {
        playerEntered = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        CloudObject.active = false;
        playerEntered = false;
    }

}
