using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static float enemies_killed = 0f;
    public static float Total_enemiesKilled = 0f;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "Score : " + Total_enemiesKilled;
    }
    public void KillEnemy()
    {
        //Debug.Log(enemiesKilled);
        Total_enemiesKilled += 1;
        enemies_killed += 1;
        text.text = "Score : " + Total_enemiesKilled;       
    }
    public int GetBullets()
    {
        int x = (int) enemies_killed;
        if(x == 0) { x = 2; }
        enemies_killed = 0;
        return x;
    }
    public void Replay()
    {
        SceneManager.LoadScene(1);
    }
    public void EndGame()
    {
        SceneManager.LoadScene(2);
    }
}
