using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Exit : MonoBehaviour
{
    public Button Btn;
    // Start is called before the first frame update
    void Start()
    {
        Btn.onClick.AddListener(QuitGame);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void QuitGame()
    {

        Application.Quit();
    }

}
