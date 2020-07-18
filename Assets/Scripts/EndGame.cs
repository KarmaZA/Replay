using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
            button.onClick.AddListener(EndTheGame);
    }
    void EndTheGame()
    {
        Application.Quit();
    }
}
