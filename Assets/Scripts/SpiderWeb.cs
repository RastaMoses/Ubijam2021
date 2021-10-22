using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderWeb : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponentInParent<RatSwarm>() && collision.gameObject.GetComponentInParent<RatSwarm>().isBurning == false)
        { 
            return;
        }
        else
        {
            DestroySelf();
        } 
    }


    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}
