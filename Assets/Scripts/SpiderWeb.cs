using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderWeb : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponentInParent<RatSwarm>() && collision.gameObject.GetComponentInParent<RatSwarm>().isBurning == true)
        {
            DestroySelf();
        }
        else if (collision.gameObject.GetComponent<Firebolt>())
        {
            collision.gameObject.GetComponent<Firebolt>().DestroySelf();
            DestroySelf();
        }
        else if (collision.gameObject.GetComponent<Broom>())
        {
            collision.gameObject.GetComponent<Broom>().SetNewTarget();
            DestroySelf();
        }
        else if (collision.gameObject.GetComponent<Fire>())
        {
            collision.gameObject.GetComponent<Fire>().DestroySelf();
            DestroySelf();
        }
        else if (collision.gameObject.GetComponent<Rat>())
        {
            if (collision.gameObject.GetComponentInParent<RatSwarm>().isBurning)
            {
                DestroySelf();
            }
        }
    }

    public void DestroySelf()
    {
        FindObjectOfType<SFX>().CobwebSFX();
        gameObject.SetActive(false);
        Destroy(gameObject);       
    }
}
