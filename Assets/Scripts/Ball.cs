using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayStart());    
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(5f, 5f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<LevelController>().DecreaseLives();
        Destroy(gameObject);
    }

    IEnumerator DelayStart()
    {
        yield return new WaitForSeconds(1);
        GetComponent<Rigidbody2D>().AddForce(new Vector2(250f, 250f));
    }
}
