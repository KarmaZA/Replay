using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    private Rigidbody2D player;
    public Vector2 LookDir;
    public Rigidbody2D rb;
    public static float moveSpeed = 5f;
    //public bool
    bool Delay = false;

    private void Start()
    {
        player = FindObjectOfType<Playermove>().GetRB();
        moveSpeed += 0.01f;
        StartCoroutine(Target_PLayer());
    }

    IEnumerator Target_PLayer()
    {
        yield return new WaitForSeconds(2f);
        Delay = true;
    }

    void Update()
    {
        rb = this.GetComponent<Rigidbody2D>();
        // Vector2 LookDir;


        if (Delay) { 
            LookDir.x = player.position.x - rb.position.x;
            LookDir.y = player.position.y - rb.position.y;
        } else
        {
            LookDir.x = 0 - rb.position.x;
            LookDir.y = 0 - rb.position.y;
        }

        float angle = Mathf.Atan2(LookDir.y, LookDir.x) * Mathf.Rad2Deg + 270f;
        rb.rotation = angle;
    }
    private void FixedUpdate()
    {
        LookDir.Normalize();
        MoveChar(LookDir);
    }

    void MoveChar(Vector2 direction)
    {   
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.fixedDeltaTime));

    }
    
    public void ShotDead()
    {
        Destroy(this, 0f);
    }
}
