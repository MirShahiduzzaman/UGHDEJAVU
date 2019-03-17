using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;

    private bool searchingForPlayer = false;

    // Start is called before the first frame update
    void Start()
    {
        
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

        scoreText.text = "Score" + " " + " " + " " + " " + " " + player.position.x.ToString("0");
        
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
}
