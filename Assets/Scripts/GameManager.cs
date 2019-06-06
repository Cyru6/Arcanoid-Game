using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int lives;
    public int score;
    public Text livesText;
    public Text scoreText;
    public bool gameOver;
    public GameObject gameOverPanel;
    public GameObject winPanel;
    public int numberOfBricks;

    void Start()
    {
        livesText.text = "Lives: " + lives;
        scoreText.text = "Score " + score;
        numberOfBricks = GameObject.FindGameObjectsWithTag ("Brick").Length;
    }

    public void UpdateLives(int changeInLives)
    {       
        lives += changeInLives;
        if (lives <= 0)
        {
            lives = 0;
            GameOver();
        }

        livesText.text = "Lives: " + lives;
    }

    public void UpdateScore(int changeInScore)
    {
        score += changeInScore;
        scoreText.text = "Score: " + score;
    }

    public void UpdateNumberOfBricks()
    {
        numberOfBricks--;
        if (numberOfBricks<=0)
        {
            Win();
            //if (currentLevelIndex >=levels.Length - 1)
            //{
              //  GameOver();
            //}
           // else
           // {
           //     loadLevelPanel.SetActive(true);
            //    gameOver = true;
          //      Invoke("LoadLevel", 3f);
            //}
        }
    }

    void GameOver()
    {
        gameOver = true;
        gameOverPanel.SetActive (true);
    }

    void Win()
    {
        gameOver = true;
        winPanel.SetActive (true);
    }
}
