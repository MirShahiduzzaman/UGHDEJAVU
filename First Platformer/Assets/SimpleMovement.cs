using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float speed = 10f;
    public float distance;
    private float relDistance = 0f;

    private bool movingRight = true;
    public bool vertical = false;

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

            relDistance++;

            if (relDistance >= distance)
            {
                if (movingRight == true)
                {
                    transform.eulerAngles = new Vector3(0, -180, 0);
                    movingRight = false;
                }
                else
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                    movingRight = true;
                }
                relDistance = 0f;
            }
        }
        else
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);

            relDistance++;

            if (relDistance >= distance)
            {
                if (movingRight == true)
                {
                    transform.eulerAngles = new Vector3(-180, 0, 0);
                    movingRight = false;
                }
                else
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                    movingRight = true;
                }
                relDistance = 0f;
            }
        }
    }
}
