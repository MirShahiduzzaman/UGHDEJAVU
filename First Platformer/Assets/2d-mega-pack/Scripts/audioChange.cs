using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioChange : MonoBehaviour
{
    public static AudioSource Bonus, Click, Game;
  
    // Start is called before the first frame update
    void Start()
    {

    }
    public static void playSound(string clip)
    {
        switch (clip)
        {
            case "Bonus":
        
                Bonus.Play();
                break;
            case "Click":

                Click.Play();
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
