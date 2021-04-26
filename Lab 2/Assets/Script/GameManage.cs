using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManage : MonoBehaviour
{
    public bool isGameActive;
    public TextMeshProUGUI scoreText;
    private int score;
    private SpawnManager spawnManager;
    public Button startButton;

    void Start()
    {
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

  
    public void startGame(int startGame)
    {
        score = 0;
        isGameActive = true;
    }

    public void GameOver()
    {
        isGameActive = false;
    }



    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score:" + score;
    }
}
   