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
    public Text Round;
    public static int Replay_Count = 1;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "Score : " + Total_enemiesKilled;
        Round.text = "Round: " + Replay_Count;
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
        int x = (int)(Total_enemiesKilled + 1) / Replay_Count;
        x += (int) enemies_killed;
        enemies_killed = 0;
        if (x == 0) { x = 1; }
        return x;
    }
    public void Replay()
    {
        Replay_Count += 1;
        SceneManager.LoadScene(1);
    }
    public void EndGame()
    {
        SceneManager.LoadScene(2);
    }
    public void Reset()
    {
        enemies_killed = 0f;
        Total_enemiesKilled = 0f;
    }
}
