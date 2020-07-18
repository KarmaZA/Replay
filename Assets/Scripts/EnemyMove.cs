using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public Transform player;
    public Vector2 LookDir;
    public Rigidbody2D rb;
    public static float moveSpeed = 5f;
    //public bool

    private void Start()
    {
        moveSpeed += 0.01f;
    }

    void Update()
    {
        rb = this.GetComponent<Rigidbody2D>();
        // Vector2 LookDir;


        LookDir.x = player.position.x - rb.position.x;// -0.5f;
        LookDir.y = player.position.y - rb.position.y;// -0.5f;

        float angle = Mathf.Atan2(LookDir.y, LookDir.x) * Mathf.Rad2Deg + 270f;
        rb.rotation = angle;
    }
    private void FixedUpdate()
    {
        //rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);


        LookDir.Normalize();
        MoveChar(LookDir);
        //Debug.Log(player.position);

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
