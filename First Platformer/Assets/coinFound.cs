using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinFound : MonoBehaviour { 
public GameObject currentInterObj = null;
    private double portalLoc;

    public Transform player;
    public Text scoreText;

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
            scoreText.text = "Score" + " " + " " + " " + " " + " " + ((int)player.position.x).ToString();
        }
        else
        {
            scoreText.text = "Score" + " " + " " + " " + " " + " " + ((int)(portalLoc - (player.position.x - portalLoc))).ToString();
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
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("coin")) {

            currentInterObj = other.gameObject;
            Destroy(other.gameObject);
        }
      
    }

    
}
