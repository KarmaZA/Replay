using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    [SerializeField]
    private Vector2[] SpawnPoints;
    public float Spawn_Delay = 5f;
    bool spawn = false;
    // Start is called before the first frame update
    public void startSpawning()
    {
        if (!spawn)
        {
            StartCoroutine(Spawn());
            spawn = true;
        }
    }
    public void StopSpawning()
    {
        StopCoroutine(Spawn());
        spawn = false;
    }
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(Spawn_Delay);
        for (int x = 0; x < 4; x++)
        {
            Instantiate(enemy, SpawnPoints[x], UnityEngine.Quaternion.identity);
        }
        StartCoroutine(Spawn());
    }
}
