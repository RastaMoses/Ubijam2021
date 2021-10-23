using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firebolt : MonoBehaviour
{
    //public GameObject hitEffect;
    int bounces = 0;

    public float bulletForce = 20f;
    Vector3 lastVelocity;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        lastVelocity = rb.velocity;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            bounces++;
            if(bounces < 3)
            {
                var speed = lastVelocity.magnitude;
                var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

                rb.velocity = direction * Mathf.Max(speed, 2f);
            }
            else
            {
                DestroySelf();
            }
        }
        else
        {
            DestroySelf();
        }
        
        if(collision.gameObject.GetComponent<WallMovement>())
        {
            collision.gameObject.GetComponent<WallMovement>().enabled = true;
            DestroySelf();
        }
        if (collision.gameObject.GetComponent<Pathfinding.AIPath>())
        {
            collision.gameObject.GetComponent<Pathfinding.AIPath>().enabled = true;
            DestroySelf();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<IceCrystal>())
        {
            DestroySelf();
        }
        else if (collision.gameObject.GetComponent<FireCrystal>())
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
