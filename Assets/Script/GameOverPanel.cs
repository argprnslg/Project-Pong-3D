using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverPanel : MonoBehaviour
{
    public Text playerWin;
    public ScoreManager manager;

    public void Update()
    {
        playerWin.text = manager.playerWinner;
    }
}
