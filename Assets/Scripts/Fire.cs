using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    //public GameObject hitEffect;

    public float bulletForce = 20f;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            DestroySelf();
        }
        else
        {
            DestroySelf();
        }

        if (collision.gameObject.GetComponent<WallMovement>())
        {
            collision.gameObject.GetComponent<WallMovement>().enabled = true;
            DestroySelf();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<IceCrystal>())
        {
            DestroySelf();
        }
    }

    public void DestroySelf()
    {
        //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        //Destroy(effect, 5f);
        Destroy(gameObject);
    }
}
