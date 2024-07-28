using System.IO;
using TMPro;
using UnityEngine;

namespace GameManager
{
    public class Savings : MonoBehaviour
    {
        static string filePath = "GameSave.json";

        public static SaveObject savedObject;

        [SerializeField] TextMeshProUGUI HiScore;

        private void Awake()
        {
            Load();
            HiScore.text = "HI Score : " + savedObject.highScore;
        }

        static public void Save()
        {
            try
            {
                string json = JsonUtility.ToJson(savedObject, true);
                File.WriteAllText(filePath, json);
                Debug.Log("Game saved successfully.");
            }
            catch (System.Exception ex)
            {
                Debug.LogError($"Failed to save game: {ex.Message}");
            }
        }

        static public void Load()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    SaveObject saveObject = JsonUtility.FromJson<SaveObject>(json);
                    Debug.Log("Game loaded successfully.");
                    savedObject = saveObject;
                }
                else
                {
                    Debug.LogWarning("Save file does not exist.");
                    savedObject = new SaveObject();
                }
            }
            catch (System.Exception ex)
            {
                Debug.LogError($"Failed to load game: {ex.Message}");
                savedObject = new SaveObject();
            }
        }


    }

    public class SaveObject
    {
        public int lastScore;
        public int highScore;
        public int coins;
        public bool[] owningChars;
        public int selectedChar;
        public float moveSpeed;
        public float engelZamani;
    }
}