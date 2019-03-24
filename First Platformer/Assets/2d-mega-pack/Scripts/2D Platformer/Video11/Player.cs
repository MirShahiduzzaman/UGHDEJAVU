using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	[System.Serializable]
	public class PlayerStats {
		public int Health = 100;
	}

	public PlayerStats playerStats = new PlayerStats();

	public int fallBoundary = -20;
    private Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

	void Update () {
		if (transform.position.y <= fallBoundary)
			DamagePlayer (9999999);
	}

	public void DamagePlayer (int damage) {
		playerStats.Health -= damage;
		if (playerStats.Health <= 0) {
			GameMaster.KillPlayer(this);
		}
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            Score.addToScore();
        }
        else
        {
            if (other.CompareTag("Enemy"))
            {
                //DamagePlayer(9999999);
                Debug.Log("OUCH!!");
                Application.LoadLevel(scene.name);
            }
            else
            {
                if (other.CompareTag("Finish"))
                {
                    Debug.Log("WE'RE DONE!!!");
                }
            }
        }

    }
}
