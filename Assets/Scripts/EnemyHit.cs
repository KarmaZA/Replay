using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag =="Enemy")
        {
            Destroy(this, 0f);
            collisionInfo.collider.gameObject.SetActive(false);// = false;
            FindObjectOfType<GameManager>().KillEnemy();
            //Debug.Log("dead");
        }

    }
}

