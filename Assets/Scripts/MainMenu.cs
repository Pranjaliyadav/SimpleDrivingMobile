using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text highScoreText;
    private void Start()
    {
        int highScore = PlayerPrefs.GetInt(ScoreManager.HIGH_SCORE_KEY, 0);

        highScoreText.text = $"High Score {highScore}";
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }


    
}
