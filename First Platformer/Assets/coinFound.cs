using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinFound : MonoBehaviour { 
public GameObject currentInterObj = null;

    public void OnTriggerEnter2D(Collider2D other)

    {
       
        if (other.CompareTag("coin")) {

            currentInterObj = other.gameObject;
            Destroy(other.gameObject);

        }
      
    }

    
}
