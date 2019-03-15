using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinFound : MonoBehaviour { 
public GameObject currentInterObj = null;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("coin")) {
            Debug.Log(other.name);
            currentInterObj = other.gameObject;

        }
      
    }
    void onTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("coin"))
        {
            if(other.gameObject == currentInterObj)
            {
                currentInterObj = null;
            }
        }
    }
}
