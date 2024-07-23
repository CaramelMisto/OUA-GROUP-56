using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public void Pause() { 
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Home() {
        SceneManager.LoadScene("EntryScene");
        Time.timeScale = 1f;
    }

    public void Resume() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Restart() {
        SceneManager.LoadScene("Gameplay");
        Time.timeScale = 1f;
    }
}
