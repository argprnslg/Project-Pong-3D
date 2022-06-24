using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text skorPlayerKanan;
    public Text skorPlayerKiri;
    public Text skorPlayerBawah;
    public Text skorPlayerAtas;

    public ScoreManager manager;

    private void Update()
    {
        skorPlayerKanan.text = manager.ScoreplayerKanan.ToString();
        skorPlayerKiri.text = manager.ScoreplayerKiri.ToString();
        skorPlayerBawah.text = manager.ScoreplayerBawah.ToString();
        skorPlayerAtas.text = manager.ScoreplayerAtas.ToString();
    }
}
