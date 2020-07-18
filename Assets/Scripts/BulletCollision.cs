using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Hit");
        }
        if (collision.collider.gameObject.CompareTag("Enemy"))
        {
            //Inc Score
            FindObjectOfType<GameManager>().KillEnemy();
            Destroy(collision.collider.gameObject, 0f);
            Destroy(this.gameObject, 0f);
        }
    }
}
