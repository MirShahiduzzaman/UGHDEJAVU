using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinFound : MonoBehaviour
{
    private GameObject currentInterObj = null;

    private bool searchingForPlayer = false;
    public static AudioClip Bonus, Click;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        Bonus = Resources.Load<AudioClip>("Bonas");
        Bonus = Resources.Load<AudioClip>("Click");
        audioSrc = GetComponent<AudioSource>();
    }
    public static void getCoin (string clip)
    {
       
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("sound");
        audioSrc.PlayOneShot(Bonus);
        if (other.CompareTag("coin"))
        {
            currentInterObj = other.gameObject;
            Destroy(other.gameObject);
            Score.addToScore();
        }
        else
        {
            if (other.CompareTag("Enemy"))
            {
                audioSrc.PlayOneShot(Click);
                Debug.Log("");
            }
           
        }
    }


}