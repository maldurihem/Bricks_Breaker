using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float x;
    public float y;

    // Start is called before the first frame update
    void Start()
    {
        
        transform.position = new Vector2(0f, -4.5f);


    }

    // Update is called once per frame
    void Update()
    {
        
        GetComponent<SpriteRenderer>().color = Color.white;

        if (Input.GetKey("left") && transform.position.x > -5.5f)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-10f, 0f);
        }
        else if (Input.GetKey("right") && transform.position.x < 5.5f)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(10f, 0f);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(0,0,10);
            GetComponent<SpriteRenderer>().color = Color.green;
        }

        

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(0, 0, -10);
            GetComponent<SpriteRenderer>().color = Color.green;
        }

        

    }

    public void TransformPaddle()
    {
        x = GetComponent<Transform>().position.x;
        y = GetComponent<Transform>().position.y;
        transform.position = new Vector2(x, y + 0.5f);
        Debug.Log(x);
        Debug.Log(y);
    }

    public void ResetPaddle()
    {
        transform.position = new Vector2(0f, -4.5f);
    }

    
}
