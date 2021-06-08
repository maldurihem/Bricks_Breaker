using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    int brickCount;
    // Start is called before the first frame update
    void Start()
    {
        CountAllBrick();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CountAllBrick()
    {
        Brick[] allBricksInLevel = FindObjectsOfType<Brick>();
        brickCount = allBricksInLevel.Length;
    }

    public void DeductBrick()
    {
        brickCount--;

        if(brickCount <= 0)
        {
            LoadNextLevel();
        }
    }

    private void LoadNextLevel()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex + 1);
    }
}
