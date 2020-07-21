using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static float enemyNum = 2f;
    public float enemies_killed = 4f;
    public static float Total_enemiesKilled = 0f;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        //LevelNumTrack.Level * 2;
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
        int x = (int)enemies_killed;
        if(x == 0) { x = 1; }
        enemies_killed = 0;
        return x;
    }
    public void Replay()
    {
        //Majkor mechanic
        Debug.Log("Repaly");
    }
    public void endGame()
    {
        SceneManager.LoadScene(2);
    }
}
