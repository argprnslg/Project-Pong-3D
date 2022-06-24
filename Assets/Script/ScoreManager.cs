using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int ScoreplayerKanan;
    public int ScoreplayerKiri;
    public int ScoreplayerBawah;
    public int ScoreplayerAtas;
    public int MaxScore;
    public string playerWinner;
    public BallControll ball;
    public GameObject tembokKanan;
    public GameObject tembokKiri;
    public GameObject tembokBawah;
    public GameObject tembokAtas;
    public GameObject playerKanan;
    public GameObject playerKiri;
    public GameObject playerBawah;
    public GameObject playerAtas;
    public GameObject GameOverPanel;
    public bool isRight = true;
    public bool isLeft = true;
    public bool isDown = true;
    public bool isUp = true;
    public int sumPlayer = 4;


    private void Update()
    {
        GameOver();
    }

    public void AddScoreplayerKanan(int increment)
    {
        ScoreplayerKanan += increment;

        if (ScoreplayerKanan >= MaxScore)
        {
          
            tembokKanan.SetActive(true);
            playerKanan.SetActive(false);
            sumPlayer -= 1;
            isRight = false;
        }
    }

    public void AddScoreplayerKiri(int increment)
    {
        ScoreplayerKiri += increment;

        if (ScoreplayerKiri >= MaxScore)
        {
            
            tembokKiri.SetActive(true);
            playerKiri.SetActive(false);
            sumPlayer -= 1;
            isLeft = false;
           
        }
    }

    public void AddScoreplayerBawah(int increment)
    {
        ScoreplayerBawah += increment;

        if (ScoreplayerBawah >= MaxScore)
        {
           
            tembokBawah.SetActive(true);
            playerBawah.SetActive(false);
            sumPlayer -= 1;
            isDown = false;
          
        }
    }

    public void AddScoreplayerAtas(int increment)
    {
        ScoreplayerAtas += increment;

        if (ScoreplayerAtas >= MaxScore)
        {
            
            tembokAtas.SetActive(true);
            playerAtas.SetActive(false);
            sumPlayer -= 1;
            isUp = false;
        
        }
    }

    public void GameOver()
    {
        if (sumPlayer == 1)
        {
            if (isRight)
            {
                playerWinner = "PLAYER 3 WIN";
                GameOverPanel.SetActive(true);
            }
            if (isLeft)
            {
                playerWinner = "PLAYER 2 WIN";
                GameOverPanel.SetActive(true);
            }
            if (isDown)
            {
                playerWinner = "PLAYER 1 WIN";
                GameOverPanel.SetActive(true);
            }
            if (isUp)
            {
                playerWinner = "PLAYER 4 WIN";
                GameOverPanel.SetActive(true);
            }
        }
    }
}
