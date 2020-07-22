using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCollider : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(TimeOut());
    }

    IEnumerator TimeOut()
    {
        yield return new WaitForSeconds(10f);
        if (gameObject.activeSelf)
        {
            Destroy(this.gameObject, 0f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<Shooting>().GetPickUp();
            Destroy(this.gameObject, 0f);
        }
    }
}
