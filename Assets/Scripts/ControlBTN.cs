using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ControlBTN : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update

    public bool btnPressed =false;

    void Start()
    {
        
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("TESTTTTTTT");
        btnPressed = true;
    }
    
    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("TESTTTTTTT");
        btnPressed = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
