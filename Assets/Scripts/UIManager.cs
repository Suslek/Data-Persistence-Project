using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIManager : MonoBehaviour
{
    public Text CurrentHighScore;

    public void Update()
    {
        if (NameScoreHandler.Instance.highScore > 0)
        {
            CurrentHighScore.text = $"Current High Score : {NameScoreHandler.Instance.highScorePlayerName} - {NameScoreHandler.Instance.highScore}";
        }
        else
        {
            CurrentHighScore.text = $"High Score is not set";
        }
    }

    public void OnStartPress()
    {
        SceneManager.LoadScene(1);
    }

    public void OnExitPress()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void OnNameEnter(string name)
    {
        NameScoreHandler.Instance.currentPlayerName = name;
    }
}
