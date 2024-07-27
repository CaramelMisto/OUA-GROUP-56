using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    private float savedTimeScale = 1f;
    public void Pause() { 
        pauseMenu.SetActive(true);
        savedTimeScale=Time.timeScale;
        Time.timeScale = 0f;
    }

    public void Home() {
        SceneManager.LoadScene("EntryScene");
        Time.timeScale = 1f;
    }

    public void Resume() {
        pauseMenu.SetActive(false);
        Time.timeScale = savedTimeScale;
    }

    public void Restart() {
        SceneManager.LoadScene("Gameplay");
        Time.timeScale = 1f;
    }
}
