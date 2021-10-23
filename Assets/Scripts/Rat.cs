using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rat : MonoBehaviour
{
    public Rigidbody2D rb;
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<Firebolt>())
        {
            
            GetComponentInParent<RatSwarm>().StartBurn();
            rb.velocity = Vector2.zero;
        }
    }

}
