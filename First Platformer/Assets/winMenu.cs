using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class winMenu : MonoBehaviour
{
    public Text winText;
    AudioSource Game, End;
    public GameObject winMenuUI;
    private Scene scene;

    private float m_TimeScaleRef = 1f;
    private float m_VolumeRef = 1f;
    private bool m_Paused;

    public void Start()
    {
        scene = SceneManager.GetActiveScene();
        End = GameObject.Find("Win").GetComponent<AudioSource>();
        Game = GameObject.Find("Game").GetComponent<AudioSource>();


    }

    void Update()
    {
        if (Player.GetDone())
        {
           End.volume = .15f;
            Game.Stop();
           End.Play();
            winText.text = "Congrats! You won with " + Score.getScore() + " pts in " + timer.getSec() + " sec. Can you do better?";
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
        Player.SetDone(false);
        winMenuUI.SetActive(false);
        Debug.Log("Restarting..");
        Time.timeScale = 1f;
        Application.LoadLevel(scene.name);
        Score.setScore(0);
        timer.resetTimer();
        PauseMenu.GameIsPaused = false;
    }

    public void QuitGame()
    {
        PauseMenu.QuitGame();
    }
}
