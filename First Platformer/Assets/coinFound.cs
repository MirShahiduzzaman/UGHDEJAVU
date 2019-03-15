using UnityEngine;
using System.Collections;

public class CompletePlayerController : MonoBehaviour
{

  


    // Use this for initialization
    void Start()
    {
     
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

    public static void killCoin(Resources resource)
    {
        //Destroy coin
    }

    /**public static void KillPlayer(Player player)
    {
        Destroy(player.gameObject);
        gm.StartCoroutine(gm.RespawnPlayer());
    }*/

    //OnTriggerEnter2D is called whenever this object overlaps with a trigger collider.

}