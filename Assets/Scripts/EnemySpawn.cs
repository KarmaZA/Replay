using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public float xOffset = 5f;
    public Camera cam;
    public static float EnemyNum =0f;

    public bool SpawnEnabled = true;
    // Start is called before the first frame update
    void Start()
    {
        EnemyNum = GameManager.enemyNum;

        //Debug.Log(EnemyNum + "here"); 
        Invoke("Spawn", 0f);
    }

    void Spawn()
    {
        if (SpawnEnabled)
        {
            for (int x = 0; x < EnemyNum;x++)// (2 * LevelNumTrack.Level); x++)
                {
                float num = Random.Range(-25f, 25f);
                UnityEngine.Vector2 moSp = SpawnPoint(num);
                GameObject enem = Instantiate(enemy, moSp, UnityEngine.Quaternion.identity);
                enem.SetActive(true);
                //Destroy(enem, 4f);
            }
           // LevelNumTrack.Level = LevelNumTrack.Level + 1;
        }
    }

    UnityEngine.Vector2 SpawnPoint(float x){
        UnityEngine.Vector2 toRe;
        toRe.x = x;
        toRe.y = Mathf.Pow(x, 2f) * -0.03f + 15f;
        //Debug.Log(toRe);
        return toRe;
    }
    
}
