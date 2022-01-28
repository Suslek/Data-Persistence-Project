using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    public Text highScoreText;

    // Update is called once per frame
    void Update()
    {
        highScoreText.text = $"High Score : {NameScoreHandler.Instance.highScorePlayerName} : {NameScoreHandler.Instance.highScore}";
    }
}
