using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField] int health = 1;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = Color.yellow;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<LevelController>().IncreaseScore();
        DecreaseHealth();
        
    }

    private void DecreaseHealth()
    {
        health--;

        if(health <= 0)
        {
            FindObjectOfType<LevelLoader>().DeductBrick();
            Destroy(gameObject);
        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
    }

}
