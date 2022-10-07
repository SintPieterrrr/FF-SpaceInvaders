using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TMP_Text scoreText;
    private int _score = 0;

    private void Start()
    {
        instance = this; 
        UpdateUI();
    }

    public void UpdateScore() {
        _score++;
        UpdateUI();
    }

    public void UpdateUI()
    {
        scoreText.text = "Score: " + _score;
    }
}
