using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rat : MonoBehaviour
{
    public bool isFrozen = false;

    private void Start()
    {
        GetComponent<ParticleSystem>().Stop();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<Fire>())
        {            
            GetComponentInParent<RatSwarm>().StartBurn();
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        if (collision.gameObject.GetComponent<Broom>())
        {
            DestroySelf();
        }

        
    }

    public void Freeze()
    {
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        GetComponent<Pathfinding.AIPath>().enabled = false;
        GetComponent<RatMovement>().enabled = false;
    }

    


    public void DestroySelf()
    {
        GetComponent<Dirt>().Destroyed();
        Destroy(gameObject);
    }
   
}
