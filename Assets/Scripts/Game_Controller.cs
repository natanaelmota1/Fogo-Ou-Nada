using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Controller : MonoBehaviour
{
    public int TotalScore;
    public Text scoreText;
    public GameObject gameOver;
    public static Game_Controller instance;
    void Start()
    {
        instance = this;
    }

    public void UpdateScoreText()
    {
        scoreText.text = TotalScore.ToString();
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
    }

    public void RestartCurrentLevel()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NextLevel(string nextLevel)
    {
        SceneManager.LoadScene(nextLevel);
    }
}
