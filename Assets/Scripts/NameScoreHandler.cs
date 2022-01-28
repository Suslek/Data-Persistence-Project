using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class NameScoreHandler : MonoBehaviour
{
    public static NameScoreHandler Instance;

    public string currentPlayerName;
    public string highScorePlayerName;
    public int highScore;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadHighScore();
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
        SaveHighScore();
    }

    [System.Serializable]
    class SaveData
    {
        public string name;
        public int score;
    }

    public void SaveHighScore()
    {
        SaveData data = new SaveData();
        data.name = highScorePlayerName;
        data.score = highScore;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            highScorePlayerName = data.name;
            highScore = data.score;
        }
    }
}
