using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameplayUI : MonoBehaviour
{
    [SerializeField]
    TMP_Text scoreTxt;
    int score = 0;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void UpdateScore()
    {
        score++;
        scoreTxt.text = score.ToString();
    }
}
