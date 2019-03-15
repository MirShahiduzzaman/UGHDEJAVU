using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinFound : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("coin")) {
            Debug.Log(other.name);
        }
      
    }
}
