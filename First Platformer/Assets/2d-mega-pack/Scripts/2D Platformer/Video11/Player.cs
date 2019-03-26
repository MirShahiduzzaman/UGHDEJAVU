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
    private static bool done;

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
                Debug.Log("OUCH!!");
                DamagePlayer(9999);
            }
            else
            {
                if (other.CompareTag("Finish"))
                {
                    done = true;
                    Debug.Log("WE'RE DONE!!!");
                }
            }
        }

    }

    public static bool GetDone()
    {
        return (done);
    }

    public static void SetDone(bool val)
    {
        done = val;
    }
}
