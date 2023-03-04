using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float scoreMultiplier;
    private float score;
    public const string HIGH_SCORE_KEY = "HighScore";
    private void Update()
    {
        score += Time.deltaTime*scoreMultiplier;
        
        scoreText.text = Mathf.FloorToInt(score).ToString();
    }
    private void OnDestroy()
    {
        int currentHighScore = PlayerPrefs.GetInt(HIGH_SCORE_KEY, 0); //default value is if we cant get value of anything then what we return, in that case return 0

        if (score > currentHighScore)
        {
            PlayerPrefs.SetInt(HIGH_SCORE_KEY, Mathf.FloorToInt(score));
        }
    }
}
