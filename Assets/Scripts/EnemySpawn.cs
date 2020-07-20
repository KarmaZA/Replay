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
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(Spawn_Delay);
        for (int x = 0; x < 5; x++)
        {
            Instantiate(enemy, SpawnPoints[x], UnityEngine.Quaternion.identity);
        }
    }
}
