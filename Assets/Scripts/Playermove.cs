using UnityEngine;


public class Playermove : MonoBehaviour
{

    public Rigidbody2D rb;
    public float MoveSpeed = 5f;
    public Camera cam;
    //public Animator animator;

    Vector2 movement;
    Vector2 mousePos;
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        /*animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.magnitude);*/
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * MoveSpeed * Time.deltaTime);
        rb.velocity = Vector2.zero;

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;// - 90f;
        rb.SetRotation(angle);
    }
}
