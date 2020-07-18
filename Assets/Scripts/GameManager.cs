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

    // Update is called once per frame
    void Update()
    {
        //if ((enemiesKilled > enemyNum))// || (enemiesKilled == 2 && (FindObjectOfType<Enemy>() != null)))
        /*GameObject[] checkEnemy = GameObject.FindGameObjectsWithTag("Enemy");
        
        if (checkEnemy.Length == 0)
        {
            int sceneNum = SceneManager.GetActiveScene().buildIndex;
            if(sceneNum == 2) // 2 because the are only 2 level so far
            {
                sceneNum = 1;
            } else
            {
                sceneNum += 1;
            }

            enemyNum += 2;
            //Debug.Log(enemiesKilled + " and num " + enemyNum);
            //enemiesKilled = 0;
            
            SceneManager.LoadScene(sceneNum);
        }*/
    }

    public void KillEnemy()
    {
        //Debug.Log(enemiesKilled);
        Total_enemiesKilled += 1;
        enemies_killed += 1;
        text.text = "Score : " + Total_enemiesKilled;
        
    }

    public void GameOver()
    {
        Debug.Log("GameOver");
        enemyNum = 2f;
        EnemyMove.moveSpeed = 4f;
        Debug.Log(enemyNum);
        SceneManager.LoadScene(3);
    }

    public int GetBullets()
    {
        int x = (int)enemies_killed;
        enemies_killed = 0;
        return x;
    }

    public void Replay()
    {
        //Majkor mechanic
        Debug.Log("End game");
    }
}
