using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private double portalLoc;
    public Transform player;
    public Text scoreText;
    private static int addScore = 0;

    private bool searchingForPlayer = false;

    // Start is called before the first frame update
    void Start()
    {
        portalLoc = GameObject.FindGameObjectWithTag("Finish").transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (player == null)
        {
            if (!searchingForPlayer)
            {
                searchingForPlayer = true;
                StartCoroutine(SearchForPlayer());
            }
            return;
        }

        if (player.position.x < portalLoc)
        {
            scoreText.text = "Score" + " " + " " + " " + " " + " " + ((int)(player.position.x + addScore)).ToString();
        }
        else
        {
            scoreText.text = "Score" + " " + " " + " " + " " + " " + ((int)(portalLoc - (player.position.x - portalLoc) + addScore)).ToString();
        }
        
    }

    IEnumerator SearchForPlayer()
    {
        GameObject sResult = GameObject.FindGameObjectWithTag("Player");

        if (sResult == null)
        {
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(SearchForPlayer());
        }
        else
        {
            player = sResult.transform;
            searchingForPlayer = false;

            yield return false;
        }
    }

    public static void addToScore()
    {
        addScore += 1000;
    }
}
