using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rat : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool isFrozen = false;
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<Firebolt>())
        {            
            GetComponentInParent<RatSwarm>().StartBurn();
            rb.velocity = Vector2.zero;
        }

        if (collision.gameObject.GetComponent<Broom>())
        {
            DestroySelf();
        }
    }

    public void Freeze()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        Debug.Log("hit");
        GetComponent<Pathfinding.AIPath>().enabled = false;
        GetComponent<RatMovement>().enabled = false;
    }

    


    public void DestroySelf()
    {
        Destroy(gameObject);
    }
   
}
