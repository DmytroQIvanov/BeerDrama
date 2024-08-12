using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Trigger;
    public String NextScene;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        private void OnTriggerEnter2D(Collider2D collision)
        {
        PlayerPrefs.SetInt("D",2);
            if (collision.gameObject.tag == "Player")
        {

            SceneManager.LoadSceneAsync(NextScene, LoadSceneMode.Single);
        }

    }

}
