using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float speed = 300f;
    public float distance;
    private float relDistance = 0f;

    private bool movingRight = true;
    public bool vertical = false;

    public Transform groundDetection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!vertical)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        relDistance++;
            
        if((relDistance >= distance && movingRight) || (relDistance >= (2 * distance) && !movingRight))
        {
            if(movingRight == true)
            {
                transform.eulerAngles = new Vector3(0,-180,0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0,0,0);
                movingRight = true;
            }
            relDistance = 0f;
        }
    }
}
