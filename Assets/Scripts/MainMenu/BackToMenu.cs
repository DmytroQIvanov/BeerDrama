using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BackToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    //public Button Btn;
    // void Start()
    // {
    //   //  Btn.onClick.AddListener(BackToMenuF);

    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

// public void OnPointerDown(PointerEventData eventData)
//     {
//         SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
//     }
public void BackToMenuF()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
    public void BackToMenuF1()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
    // void BackToMenuF()
    // {
    //     SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    // }
}
