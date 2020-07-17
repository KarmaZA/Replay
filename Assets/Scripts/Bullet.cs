using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject HitEffect;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Hit Script here
        if (collision.gameObject.tag != "Player") { 
            GameObject effect = Instantiate(HitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 1f);
            Destroy(gameObject);
            //Debug.Log(collision.gameObject.tag);
        }
        

    }
}
