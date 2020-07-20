using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject BulletPre;

    public float bulletSpeed = 20f;
    public int bullet_Count = 0;
    public Text bullet_text;

    private void Start()
    {
        bullet_Count = FindObjectOfType<GameManager>().GetBullets();
    }

    void Update()
    {
        //bullet_Count = FindObjectOfType<GameManager>().GetBullets();
        if (Input.GetButtonDown("Fire1"))
        {
            if (bullet_Count > 0)
            {
                Shoot();
            }
        }
        bullet_text.text = "Bullets: " + bullet_Count;
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(BulletPre, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * bulletSpeed, ForceMode2D.Impulse);
        bullet_Count -= 1;
    }
}
