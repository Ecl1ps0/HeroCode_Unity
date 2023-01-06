using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager
    {
        get; 
        private set;
    }

    public UnitsHealth _playerHealth = new UnitsHealth(100, 100);

    public UnitsHealth _minotaurHealth = new UnitsHealth(100, 100);

    void Awake()
    {
        if(gameManager != null && gameManager != this)
        {
            Destroy(this); 
        }
        else
        {
            gameManager = this;
        }
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadPreviousScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
