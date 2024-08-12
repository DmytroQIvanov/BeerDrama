using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    public int LifeCount = 3;
    public TextMeshPro EnemyText;
    void Start()
    {
        EnemyText.text = "Lifes: 3";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
