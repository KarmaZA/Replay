using UnityEngine;


public class Playermove : MonoBehaviour
{

    public Rigidbody2D rb;
    public float MoveSpeed = 15f;
    public Camera cam;
    //public Animator animator;
    bool Spawning = false;

    Vector2 movement;
    Vector2 mousePos;
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        if (!Spawning && rb.position.x > -25)
        {
            FindObjectOfType<EnemySpawn>().startSpawning();
            Spawning = true;
        }
        if(Spawning && rb.position.x < -25)
        {
            Debug.Log("agaain");
            Spawning = false;
            FindObjectOfType<GameManager>().Replay();
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * MoveSpeed * Time.deltaTime);
        rb.velocity = Vector2.zero;

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg + 90f;
        rb.SetRotation(angle);
    }

    public Rigidbody2D GetRB() { return rb; }

}
