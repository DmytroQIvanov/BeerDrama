using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    public Button Btn;
    void Start()
    {
        Btn.onClick.AddListener(StartGameF);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void StartGameF()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }
}
