using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class winMenu : MonoBehaviour
{
    public Text winText;

    public GameObject winMenuUI;
    private Scene scene;

    private float m_TimeScaleRef = 1f;
    private float m_VolumeRef = 1f;
    private bool m_Paused;

    public void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    void Update()
    {
        if (Player.getDone())
        {
            winText.text = "Congrats! You won with " + Score.getScore() + "pts in __ sec. Can you do better?";
            Win();
        }
    }

    public void Win()
    {
        winMenuUI.SetActive(true);
        Time.timeScale = 0f;
        PauseMenu.GameIsPaused = true;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        Application.LoadLevel(scene.name);
        Score.setScore(0);
        timer.resetTimer();
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game..");
        Application.Quit();
    }
}
