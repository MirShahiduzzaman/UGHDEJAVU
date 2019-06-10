using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class starTouch : MonoBehaviour
{
    private GameObject currentInterObj = null;

    private bool searchingForPlayer = false;
    Camera m;
    Aud = m.getComponent()
    // Start is called before the first frame update
    void Start()
    {
       m.Stop();
     
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
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
                Debug.Log("");
            }

        }
    }


}