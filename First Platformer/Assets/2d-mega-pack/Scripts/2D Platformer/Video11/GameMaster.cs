using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {

    public static GameMaster gm;
    private Scene scene;
    public Animator transitionAnim;

    void Start()
    {
        scene = SceneManager.GetActiveScene();

        if (gm == null)
        {
            gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        }
    }

    public Transform playerPrefab;
    public Transform spawnPoint;
    public int spawnDelay = 1;

    public IEnumerator RespawnPlayer ()
    {
        Debug.Log("TODO: Waiting fir spawn sound");
        yield return new WaitForSeconds(spawnDelay);
        Time.timeScale = 0f;
        Application.LoadLevel(scene.name);
        Time.timeScale = 1f;

        //deathCount.UpdateDeathCount();
        Score.setScore(0);
        timer.resetTimer();
    }

    public static void KillPlayer(Player player) {
        Destroy(player.gameObject);
        gm.StartCoroutine(gm.RespawnPlayer());
    }
}