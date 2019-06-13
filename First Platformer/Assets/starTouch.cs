using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class starTouch : MonoBehaviour
{
    AudioSource Game, Star;
    private void Start()
    {
       Star = GameObject.Find("Star").GetComponent<AudioSource>();
       
       Game = GameObject.Find("Game").GetComponent<AudioSource>();
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Game.pitch = -2.62f;
            Star.volume = .15f;
            Star.Play();
            Score.addToScore(3000);
            Destroy(gameObject);

        }


    }


}