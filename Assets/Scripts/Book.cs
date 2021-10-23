using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
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
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        FindObjectOfType<Game>().BookDestroyed();
    }
}
