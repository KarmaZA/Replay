using System.Collections;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector2 = UnityEngine.Vector2;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public GameObject Pickup;
    [SerializeField]
    private Vector2[] SpawnPoints;
    public static float Spawn_Delay = 5f;
    bool spawn = false;
    private void Start()
    {
        Spawn_Delay -= 0.1f;
        if(Spawn_Delay < 2) { Spawn_Delay = 2.4f; }
    }
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
        for (int x = 0; x < 4; x++)
        {
            Instantiate(enemy, SpawnPoints[x], Quaternion.identity);
        }
        Instantiate(Pickup, new Vector2(Random.Range(-25.5f, 27.5f), Random.Range(-16.5f, 19.5f)), Quaternion.identity);
        yield return new WaitForSeconds(Spawn_Delay);
        StartCoroutine(Spawn());
    }
}
