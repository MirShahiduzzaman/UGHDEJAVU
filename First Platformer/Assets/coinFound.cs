using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinFound : MonoBehaviour
{
    private GameObject currentInterObj = null;
    AudioSource Bonus, Click;
   
    private bool searchingForPlayer = false;
   
    // Start is called before the first frame update
    void Start()
    {
        Bonus = GameObject.Find("Bonus").GetComponent<AudioSource>();
        Bonus.volume = .15f;

      
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("HELP");
        if (other.CompareTag("Player"))
        {
            Debug.Log("P");

            Bonus.Play();
            Score.addToScore();
            Destroy(gameObject);
           
        }


    }
}