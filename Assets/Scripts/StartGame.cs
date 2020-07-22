using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    { 
        button.onClick.AddListener(LoadNextLevel);
    }
    void LoadNextLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0) {
            FindObjectOfType<GameManager>().Reset();
        }
        SceneManager.LoadScene(1);
    }
}
