using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIManager : MonoBehaviour
{

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
