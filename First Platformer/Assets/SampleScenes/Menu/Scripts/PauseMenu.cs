using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    private Scene scene;

    private Toggle m_MenuToggle;
	private float m_TimeScaleRef = 1f;
    private float m_VolumeRef = 1f;
    private bool m_Paused;


    void Awake()
    {
        m_MenuToggle = GetComponent <Toggle> ();
	}

    public void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    private void MenuOn ()
    {
        m_TimeScaleRef = Time.timeScale;
        Time.timeScale = 0f;

        m_VolumeRef = AudioListener.volume;
        AudioListener.volume = 0f;

        m_Paused = true;
    }


    public void MenuOff ()
    {
        Time.timeScale = m_TimeScaleRef;
        AudioListener.volume = m_VolumeRef;
        m_Paused = false;
    }


    //public void OnMenuStatusChange ()
    //{
    //    if (m_MenuToggle.isOn && !m_Paused)
    //    {
    //        MenuOn();
    //    }
    //    else if (!m_MenuToggle.isOn && m_Paused)
    //    {
    //        MenuOff();
    //    }
    //}

    void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape) && !Player.GetDone())
		{
		    if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
		}
	}

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Debug.Log("Resumed");
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Debug.Log("Paused");
    }

    public void RestartGame()
    {
        pauseMenuUI.SetActive(false);
        Debug.Log("Restarting..");
        Time.timeScale = 1f;
        Application.LoadLevel(scene.name);
        Score.setScore(0);
        timer.resetTimer();
        GameIsPaused = false;
    }

    public static void QuitGame()
    {
        Debug.Log("Quitting Game..");
        Application.Quit();
    }
}
