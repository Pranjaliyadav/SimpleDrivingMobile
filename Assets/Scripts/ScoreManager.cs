using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float scoreMultiplier;
    private float score;
    private void Update()
    {
        score += Time.deltaTime*scoreMultiplier;
        
        scoreText.text = Mathf.FloorToInt(score).ToString();
    }
}
