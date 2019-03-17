using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text Timer;

    // Start is called before the first frame update
    void Start()
    {
        Timer = transform.FindChild("Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
       Timer.text = string.Format("Time left: {0}", )
        
    }
}
