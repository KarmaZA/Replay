using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerhit : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            //Destroy(this, 0f);
            //collisionInfo.collider.gameObject.SetActive(false);// = false;
            FindObjectOfType<GameManager>().GameOver();
            //Debug.Log("dead");
        }

    }
}
