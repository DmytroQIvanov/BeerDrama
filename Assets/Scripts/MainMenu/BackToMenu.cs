using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public Button Btn;
    void Start()
    {
        Btn.onClick.AddListener(BackToMenuF);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BackToMenuF()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
