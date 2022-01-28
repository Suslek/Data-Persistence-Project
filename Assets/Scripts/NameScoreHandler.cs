using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameScoreHandler : MonoBehaviour
{
    public static NameScoreHandler Instance;

    public string currentPlayerName;
    public string highScorePlayerName;
    public int highScore;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }


    public void TryChangeHighScore(int newHighScore)
    {
        if (newHighScore > highScore)
        {
            highScorePlayerName = currentPlayerName;
            highScore = newHighScore;
        }
    }

    public void ResetHighScore()
    {
        highScorePlayerName = "";
        highScore = 0;
    }
}
