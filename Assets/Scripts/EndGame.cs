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
        try
        {
            button.onClick.AddListener(EndTheGame);
        }
        catch
        {
            Debug.LogError("Button Null Pointer exception");
        }
    }
    void EndTheGame()
    {
        //LevelNumTrack.Level = 1;
        //Debug.Log(LevelNumTrack.Level);
        Application.Quit();

        //Debug.Log(LevelNumTrack.Level);
    }
}
